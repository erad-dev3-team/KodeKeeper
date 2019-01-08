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
			this.ts_SideToolBar = new System.Windows.Forms.ToolStrip();
			this.btn_ToolStrip_Search = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.ts_TopTools = new System.Windows.Forms.ToolStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.btn_Menu_File = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Settings = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Tools = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
			this.p_Search = new System.Windows.Forms.Panel();
			this.p_SearchHeader = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_CloseSearch = new System.Windows.Forms.Label();
			this.tsc_Container.BottomToolStripPanel.SuspendLayout();
			this.tsc_Container.ContentPanel.SuspendLayout();
			this.tsc_Container.RightToolStripPanel.SuspendLayout();
			this.tsc_Container.TopToolStripPanel.SuspendLayout();
			this.tsc_Container.SuspendLayout();
			this.ts_SideToolBar.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.p_SearchHeader.SuspendLayout();
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
			this.tsc_Container.ContentPanel.Controls.Add(this.p_SearchHeader);
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
			this.ss_Status.Location = new System.Drawing.Point(0, 0);
			this.ss_Status.Name = "ss_Status";
			this.ss_Status.Size = new System.Drawing.Size(800, 22);
			this.ss_Status.TabIndex = 0;
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
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Menu_File,
            this.btn_Menu_Edit,
            this.btn_Menu_Settings,
            this.btn_Menu_Tools,
            this.btn_Menu_Help});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btn_Menu_File
			// 
			this.btn_Menu_File.Name = "btn_Menu_File";
			this.btn_Menu_File.Size = new System.Drawing.Size(37, 20);
			this.btn_Menu_File.Text = "File";
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
			// p_Search
			// 
			this.p_Search.BackColor = System.Drawing.SystemColors.ControlLight;
			this.p_Search.Location = new System.Drawing.Point(551, 32);
			this.p_Search.Name = "p_Search";
			this.p_Search.Size = new System.Drawing.Size(200, 200);
			this.p_Search.TabIndex = 0;
			// 
			// p_SearchHeader
			// 
			this.p_SearchHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.p_SearchHeader.Controls.Add(this.lbl_CloseSearch);
			this.p_SearchHeader.Controls.Add(this.label1);
			this.p_SearchHeader.Location = new System.Drawing.Point(551, 23);
			this.p_SearchHeader.Name = "p_SearchHeader";
			this.p_SearchHeader.Size = new System.Drawing.Size(200, 17);
			this.p_SearchHeader.TabIndex = 0;
			this.p_SearchHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_SearchHeader_MouseDown);
			this.p_SearchHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_SearchHeader_MouseMove);
			this.p_SearchHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_SearchHeader_MouseUp);
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
			// 
			// lbl_CloseSearch
			// 
			this.lbl_CloseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_CloseSearch.AutoSize = true;
			this.lbl_CloseSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_CloseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl_CloseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_CloseSearch.ForeColor = System.Drawing.Color.White;
			this.lbl_CloseSearch.Location = new System.Drawing.Point(178, -6);
			this.lbl_CloseSearch.Name = "lbl_CloseSearch";
			this.lbl_CloseSearch.Size = new System.Drawing.Size(28, 29);
			this.lbl_CloseSearch.TabIndex = 1;
			this.lbl_CloseSearch.Text = "×";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tsc_Container);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
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
			this.ts_SideToolBar.ResumeLayout(false);
			this.ts_SideToolBar.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.p_SearchHeader.ResumeLayout(false);
			this.p_SearchHeader.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer tsc_Container;
		private System.Windows.Forms.StatusStrip ss_Status;
		private System.Windows.Forms.ToolStrip ts_SideToolBar;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip ts_TopTools;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_File;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Edit;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Settings;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Tools;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Help;
		private System.Windows.Forms.ToolStripButton btn_ToolStrip_Search;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.Panel p_Search;
		private System.Windows.Forms.Panel p_SearchHeader;
		private System.Windows.Forms.Label lbl_CloseSearch;
		private System.Windows.Forms.Label label1;
	}
}

