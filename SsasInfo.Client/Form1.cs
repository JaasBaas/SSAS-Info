using SsasInfo.Api;
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
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Utility
        SsasInfo.Api.SsasInfoUtility _utility;
        #endregion

        #region Database
        private string _selectedDatabaseName;
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Connecting to server...";

                _utility = new SsasInfo.Api.SsasInfoUtility();
                _utility.DataSource = txtDataSource.Text;
                _utility.OnPartitionProcessUpdate += _utility_OnPartitionProcessUpdate;

                var connected = _utility.TestConnectivity();

                if (connected)
                {
                    lblStatus.Text = "Extracting database names";
                    LoadDatabaseComboBox();
                    lblStatus.Text = "Ready";
                }
                else
                {
                    lblStatus.Text = "Error connective to server";
                }
            }
            finally
            {

            }


        }


        private void LoadDatabaseComboBox()
        {
            cbDatabase.Items.Clear();
            cbDatabase.Items.AddRange(_utility.GetDatabases());
        }

        private void cbDatabase_SelectedValueChanged(object sender, EventArgs e)
        {
            _selectedDatabaseName = cbDatabase.SelectedItem.ToString();
            RefreshDatabase();
            RefreshDimensionInfo();
            LoadPartitionsNewThread();
        }

        private void RefreshDatabase()
        {
            //RefreshCubeTabs();
        }

        private void RefreshCubeTabs()
        {
            while (tabControl1.TabPages.Count > 1)
                tabControl1.TabPages.RemoveAt(1);

            foreach (var s in _utility.GetCubeNames(_selectedDatabaseName))
            {
                //var page = new TabPage();
                //page.Text = s;
                tabControl1.TabPages.Add(s);
            }
        }
        private void RefreshDimensionInfo()
        {
            _dimensions = _utility.GetDimensionInfo(_selectedDatabaseName);
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

        /// <summary>
        /// Load partitions on a new thread
        /// </summary>
        private void LoadPartitionsNewThread()
        {
            var t = new Thread(new ThreadStart(LoadPartitions));
            t.Start();
        }

        /// <summary>
        /// Load partitions
        /// </summary>
        private void LoadPartitions()
        {
            _partitions = _utility.GetPartitionInfo(_selectedDatabaseName);

            PartitionGridDataSource(_partitions);
        }
        #endregion

        #region Partition Grid Data Source
        private delegate void PartitionGridDataSourceSafeCallDelegate(object dataSource);

        private void PartitionGridDataSource(object dataSource)
        {
            if (this.InvokeRequired)
            {
                var d = new PartitionGridDataSourceSafeCallDelegate(PartitionGridDataSource);
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

    }
}
