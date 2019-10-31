using SsasInfo.Api;
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
    public partial class SqlEditForm : Form
    {
        public SqlEditForm()
        {
            InitializeComponent();
        }
        PartitionInfo _partition;
        public SqlEditForm(PartitionInfo partition)
        {
            InitializeComponent();
            _partition = partition;
        }

        private void SqlEditForm_Load(object sender, EventArgs e)
        {
            txtSql.Text = _partition.QueryDefinition;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _partition.QueryDefinition = txtSql.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
