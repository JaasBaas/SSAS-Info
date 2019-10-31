using SsasInfo.Api;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SsasInfo.Client
{
    public partial class MainForm : Form
    {
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Utility
        SsasInfo.Api.SsasInfoUtility _utility = new SsasInfoUtility();
        #endregion

        #region Server
        /// <summary>
        /// Server for which details is currently displayed
        /// </summary>
        private ServerInfo _currentServer;

        /// <summary>
        /// Get the currencly selected server in the server/database tree view control
        /// </summary>
        private ServerInfo _selectedServer
        {
            get
            {
                if (tvServer.SelectedNode.Tag is ServerInfo)
                    return tvServer.SelectedNode.Tag as ServerInfo;
                else if (tvServer.SelectedNode.Tag is DatabaseInfoNew)
                    return tvServer.SelectedNode.Parent.Tag as ServerInfo;
                else return null;
            }
        }
        #endregion

        #region Database
        /// <summary>
        /// Database for which details is currently displayed
        /// </summary>
        private DatabaseInfoNew _currentDatabase;

        /// <summary>
        /// Get the currencly selected database in the server/database tree view control
        /// </summary>
        private DatabaseInfoNew _selectedDatabase
        {
            get
            {
                if (tvServer.SelectedNode.Tag is DatabaseInfoNew)
                    return tvServer.SelectedNode.Tag as DatabaseInfoNew;
                else return null;
            }
        }
        #endregion

        private void RefreshDimensionInfo()
        {
            if (_selectedDatabase != null)
                _dimensions = _utility.GetDimensionInfo(_selectedDatabase);
            dgDimensions.DataSource = _dimensions;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            ProcessSelectedPartitionsNewThread();
        }


        #region Thread safe sets
        private delegate void StatusLabelSafeCallDelegate(string text);
        private void SetStatusLabel(string text)
        {
            if (statusStrip.InvokeRequired)
            {
                var d = new StatusLabelSafeCallDelegate(SetStatusLabel);
                statusStrip.Invoke(d, new object[] { text });
            }
            else { lblStatus.Text = text; }
        }
        private void SetStatusLabelReady()
        { SetStatusLabel("Ready..."); }

        private delegate void CursorSafeCallDelegate(Cursor newCursor);
        private void SetCursorSafe(Cursor newCursor)
        {
            if (this.InvokeRequired)
            {
                var d = new CursorSafeCallDelegate(SetCursorSafe);
                statusStrip.Invoke(d, new object[] { newCursor });
            }
            else { this.Cursor = newCursor; }
        }

        #endregion

        #region Dimensions
        private List<DimensionInfo> _dimensions;

        private void RefreshDimensionTab()
        {
            RefreshDimensionInfo();

        }

        #region Dimension Processing
        private Thread _dimThread = null;
        private void ProcessSelectedDimensions()
        {
            this.Cursor = Cursors.WaitCursor;
            lblStatus.Text = "Processing dimensions...";

            _dimThread = new Thread(new ThreadStart(ProcessSelectedDimensionsThreaded));
            _dimThread.Start();
        }

        private void ProcessSelectedDimensionsThreaded()
        {
            try
            {
                _utility.ProcessDimensions(_dimensions, ProcessType.ProcessDefault);
            }
            finally
            {
                SetStatusLabel("Processing dimensions complete");
                SetCursorSafe(Cursors.Default);
            }

        }
        #endregion
        #endregion

        #region Partitions
        private List<PartitionInfo> _partitions;
        private List<PartitionInfo> _partitionsFiltered { get
            {
                return _partitions.Where(
                    v => v.PartitionName.ToUpper().Contains(txtPartitionFilter.Text.ToUpper())
                    || v.MeasureGroupLong.ToUpper().Contains(txtPartitionFilter.Text.ToUpper())
                    ).ToList();
            } }
  
        /// <summary>
        /// Load partitions on a new thread
        /// </summary>
        private void LoadPartitionsNewThread()
        {
            txtPartitionFilter.Text = "";
            var t = new Thread(new ThreadStart(LoadPartitions));
            t.Start();
        }

        /// <summary>
        /// Load partitions
        /// </summary>
        private void LoadPartitions()
        {
            _partitions = _utility.GetPartitionInfo(_selectedDatabase);

            SetPartitionGridDataSource(_partitions);
        }
        #endregion

        #region Partition Grid Data Source
        private delegate void PartitionGridDataSourceSafeCallDelegate(object dataSource);

        private void SetPartitionGridDataSource(object dataSource)
        {
            if (this.InvokeRequired)
            {
                var d = new PartitionGridDataSourceSafeCallDelegate(SetPartitionGridDataSource);
                this.Invoke(d, new object[] { dataSource });
            }
            else
            {
                if (dgPartitions.DataSource != null)
                    dgPartitions.DataSource = null;
                dgPartitions.DataSource = dataSource;
            }
        }
        #endregion

        #region Partition Processing
        private Thread _parThread = null;
        /// <summary>
        /// Process selected partitions on a new thread
        /// </summary>
        private void ProcessSelectedPartitionsNewThread()
        {
            _parThread = new Thread(new ThreadStart(ProcessSelectedPartitions));
            _parThread.Start();
        }

        /// <summary>
        /// Process selected partitions
        /// </summary>
        private void ProcessSelectedPartitions()
        {
            try
            {
                SetCursorSafe(Cursors.WaitCursor);
                SetStatusLabel("Processing partitions...");

                _utility.ProcessSelectedPartitions(_partitions, ProcessType.ProcessDefault);
            }
            finally
            {
                SetStatusLabelReady();
                SetCursorSafe(Cursors.Default);
            }
        }

        private void _utility_OnPartitionProcessUpdate(object sender, PartitionInfo partitionInfo)
        {
            PartitionGridRefresh();
        }
        #endregion

        #region Partition Grid Refresh
        private delegate void PartitionGridRefreshSafeCallDelegate();
        /// <summary>
        /// Refresh the Partition Grid (Thread safe)
        /// </summary>
        private void PartitionGridRefresh()
        {
            if (this.InvokeRequired)
            {
                var d = new PartitionGridRefreshSafeCallDelegate(PartitionGridRefresh);
                this.Invoke(d, new object[] { });
            }
            else
            {
                dgPartitions.Refresh();
            }
        }
        #endregion

        #region Event Handlers
        private void btnServerRefresh_Click(object sender, EventArgs e)
        {

        }
        private void btnProcessDimensions_Click(object sender, EventArgs e)
        {
            ProcessSelectedDimensions();
        }
        #endregion

        private void btnServerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var server = _utility.AddServer(txtDataSource.Text);

                if (server != null)
                {
                    server.ReloadDatabases();
                    AddServerNode(server, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #region Server Tree View
        private void AddServerNode(ServerInfo server, bool expanded)
        {
            var serverNode = new TreeNodeAdv
            {
                Text = server.DisplayText,
                Tag = server,
                Expanded = expanded
            };

            tvServer.Nodes.Add(serverNode);

            foreach (var db in server.Databases)
            {
                var dbNode = new TreeNodeAdv
                {
                    Tag = db,
                    Text = db.Display
                };
                serverNode.Nodes.Add(dbNode);
            }
        }
        #endregion

        private void tvServer_AfterSelect(object sender, EventArgs e)
        {
            try
            {
                if (_selectedServer != _currentServer)
                    SelectedServerChanged();

                if (_selectedDatabase != _currentDatabase)
                    SelectedDatabaseChanged();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SelectedDatabaseChanged()
        {
            _currentDatabase = _selectedDatabase;

            if (_currentDatabase != null)
            {
                RefreshDimensionInfo();
                LoadPartitionsNewThread();
            }

        }

        private void SelectedServerChanged()
        {
            _currentServer = _selectedServer;
        }

        private void btnEnableSelectedPartitions_Click(object sender, EventArgs e)
        {
            var selected = _partitions.Where(v => v.Selected == true).ToList();
            _utility.EnablePartitions(selected);
        }

        private void txtPartitionFilter_TextChanged(object sender, EventArgs e)
        {
            SetPartitionGridDataSource(_partitionsFiltered);
        }

        private void dgPartitions_CellButtonClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventArgs e)
        {
            if (dgPartitions.SelectedItem is PartitionInfo p)
            {
                var frm = new SqlEditForm(p);
                frm.ShowDialog();
            }
        }

        private void dgPartitions_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowData is PartitionInfo p)
            {
                if (p.State != "Processed" || p.Disabled)
                    e.Style.BackColor = Color.FromArgb(255, 192, 192);
                else if (p.State == "Processed")
                    e.Style.BackColor = Color.FromArgb(192, 255, 192);
            }
        }
    }
}
