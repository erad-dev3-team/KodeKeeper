namespace KodeKeeper
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tsc_Container = new System.Windows.Forms.ToolStripContainer();
			this.ss_Status = new System.Windows.Forms.StatusStrip();
			this.lbl_Info = new System.Windows.Forms.ToolStripStatusLabel();
			this.p_Search = new KodeKeeper.myPanel();
			this.p_Resize = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btn_Search = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.num_LimitResults = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.cb_LimitResults = new System.Windows.Forms.CheckBox();
			this.tb_Search_Tags = new System.Windows.Forms.TextBox();
			this.tb_Search_Description = new System.Windows.Forms.TextBox();
			this.tb_Search_Name = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.p_SearchHeader = new System.Windows.Forms.Panel();
			this.lbl_CloseSearch = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rb_SN_OR_DESC = new System.Windows.Forms.RadioButton();
			this.rb_SN_AND_DESC = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rb_DESC_OR_TAGS = new System.Windows.Forms.RadioButton();
			this.rb_DESC_AND_TAGS = new System.Windows.Forms.RadioButton();
			this.ts_SideToolBar = new System.Windows.Forms.ToolStrip();
			this.btn_ToolStrip_Search = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.ts_TopTools = new System.Windows.Forms.ToolStrip();
			this.ms_Menu = new System.Windows.Forms.MenuStrip();
			this.btn_Menu_File = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_AddNewFile = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Data = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Data_CheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Data_OpenUpdateScreen = new System.Windows.Forms.ToolStripMenuItem();
			this.tsep_Menu_Data_Sep1 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Menu_Data_UploadData = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Settings = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Tools = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_File_ConnectToServer = new System.Windows.Forms.ToolStripMenuItem();
			this.tsc_Container.BottomToolStripPanel.SuspendLayout();
			this.tsc_Container.ContentPanel.SuspendLayout();
			this.tsc_Container.RightToolStripPanel.SuspendLayout();
			this.tsc_Container.TopToolStripPanel.SuspendLayout();
			this.tsc_Container.SuspendLayout();
			this.ss_Status.SuspendLayout();
			this.p_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_LimitResults)).BeginInit();
			this.p_SearchHeader.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.ts_SideToolBar.SuspendLayout();
			this.ms_Menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsc_Container
			// 
			// 
			// tsc_Container.BottomToolStripPanel
			// 
			this.tsc_Container.BottomToolStripPanel.Controls.Add(this.ss_Status);
			// 
			// tsc_Container.ContentPanel
			// 
			this.tsc_Container.ContentPanel.Controls.Add(this.p_Search);
			this.tsc_Container.ContentPanel.Size = new System.Drawing.Size(770, 379);
			this.tsc_Container.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tsc_Container.Location = new System.Drawing.Point(0, 24);
			this.tsc_Container.Name = "tsc_Container";
			// 
			// tsc_Container.RightToolStripPanel
			// 
			this.tsc_Container.RightToolStripPanel.Controls.Add(this.ts_SideToolBar);
			this.tsc_Container.Size = new System.Drawing.Size(800, 426);
			this.tsc_Container.TabIndex = 0;
			this.tsc_Container.Text = "toolStripContainer1";
			// 
			// tsc_Container.TopToolStripPanel
			// 
			this.tsc_Container.TopToolStripPanel.Controls.Add(this.ts_TopTools);
			// 
			// ss_Status
			// 
			this.ss_Status.Dock = System.Windows.Forms.DockStyle.None;
			this.ss_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Info});
			this.ss_Status.Location = new System.Drawing.Point(0, 0);
			this.ss_Status.Name = "ss_Status";
			this.ss_Status.Size = new System.Drawing.Size(800, 22);
			this.ss_Status.TabIndex = 0;
			// 
			// lbl_Info
			// 
			this.lbl_Info.Name = "lbl_Info";
			this.lbl_Info.Size = new System.Drawing.Size(10, 17);
			this.lbl_Info.Text = "|";
			// 
			// p_Search
			// 
			this.p_Search.BackColor = System.Drawing.SystemColors.ControlLight;
			this.p_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p_Search.Controls.Add(this.p_Resize);
			this.p_Search.Controls.Add(this.panel3);
			this.p_Search.Controls.Add(this.btn_Search);
			this.p_Search.Controls.Add(this.label6);
			this.p_Search.Controls.Add(this.num_LimitResults);
			this.p_Search.Controls.Add(this.label5);
			this.p_Search.Controls.Add(this.cb_LimitResults);
			this.p_Search.Controls.Add(this.tb_Search_Tags);
			this.p_Search.Controls.Add(this.tb_Search_Description);
			this.p_Search.Controls.Add(this.tb_Search_Name);
			this.p_Search.Controls.Add(this.label4);
			this.p_Search.Controls.Add(this.label3);
			this.p_Search.Controls.Add(this.label2);
			this.p_Search.Controls.Add(this.p_SearchHeader);
			this.p_Search.Controls.Add(this.panel1);
			this.p_Search.Controls.Add(this.panel2);
			this.p_Search.Location = new System.Drawing.Point(3, 3);
			this.p_Search.MinimumSize = new System.Drawing.Size(221, 139);
			this.p_Search.Name = "p_Search";
			this.p_Search.Size = new System.Drawing.Size(360, 173);
			this.p_Search.TabIndex = 0;
			this.p_Search.LocationChanged += new System.EventHandler(this.p_Search_LocationChanged);
			// 
			// p_Resize
			// 
			this.p_Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.p_Resize.BackgroundImage = global::KodeKeeper.Properties.Resources.resizer;
			this.p_Resize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.p_Resize.Location = new System.Drawing.Point(348, 161);
			this.p_Resize.Name = "p_Resize";
			this.p_Resize.Size = new System.Drawing.Size(10, 10);
			this.p_Resize.TabIndex = 1;
			this.p_Resize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_Resize_MouseDown);
			this.p_Resize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_Resize_MouseMove);
			this.p_Resize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_Resize_MouseUp);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 147);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(358, 1);
			this.panel3.TabIndex = 13;
			// 
			// btn_Search
			// 
			this.btn_Search.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btn_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btn_Search.FlatAppearance.BorderSize = 0;
			this.btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
			this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Search.Location = new System.Drawing.Point(0, 148);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(358, 23);
			this.btn_Search.TabIndex = 8;
			this.btn_Search.Text = "Search";
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			this.btn_Search.MouseEnter += new System.EventHandler(this.btn_Search_MouseEnter);
			this.btn_Search.MouseLeave += new System.EventHandler(this.btn_Search_MouseLeave);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(321, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "entries";
			// 
			// num_LimitResults
			// 
			this.num_LimitResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.num_LimitResults.Enabled = false;
			this.num_LimitResults.Location = new System.Drawing.Point(267, 122);
			this.num_LimitResults.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.num_LimitResults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.num_LimitResults.Name = "num_LimitResults";
			this.num_LimitResults.Size = new System.Drawing.Size(53, 20);
			this.num_LimitResults.TabIndex = 11;
			this.num_LimitResults.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(241, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "first";
			// 
			// cb_LimitResults
			// 
			this.cb_LimitResults.AutoSize = true;
			this.cb_LimitResults.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cb_LimitResults.Location = new System.Drawing.Point(6, 123);
			this.cb_LimitResults.Name = "cb_LimitResults";
			this.cb_LimitResults.Size = new System.Drawing.Size(91, 17);
			this.cb_LimitResults.TabIndex = 9;
			this.cb_LimitResults.Text = "Limit Results: ";
			this.cb_LimitResults.UseVisualStyleBackColor = true;
			this.cb_LimitResults.CheckedChanged += new System.EventHandler(this.cb_LimitResults_CheckedChanged);
			// 
			// tb_Search_Tags
			// 
			this.tb_Search_Tags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Search_Tags.Location = new System.Drawing.Point(82, 93);
			this.tb_Search_Tags.Name = "tb_Search_Tags";
			this.tb_Search_Tags.Size = new System.Drawing.Size(360, 20);
			this.tb_Search_Tags.TabIndex = 6;
			// 
			// tb_Search_Description
			// 
			this.tb_Search_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Search_Description.Location = new System.Drawing.Point(82, 56);
			this.tb_Search_Description.Name = "tb_Search_Description";
			this.tb_Search_Description.Size = new System.Drawing.Size(360, 20);
			this.tb_Search_Description.TabIndex = 5;
			// 
			// tb_Search_Name
			// 
			this.tb_Search_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Search_Name.Location = new System.Drawing.Point(80, 19);
			this.tb_Search_Name.Name = "tb_Search_Name";
			this.tb_Search_Name.Size = new System.Drawing.Size(360, 20);
			this.tb_Search_Name.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tags: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Description: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Script Name: ";
			// 
			// p_SearchHeader
			// 
			this.p_SearchHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.p_SearchHeader.Controls.Add(this.lbl_CloseSearch);
			this.p_SearchHeader.Controls.Add(this.label1);
			this.p_SearchHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_SearchHeader.Location = new System.Drawing.Point(0, 0);
			this.p_SearchHeader.Name = "p_SearchHeader";
			this.p_SearchHeader.Size = new System.Drawing.Size(358, 17);
			this.p_SearchHeader.TabIndex = 0;
			this.p_SearchHeader.MouseCaptureChanged += new System.EventHandler(this.p_SearchHeader_MouseCaptureChanged);
			this.p_SearchHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_SearchHeader_MouseDown);
			this.p_SearchHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_SearchHeader_MouseMove);
			this.p_SearchHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_SearchHeader_MouseUp);
			// 
			// lbl_CloseSearch
			// 
			this.lbl_CloseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_CloseSearch.AutoSize = true;
			this.lbl_CloseSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_CloseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_CloseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_CloseSearch.ForeColor = System.Drawing.Color.White;
			this.lbl_CloseSearch.Location = new System.Drawing.Point(336, -6);
			this.lbl_CloseSearch.Name = "lbl_CloseSearch";
			this.lbl_CloseSearch.Size = new System.Drawing.Size(28, 29);
			this.lbl_CloseSearch.TabIndex = 1;
			this.lbl_CloseSearch.Text = "×";
			this.lbl_CloseSearch.Click += new System.EventHandler(this.lbl_CloseSearch_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search";
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_SearchHeader_MouseDown);
			this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_SearchHeader_MouseMove);
			this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_SearchHeader_MouseUp);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.rb_SN_OR_DESC);
			this.panel1.Controls.Add(this.rb_SN_AND_DESC);
			this.panel1.Location = new System.Drawing.Point(261, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(96, 24);
			this.panel1.TabIndex = 1;
			// 
			// rb_SN_OR_DESC
			// 
			this.rb_SN_OR_DESC.AutoSize = true;
			this.rb_SN_OR_DESC.Checked = true;
			this.rb_SN_OR_DESC.Location = new System.Drawing.Point(57, 3);
			this.rb_SN_OR_DESC.Name = "rb_SN_OR_DESC";
			this.rb_SN_OR_DESC.Size = new System.Drawing.Size(41, 17);
			this.rb_SN_OR_DESC.TabIndex = 1;
			this.rb_SN_OR_DESC.TabStop = true;
			this.rb_SN_OR_DESC.Text = "OR";
			this.rb_SN_OR_DESC.UseVisualStyleBackColor = true;
			// 
			// rb_SN_AND_DESC
			// 
			this.rb_SN_AND_DESC.AutoSize = true;
			this.rb_SN_AND_DESC.Location = new System.Drawing.Point(3, 3);
			this.rb_SN_AND_DESC.Name = "rb_SN_AND_DESC";
			this.rb_SN_AND_DESC.Size = new System.Drawing.Size(48, 17);
			this.rb_SN_AND_DESC.TabIndex = 0;
			this.rb_SN_AND_DESC.Text = "AND";
			this.rb_SN_AND_DESC.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.rb_DESC_OR_TAGS);
			this.panel2.Controls.Add(this.rb_DESC_AND_TAGS);
			this.panel2.Location = new System.Drawing.Point(261, 73);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(96, 24);
			this.panel2.TabIndex = 2;
			// 
			// rb_DESC_OR_TAGS
			// 
			this.rb_DESC_OR_TAGS.AutoSize = true;
			this.rb_DESC_OR_TAGS.Checked = true;
			this.rb_DESC_OR_TAGS.Location = new System.Drawing.Point(57, 3);
			this.rb_DESC_OR_TAGS.Name = "rb_DESC_OR_TAGS";
			this.rb_DESC_OR_TAGS.Size = new System.Drawing.Size(41, 17);
			this.rb_DESC_OR_TAGS.TabIndex = 1;
			this.rb_DESC_OR_TAGS.TabStop = true;
			this.rb_DESC_OR_TAGS.Text = "OR";
			this.rb_DESC_OR_TAGS.UseVisualStyleBackColor = true;
			// 
			// rb_DESC_AND_TAGS
			// 
			this.rb_DESC_AND_TAGS.AutoSize = true;
			this.rb_DESC_AND_TAGS.Location = new System.Drawing.Point(3, 3);
			this.rb_DESC_AND_TAGS.Name = "rb_DESC_AND_TAGS";
			this.rb_DESC_AND_TAGS.Size = new System.Drawing.Size(48, 17);
			this.rb_DESC_AND_TAGS.TabIndex = 0;
			this.rb_DESC_AND_TAGS.Text = "AND";
			this.rb_DESC_AND_TAGS.UseVisualStyleBackColor = true;
			// 
			// ts_SideToolBar
			// 
			this.ts_SideToolBar.Dock = System.Windows.Forms.DockStyle.None;
			this.ts_SideToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ToolStrip_Search,
            this.toolStripDropDownButton1});
			this.ts_SideToolBar.Location = new System.Drawing.Point(0, 3);
			this.ts_SideToolBar.Name = "ts_SideToolBar";
			this.ts_SideToolBar.Size = new System.Drawing.Size(30, 49);
			this.ts_SideToolBar.TabIndex = 0;
			// 
			// btn_ToolStrip_Search
			// 
			this.btn_ToolStrip_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_ToolStrip_Search.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_ToolStrip_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_ToolStrip_Search.Image")));
			this.btn_ToolStrip_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_ToolStrip_Search.Name = "btn_ToolStrip_Search";
			this.btn_ToolStrip_Search.Size = new System.Drawing.Size(28, 28);
			this.btn_ToolStrip_Search.Text = "🔎";
			this.btn_ToolStrip_Search.Click += new System.EventHandler(this.btn_ToolStrip_Search_Click);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(28, 4);
			this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			// 
			// ts_TopTools
			// 
			this.ts_TopTools.Dock = System.Windows.Forms.DockStyle.None;
			this.ts_TopTools.Location = new System.Drawing.Point(3, 0);
			this.ts_TopTools.Name = "ts_TopTools";
			this.ts_TopTools.Size = new System.Drawing.Size(111, 25);
			this.ts_TopTools.TabIndex = 1;
			// 
			// ms_Menu
			// 
			this.ms_Menu.BackColor = System.Drawing.Color.Transparent;
			this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Menu_File,
            this.btn_Menu_Data,
            this.btn_Menu_Edit,
            this.btn_Menu_Settings,
            this.btn_Menu_Tools,
            this.btn_Menu_Help});
			this.ms_Menu.Location = new System.Drawing.Point(0, 0);
			this.ms_Menu.Name = "ms_Menu";
			this.ms_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.ms_Menu.Size = new System.Drawing.Size(800, 24);
			this.ms_Menu.TabIndex = 0;
			// 
			// btn_Menu_File
			// 
			this.btn_Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Menu_AddNewFile,
            this.btn_Menu_File_ConnectToServer});
			this.btn_Menu_File.Name = "btn_Menu_File";
			this.btn_Menu_File.Size = new System.Drawing.Size(37, 20);
			this.btn_Menu_File.Text = "File";
			// 
			// btn_Menu_AddNewFile
			// 
			this.btn_Menu_AddNewFile.Name = "btn_Menu_AddNewFile";
			this.btn_Menu_AddNewFile.Size = new System.Drawing.Size(180, 22);
			this.btn_Menu_AddNewFile.Text = "Add New File";
			this.btn_Menu_AddNewFile.Click += new System.EventHandler(this.btn_Menu_AddNewFile_Click);
			// 
			// btn_Menu_Data
			// 
			this.btn_Menu_Data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Menu_Data_CheckUpdates,
            this.btn_Menu_Data_OpenUpdateScreen,
            this.tsep_Menu_Data_Sep1,
            this.btn_Menu_Data_UploadData});
			this.btn_Menu_Data.Name = "btn_Menu_Data";
			this.btn_Menu_Data.Size = new System.Drawing.Size(43, 20);
			this.btn_Menu_Data.Text = "Data";
			// 
			// btn_Menu_Data_CheckUpdates
			// 
			this.btn_Menu_Data_CheckUpdates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Menu_Data_CheckUpdates.Name = "btn_Menu_Data_CheckUpdates";
			this.btn_Menu_Data_CheckUpdates.Size = new System.Drawing.Size(182, 22);
			this.btn_Menu_Data_CheckUpdates.Text = "Check Update";
			this.btn_Menu_Data_CheckUpdates.Click += new System.EventHandler(this.btn_Menu_Data_CheckUpdates_Click);
			// 
			// btn_Menu_Data_OpenUpdateScreen
			// 
			this.btn_Menu_Data_OpenUpdateScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Menu_Data_OpenUpdateScreen.Name = "btn_Menu_Data_OpenUpdateScreen";
			this.btn_Menu_Data_OpenUpdateScreen.Size = new System.Drawing.Size(182, 22);
			this.btn_Menu_Data_OpenUpdateScreen.Text = "Open Update Screen";
			this.btn_Menu_Data_OpenUpdateScreen.Click += new System.EventHandler(this.btn_Menu_Data_OpenUpdateScreen_Click);
			// 
			// tsep_Menu_Data_Sep1
			// 
			this.tsep_Menu_Data_Sep1.Name = "tsep_Menu_Data_Sep1";
			this.tsep_Menu_Data_Sep1.Size = new System.Drawing.Size(179, 6);
			// 
			// btn_Menu_Data_UploadData
			// 
			this.btn_Menu_Data_UploadData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Menu_Data_UploadData.Name = "btn_Menu_Data_UploadData";
			this.btn_Menu_Data_UploadData.Size = new System.Drawing.Size(182, 22);
			this.btn_Menu_Data_UploadData.Text = "Upload Changes";
			// 
			// btn_Menu_Edit
			// 
			this.btn_Menu_Edit.Name = "btn_Menu_Edit";
			this.btn_Menu_Edit.Size = new System.Drawing.Size(39, 20);
			this.btn_Menu_Edit.Text = "Edit";
			// 
			// btn_Menu_Settings
			// 
			this.btn_Menu_Settings.Name = "btn_Menu_Settings";
			this.btn_Menu_Settings.Size = new System.Drawing.Size(61, 20);
			this.btn_Menu_Settings.Text = "Settings";
			// 
			// btn_Menu_Tools
			// 
			this.btn_Menu_Tools.Name = "btn_Menu_Tools";
			this.btn_Menu_Tools.Size = new System.Drawing.Size(48, 20);
			this.btn_Menu_Tools.Text = "Tools";
			// 
			// btn_Menu_Help
			// 
			this.btn_Menu_Help.Name = "btn_Menu_Help";
			this.btn_Menu_Help.Size = new System.Drawing.Size(44, 20);
			this.btn_Menu_Help.Text = "Help";
			// 
			// btn_Menu_File_ConnectToServer
			// 
			this.btn_Menu_File_ConnectToServer.Name = "btn_Menu_File_ConnectToServer";
			this.btn_Menu_File_ConnectToServer.Size = new System.Drawing.Size(180, 22);
			this.btn_Menu_File_ConnectToServer.Text = "Connect to Server";
			this.btn_Menu_File_ConnectToServer.Click += new System.EventHandler(this.btn_Menu_File_ConnectToServer_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tsc_Container);
			this.Controls.Add(this.ms_Menu);
			this.MainMenuStrip = this.ms_Menu;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.tsc_Container.BottomToolStripPanel.ResumeLayout(false);
			this.tsc_Container.BottomToolStripPanel.PerformLayout();
			this.tsc_Container.ContentPanel.ResumeLayout(false);
			this.tsc_Container.RightToolStripPanel.ResumeLayout(false);
			this.tsc_Container.RightToolStripPanel.PerformLayout();
			this.tsc_Container.TopToolStripPanel.ResumeLayout(false);
			this.tsc_Container.TopToolStripPanel.PerformLayout();
			this.tsc_Container.ResumeLayout(false);
			this.tsc_Container.PerformLayout();
			this.ss_Status.ResumeLayout(false);
			this.ss_Status.PerformLayout();
			this.p_Search.ResumeLayout(false);
			this.p_Search.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_LimitResults)).EndInit();
			this.p_SearchHeader.ResumeLayout(false);
			this.p_SearchHeader.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ts_SideToolBar.ResumeLayout(false);
			this.ts_SideToolBar.PerformLayout();
			this.ms_Menu.ResumeLayout(false);
			this.ms_Menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer tsc_Container;
		private System.Windows.Forms.StatusStrip ss_Status;
		private System.Windows.Forms.ToolStrip ts_SideToolBar;
		private System.Windows.Forms.MenuStrip ms_Menu;
		private System.Windows.Forms.ToolStrip ts_TopTools;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_File;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Edit;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Settings;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Tools;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Help;
		private System.Windows.Forms.ToolStripButton btn_ToolStrip_Search;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.Panel p_SearchHeader;
		private System.Windows.Forms.Label lbl_CloseSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.TextBox tb_Search_Tags;
		private System.Windows.Forms.TextBox tb_Search_Description;
		private System.Windows.Forms.TextBox tb_Search_Name;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rb_SN_OR_DESC;
		private System.Windows.Forms.RadioButton rb_SN_AND_DESC;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rb_DESC_OR_TAGS;
		private System.Windows.Forms.RadioButton rb_DESC_AND_TAGS;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown num_LimitResults;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox cb_LimitResults;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel p_Resize;
		private myPanel p_Search;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_AddNewFile;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Data;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Data_CheckUpdates;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Data_OpenUpdateScreen;
		private System.Windows.Forms.ToolStripSeparator tsep_Menu_Data_Sep1;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Data_UploadData;
		private System.Windows.Forms.ToolStripStatusLabel lbl_Info;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_File_ConnectToServer;
	}
}

