namespace SsasInfo.Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn1 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn2 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn3 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDimensions = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProcessDimensions = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectAllPartition = new System.Windows.Forms.Button();
            this.dgDimensions = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tabCubeTemplate = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dgPartitions = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnServerRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDimensions)).BeginInit();
            this.tabCubeTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartitions)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.tabServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(432, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(74, 21);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(512, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Source";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDataSource
            // 
            this.txtDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataSource.Location = new System.Drawing.Point(83, 3);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(343, 20);
            this.txtDataSource.TabIndex = 4;
            this.txtDataSource.Text = "127.0.0.1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDataSource, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConnect, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbDatabase, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 27);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // cbDatabase
            // 
            this.cbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(592, 3);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(344, 21);
            this.cbDatabase.TabIndex = 5;
            this.cbDatabase.SelectedValueChanged += new System.EventHandler(this.cbDatabase_SelectedValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabServer);
            this.tabControl1.Controls.Add(this.tabDimensions);
            this.tabControl1.Controls.Add(this.tabCubeTemplate);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 385);
            this.tabControl1.TabIndex = 6;
            // 
            // tabDimensions
            // 
            this.tabDimensions.Controls.Add(this.button3);
            this.tabDimensions.Controls.Add(this.btnProcessDimensions);
            this.tabDimensions.Controls.Add(this.button1);
            this.tabDimensions.Controls.Add(this.btnSelectAllPartition);
            this.tabDimensions.Controls.Add(this.dgDimensions);
            this.tabDimensions.Location = new System.Drawing.Point(4, 22);
            this.tabDimensions.Name = "tabDimensions";
            this.tabDimensions.Padding = new System.Windows.Forms.Padding(3);
            this.tabDimensions.Size = new System.Drawing.Size(931, 359);
            this.tabDimensions.TabIndex = 0;
            this.tabDimensions.Text = "Dimensions";
            this.tabDimensions.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(6, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnProcessDimensions
            // 
            this.btnProcessDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProcessDimensions.Location = new System.Drawing.Point(296, 330);
            this.btnProcessDimensions.Name = "btnProcessDimensions";
            this.btnProcessDimensions.Size = new System.Drawing.Size(119, 23);
            this.btnProcessDimensions.TabIndex = 4;
            this.btnProcessDimensions.Text = "Process Selected";
            this.btnProcessDimensions.UseVisualStyleBackColor = true;
            this.btnProcessDimensions.Click += new System.EventHandler(this.btnProcessDimensions_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(168, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Select Unprocessed";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSelectAllPartition
            // 
            this.btnSelectAllPartition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAllPartition.Location = new System.Drawing.Point(87, 330);
            this.btnSelectAllPartition.Name = "btnSelectAllPartition";
            this.btnSelectAllPartition.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAllPartition.TabIndex = 2;
            this.btnSelectAllPartition.Text = "Select All";
            this.btnSelectAllPartition.UseVisualStyleBackColor = true;
            // 
            // dgDimensions
            // 
            this.dgDimensions.AccessibleName = "Table";
            this.dgDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDimensions.AutoGenerateColumns = false;
            gridCheckBoxColumn1.HeaderText = "Selected";
            gridCheckBoxColumn1.MappingName = "Selected";
            gridCheckBoxColumn1.Width = 40D;
            gridTextColumn1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.HeaderText = "Partition Name (ID)";
            gridTextColumn1.MappingName = "Display";
            gridTextColumn2.HeaderText = "State";
            gridTextColumn2.MappingName = "State";
            gridDateTimeColumn1.HeaderText = "Last Processed";
            gridDateTimeColumn1.MappingName = "LastProcessed";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.dgDimensions.Columns.Add(gridCheckBoxColumn1);
            this.dgDimensions.Columns.Add(gridTextColumn1);
            this.dgDimensions.Columns.Add(gridTextColumn2);
            this.dgDimensions.Columns.Add(gridDateTimeColumn1);
            this.dgDimensions.Location = new System.Drawing.Point(6, 6);
            this.dgDimensions.Name = "dgDimensions";
            this.dgDimensions.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            this.dgDimensions.ShowGroupDropArea = true;
            this.dgDimensions.ShowRowHeader = true;
            this.dgDimensions.Size = new System.Drawing.Size(919, 318);
            this.dgDimensions.TabIndex = 1;
            this.dgDimensions.Text = "sfDataGrid1";
            // 
            // tabCubeTemplate
            // 
            this.tabCubeTemplate.Controls.Add(this.button4);
            this.tabCubeTemplate.Controls.Add(this.button5);
            this.tabCubeTemplate.Controls.Add(this.button6);
            this.tabCubeTemplate.Controls.Add(this.button7);
            this.tabCubeTemplate.Controls.Add(this.dgPartitions);
            this.tabCubeTemplate.Location = new System.Drawing.Point(4, 22);
            this.tabCubeTemplate.Name = "tabCubeTemplate";
            this.tabCubeTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCubeTemplate.Size = new System.Drawing.Size(931, 359);
            this.tabCubeTemplate.TabIndex = 1;
            this.tabCubeTemplate.Text = "Partitions";
            this.tabCubeTemplate.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(6, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(296, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Process Selected";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(168, 330);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Select Unprocessed";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.Location = new System.Drawing.Point(87, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Select All";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dgPartitions
            // 
            this.dgPartitions.AccessibleName = "Table";
            this.dgPartitions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPartitions.AutoGenerateColumns = false;
            gridCheckBoxColumn2.HeaderText = "Selected";
            gridCheckBoxColumn2.MappingName = "Selected";
            gridCheckBoxColumn2.Width = 40D;
            gridTextColumn3.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn3.HeaderText = "Partition Name (ID)";
            gridTextColumn3.MappingName = "Display";
            gridTextColumn4.HeaderText = "State";
            gridTextColumn4.MappingName = "State";
            gridDateTimeColumn2.Format = "d";
            gridDateTimeColumn2.HeaderText = "Last Processed";
            gridDateTimeColumn2.MappingName = "LastProcessed";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.HeaderText = "Cube";
            gridTextColumn5.MappingName = "CubeName";
            gridCheckBoxColumn3.AllowEditing = false;
            gridCheckBoxColumn3.HeaderText = "Processing";
            gridCheckBoxColumn3.MappingName = "Processing";
            this.dgPartitions.Columns.Add(gridCheckBoxColumn2);
            this.dgPartitions.Columns.Add(gridTextColumn3);
            this.dgPartitions.Columns.Add(gridTextColumn4);
            this.dgPartitions.Columns.Add(gridDateTimeColumn2);
            this.dgPartitions.Columns.Add(gridTextColumn5);
            this.dgPartitions.Columns.Add(gridCheckBoxColumn3);
            this.dgPartitions.Location = new System.Drawing.Point(6, 6);
            this.dgPartitions.Name = "dgPartitions";
            this.dgPartitions.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            this.dgPartitions.ShowGroupDropArea = true;
            this.dgPartitions.ShowRowHeader = true;
            this.dgPartitions.Size = new System.Drawing.Size(919, 318);
            this.dgPartitions.TabIndex = 7;
            this.dgPartitions.Text = "sfDataGrid1";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 433);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(963, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.Text = "Ready...";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // tabServer
            // 
            this.tabServer.Controls.Add(this.btnServerRefresh);
            this.tabServer.Controls.Add(this.sfDataGrid1);
            this.tabServer.Location = new System.Drawing.Point(4, 22);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabServer.Size = new System.Drawing.Size(931, 359);
            this.tabServer.TabIndex = 2;
            this.tabServer.Text = "Server";
            this.tabServer.UseVisualStyleBackColor = true;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.Location = new System.Drawing.Point(6, 6);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Size = new System.Drawing.Size(919, 318);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // btnServerRefresh
            // 
            this.btnServerRefresh.Location = new System.Drawing.Point(6, 330);
            this.btnServerRefresh.Name = "btnServerRefresh";
            this.btnServerRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnServerRefresh.TabIndex = 1;
            this.btnServerRefresh.Text = "Refresh";
            this.btnServerRefresh.UseVisualStyleBackColor = true;
            this.btnServerRefresh.Click += new System.EventHandler(this.btnServerRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 455);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "SSAS Info";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDimensions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDimensions)).EndInit();
            this.tabCubeTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPartitions)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabServer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.TabPage tabDimensions;
        private System.Windows.Forms.TabPage tabCubeTemplate;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgDimensions;
        private System.Windows.Forms.Button btnProcessDimensions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelectAllPartition;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgPartitions;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.Button btnServerRefresh;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
    }
}

