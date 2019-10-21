using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SsasInfo.Client
{
    public partial class Form1 : Form
    {
        SsasInfo.Api.SsasInfoUtility _utility;
        private string _selectedDatabaseName { get { return cbDatabase.SelectedItem.ToString(); } }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Connecting to server...";

                _utility = new SsasInfo.Api.SsasInfoUtility();
                _utility.DataSource = txtDataSource.Text;

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
            RefreshDatabase();
            RefreshDimensionInfo();
        }

        private void RefreshDatabase()
        {
            RefreshCubeTabs();
        }

        private void RefreshCubeTabs()
        {
            while (tabControl1.TabPages.Count > 1)
                tabControl1.TabPages.RemoveAt(1);

            foreach(var s in _utility.GetCubeNames(_selectedDatabaseName))
            {
                //var page = new TabPage();
                //page.Text = s;
                tabControl1.TabPages.Add(s);
            }
        }
        private void RefreshDimensionInfo()
        {
            var dims = _utility.GetDimensionInfo(_selectedDatabaseName);
            bsDimensionInfo.DataSource = dims;
        }
    }
}
