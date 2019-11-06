namespace SsasInfo.Client
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn5 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn3 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn1 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn3 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn4 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn1 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDimensions = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProcessDimensions = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectAllPartition = new System.Windows.Forms.Button();
            this.dgDimensions = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tabPartitions = new System.Windows.Forms.TabPage();
            this.cbPartitionProcessType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartitionFilter = new System.Windows.Forms.TextBox();
            this.btnEnableSelectedPartitions = new System.Windows.Forms.Button();
            this.btnPartitionRefresh = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dgPartitions = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.tvServer = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.btnServerAdd = new System.Windows.Forms.Button();
            this.nudPartitionThreads = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDimensions)).BeginInit();
            this.tabPartitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPartitionProcessType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartitions)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPartitionThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataSource
            // 
            this.txtDataSource.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDataSource.Location = new System.Drawing.Point(12, 12);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(238, 20);
            this.txtDataSource.TabIndex = 4;
            this.txtDataSource.Text = "127.0.0.1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabDimensions);
            this.tabControl1.Controls.Add(this.tabPartitions);
            this.tabControl1.Location = new System.Drawing.Point(285, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 419);
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
            this.tabDimensions.Size = new System.Drawing.Size(839, 393);
            this.tabDimensions.TabIndex = 0;
            this.tabDimensions.Text = "Dimensions";
            this.tabDimensions.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(6, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnProcessDimensions
            // 
            this.btnProcessDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProcessDimensions.Location = new System.Drawing.Point(296, 363);
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
            this.button1.Location = new System.Drawing.Point(168, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Select Unprocessed";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSelectAllPartition
            // 
            this.btnSelectAllPartition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAllPartition.Location = new System.Drawing.Point(87, 363);
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
            gridCheckBoxColumn5.HeaderText = "Selected";
            gridCheckBoxColumn5.MappingName = "Selected";
            gridCheckBoxColumn5.Width = 40D;
            gridTextColumn7.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn7.HeaderText = "Partition Name (ID)";
            gridTextColumn7.MappingName = "Display";
            gridTextColumn8.HeaderText = "State";
            gridTextColumn8.MappingName = "State";
            gridDateTimeColumn3.HeaderText = "Last Processed";
            gridDateTimeColumn3.MappingName = "LastProcessed";
            gridDateTimeColumn3.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.dgDimensions.Columns.Add(gridCheckBoxColumn5);
            this.dgDimensions.Columns.Add(gridTextColumn7);
            this.dgDimensions.Columns.Add(gridTextColumn8);
            this.dgDimensions.Columns.Add(gridDateTimeColumn3);
            this.dgDimensions.Location = new System.Drawing.Point(6, 6);
            this.dgDimensions.Name = "dgDimensions";
            this.dgDimensions.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            this.dgDimensions.ShowGroupDropArea = true;
            this.dgDimensions.ShowRowHeader = true;
            this.dgDimensions.Size = new System.Drawing.Size(694, 351);
            this.dgDimensions.TabIndex = 1;
            this.dgDimensions.Text = "sfDataGrid1";
            // 
            // tabPartitions
            // 
            this.tabPartitions.Controls.Add(this.nudPartitionThreads);
            this.tabPartitions.Controls.Add(this.cbPartitionProcessType);
            this.tabPartitions.Controls.Add(this.label1);
            this.tabPartitions.Controls.Add(this.txtPartitionFilter);
            this.tabPartitions.Controls.Add(this.btnEnableSelectedPartitions);
            this.tabPartitions.Controls.Add(this.btnPartitionRefresh);
            this.tabPartitions.Controls.Add(this.button5);
            this.tabPartitions.Controls.Add(this.button6);
            this.tabPartitions.Controls.Add(this.button7);
            this.tabPartitions.Controls.Add(this.dgPartitions);
            this.tabPartitions.Location = new System.Drawing.Point(4, 22);
            this.tabPartitions.Name = "tabPartitions";
            this.tabPartitions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPartitions.Size = new System.Drawing.Size(839, 393);
            this.tabPartitions.TabIndex = 1;
            this.tabPartitions.Text = "Partitions";
            this.tabPartitions.UseVisualStyleBackColor = true;
            // 
            // cbPartitionProcessType
            // 
            this.cbPartitionProcessType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPartitionProcessType.Location = new System.Drawing.Point(712, 367);
            this.cbPartitionProcessType.MaxDropDownItems = 10;
            this.cbPartitionProcessType.Name = "cbPartitionProcessType";
            this.cbPartitionProcessType.Size = new System.Drawing.Size(121, 20);
            this.cbPartitionProcessType.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cbPartitionProcessType, "Process Type");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filter";
            // 
            // txtPartitionFilter
            // 
            this.txtPartitionFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartitionFilter.Location = new System.Drawing.Point(41, 6);
            this.txtPartitionFilter.Name = "txtPartitionFilter";
            this.txtPartitionFilter.Size = new System.Drawing.Size(792, 20);
            this.txtPartitionFilter.TabIndex = 13;
            this.txtPartitionFilter.TextChanged += new System.EventHandler(this.txtPartitionFilter_TextChanged);
            // 
            // btnEnableSelectedPartitions
            // 
            this.btnEnableSelectedPartitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnableSelectedPartitions.Location = new System.Drawing.Point(421, 364);
            this.btnEnableSelectedPartitions.Name = "btnEnableSelectedPartitions";
            this.btnEnableSelectedPartitions.Size = new System.Drawing.Size(119, 23);
            this.btnEnableSelectedPartitions.TabIndex = 12;
            this.btnEnableSelectedPartitions.Text = "Enable Selected";
            this.btnEnableSelectedPartitions.UseVisualStyleBackColor = true;
            this.btnEnableSelectedPartitions.Click += new System.EventHandler(this.btnEnableSelectedPartitions_Click);
            // 
            // btnPartitionRefresh
            // 
            this.btnPartitionRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPartitionRefresh.Location = new System.Drawing.Point(6, 364);
            this.btnPartitionRefresh.Name = "btnPartitionRefresh";
            this.btnPartitionRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnPartitionRefresh.TabIndex = 11;
            this.btnPartitionRefresh.Text = "Refresh";
            this.btnPartitionRefresh.UseVisualStyleBackColor = true;
            this.btnPartitionRefresh.Click += new System.EventHandler(this.btnPartitionRefresh_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(296, 364);
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
            this.button6.Location = new System.Drawing.Point(168, 364);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Select Unprocessed";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.Location = new System.Drawing.Point(87, 364);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Select All";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dgPartitions
            // 
            this.dgPartitions.AccessibleName = "Table";
            this.dgPartitions.AllowDraggingColumns = true;
            this.dgPartitions.AllowResizingColumns = true;
            this.dgPartitions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPartitions.AutoGenerateColumns = false;
            this.dgPartitions.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            gridCheckBoxColumn1.AllowDragging = true;
            gridCheckBoxColumn1.AllowEditing = false;
            gridCheckBoxColumn1.AllowResizing = true;
            gridCheckBoxColumn1.HeaderText = "Disabled";
            gridCheckBoxColumn1.MappingName = "Disabled";
            gridCheckBoxColumn1.Width = 40D;
            gridCheckBoxColumn3.AllowDragging = true;
            gridCheckBoxColumn3.AllowResizing = true;
            gridCheckBoxColumn3.HeaderText = "Selected";
            gridCheckBoxColumn3.MappingName = "Selected";
            gridCheckBoxColumn3.Width = 40D;
            gridTextColumn1.AllowDragging = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "Cube";
            gridTextColumn1.MappingName = "CubeDisplay";
            gridTextColumn2.AllowDragging = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "Measure Group (ID)";
            gridTextColumn2.MappingName = "MeasureGroupLong";
            gridTextColumn5.AllowDragging = true;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowResizing = true;
            gridTextColumn5.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn5.HeaderText = "Partition Name (ID)";
            gridTextColumn5.MappingName = "Display";
            gridTextColumn6.AllowDragging = true;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowResizing = true;
            gridTextColumn6.HeaderText = "State";
            gridTextColumn6.MappingName = "State";
            gridDateTimeColumn1.AllowDragging = true;
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.AllowResizing = true;
            gridDateTimeColumn1.Format = "d";
            gridDateTimeColumn1.HeaderText = "Last Processed";
            gridDateTimeColumn1.MappingName = "LastProcessed";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridCheckBoxColumn4.AllowDragging = true;
            gridCheckBoxColumn4.AllowEditing = false;
            gridCheckBoxColumn4.AllowResizing = true;
            gridCheckBoxColumn4.HeaderText = "Processing";
            gridCheckBoxColumn4.MappingName = "Processing";
            gridButtonColumn1.AllowDefaultButtonText = true;
            gridButtonColumn1.AllowDragging = true;
            gridButtonColumn1.AllowEditing = false;
            gridButtonColumn1.AllowGrouping = false;
            gridButtonColumn1.AllowResizing = true;
            gridButtonColumn1.AllowSorting = false;
            gridButtonColumn1.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn1.DefaultButtonText = "SQL";
            gridButtonColumn1.HeaderText = "Column9";
            gridButtonColumn1.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn1.MappingName = "Column9";
            gridButtonColumn1.MaximumWidth = 60D;
            gridButtonColumn1.ShowToolTip = true;
            this.dgPartitions.Columns.Add(gridCheckBoxColumn1);
            this.dgPartitions.Columns.Add(gridCheckBoxColumn3);
            this.dgPartitions.Columns.Add(gridTextColumn1);
            this.dgPartitions.Columns.Add(gridTextColumn2);
            this.dgPartitions.Columns.Add(gridTextColumn5);
            this.dgPartitions.Columns.Add(gridTextColumn6);
            this.dgPartitions.Columns.Add(gridDateTimeColumn1);
            this.dgPartitions.Columns.Add(gridCheckBoxColumn4);
            this.dgPartitions.Columns.Add(gridButtonColumn1);
            this.dgPartitions.Location = new System.Drawing.Point(6, 32);
            this.dgPartitions.Name = "dgPartitions";
            this.dgPartitions.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            this.dgPartitions.ShowGroupDropArea = true;
            this.dgPartitions.ShowRowHeader = true;
            this.dgPartitions.Size = new System.Drawing.Size(827, 326);
            this.dgPartitions.TabIndex = 7;
            this.dgPartitions.Text = "sfDataGrid1";
            this.dgPartitions.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.dgPartitions_QueryRowStyle);
            this.dgPartitions.CellButtonClick += new Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventHandler(this.dgPartitions_CellButtonClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 434);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1144, 22);
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
            // tvServer
            // 
            this.tvServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            this.tvServer.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.tvServer.BeforeTouchSize = new System.Drawing.Size(267, 386);
            // 
            // 
            // 
            this.tvServer.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvServer.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.tvServer.HelpTextControl.Name = "helpText";
            this.tvServer.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.tvServer.HelpTextControl.TabIndex = 0;
            this.tvServer.HelpTextControl.Text = "help text";
            this.tvServer.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.tvServer.Location = new System.Drawing.Point(12, 41);
            this.tvServer.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.tvServer.Name = "tvServer";
            this.tvServer.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.tvServer.Size = new System.Drawing.Size(267, 386);
            this.tvServer.TabIndex = 2;
            this.tvServer.Text = "treeViewAdv1";
            // 
            // 
            // 
            this.tvServer.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.tvServer.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvServer.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.tvServer.ToolTipControl.Name = "toolTip";
            this.tvServer.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.tvServer.ToolTipControl.TabIndex = 1;
            this.tvServer.ToolTipControl.Text = "toolTip";
            this.tvServer.AfterSelect += new System.EventHandler(this.tvServer_AfterSelect);
            // 
            // btnServerAdd
            // 
            this.btnServerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerAdd.Location = new System.Drawing.Point(256, 12);
            this.btnServerAdd.Name = "btnServerAdd";
            this.btnServerAdd.Size = new System.Drawing.Size(23, 23);
            this.btnServerAdd.TabIndex = 8;
            this.btnServerAdd.Text = "+";
            this.btnServerAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnServerAdd, "Add server");
            this.btnServerAdd.UseVisualStyleBackColor = true;
            this.btnServerAdd.Click += new System.EventHandler(this.btnServerAdd_Click);
            // 
            // nudPartitionThreads
            // 
            this.nudPartitionThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPartitionThreads.Location = new System.Drawing.Point(664, 367);
            this.nudPartitionThreads.Name = "nudPartitionThreads";
            this.nudPartitionThreads.Size = new System.Drawing.Size(42, 20);
            this.nudPartitionThreads.TabIndex = 16;
            this.toolTip1.SetToolTip(this.nudPartitionThreads, "Max Processing Threads");
            this.nudPartitionThreads.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 456);
            this.Controls.Add(this.btnServerAdd);
            this.Controls.Add(this.txtDataSource);
            this.Controls.Add(this.tvServer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "SSAS Info";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDimensions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDimensions)).EndInit();
            this.tabPartitions.ResumeLayout(false);
            this.tabPartitions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPartitionProcessType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartitions)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPartitionThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.TabPage tabDimensions;
        private System.Windows.Forms.TabPage tabPartitions;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgDimensions;
        private System.Windows.Forms.Button btnProcessDimensions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelectAllPartition;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPartitionRefresh;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgPartitions;
        private System.ComponentModel.BackgroundWorker bgw;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv tvServer;
        private System.Windows.Forms.Button btnServerAdd;
        private System.Windows.Forms.Button btnEnableSelectedPartitions;
        private System.Windows.Forms.TextBox txtPartitionFilter;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.ListView.SfComboBox cbPartitionProcessType;
        private System.Windows.Forms.NumericUpDown nudPartitionThreads;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

