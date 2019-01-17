namespace KodeKeeper
{
	partial class dataUpdate
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lv_UpdateNumbers = new System.Windows.Forms.ListView();
			this.ch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cb_ShowQuery = new System.Windows.Forms.CheckBox();
			this.cb_SkipFileContants = new System.Windows.Forms.CheckBox();
			this.cb_SkipImageData = new System.Windows.Forms.CheckBox();
			this.cb_OverwriteUpdateDateTime = new System.Windows.Forms.CheckBox();
			this.mtb_DateTime = new System.Windows.Forms.MaskedTextBox();
			this.btn_SelectDateTime = new System.Windows.Forms.Button();
			this.btn_StartUpdate = new System.Windows.Forms.Button();
			this.btn_Close = new System.Windows.Forms.Button();
			this.ss_Status = new System.Windows.Forms.StatusStrip();
			this.lbl_Info = new System.Windows.Forms.ToolStripStatusLabel();
			this.rtb_Query = new System.Windows.Forms.RichTextBox();
			this.btn_CopyQuery = new System.Windows.Forms.Button();
			this.btn_SaveQuery = new System.Windows.Forms.Button();
			this.btn_StartQuery = new System.Windows.Forms.Button();
			this.pb_Progress = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1.SuspendLayout();
			this.ss_Status.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lv_UpdateNumbers);
			this.groupBox1.Location = new System.Drawing.Point(13, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(273, 185);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Updatable Rows";
			// 
			// lv_UpdateNumbers
			// 
			this.lv_UpdateNumbers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_ID,
            this.ch_Column,
            this.ch_Number});
			this.lv_UpdateNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_UpdateNumbers.FullRowSelect = true;
			this.lv_UpdateNumbers.GridLines = true;
			this.lv_UpdateNumbers.Location = new System.Drawing.Point(3, 16);
			this.lv_UpdateNumbers.Name = "lv_UpdateNumbers";
			this.lv_UpdateNumbers.Size = new System.Drawing.Size(267, 166);
			this.lv_UpdateNumbers.TabIndex = 0;
			this.lv_UpdateNumbers.UseCompatibleStateImageBehavior = false;
			this.lv_UpdateNumbers.View = System.Windows.Forms.View.Details;
			// 
			// ch_ID
			// 
			this.ch_ID.Text = "#";
			this.ch_ID.Width = 40;
			// 
			// ch_Column
			// 
			this.ch_Column.Text = "Columns";
			this.ch_Column.Width = 139;
			// 
			// ch_Number
			// 
			this.ch_Number.Text = "Rows";
			this.ch_Number.Width = 67;
			// 
			// cb_ShowQuery
			// 
			this.cb_ShowQuery.AutoSize = true;
			this.cb_ShowQuery.Location = new System.Drawing.Point(16, 210);
			this.cb_ShowQuery.Name = "cb_ShowQuery";
			this.cb_ShowQuery.Size = new System.Drawing.Size(187, 17);
			this.cb_ShowQuery.TabIndex = 1;
			this.cb_ShowQuery.Text = "Show update query before update";
			this.cb_ShowQuery.UseVisualStyleBackColor = true;
			this.cb_ShowQuery.CheckedChanged += new System.EventHandler(this.cb_ShowQuery_CheckedChanged);
			// 
			// cb_SkipFileContants
			// 
			this.cb_SkipFileContants.AutoSize = true;
			this.cb_SkipFileContants.Location = new System.Drawing.Point(16, 233);
			this.cb_SkipFileContants.Name = "cb_SkipFileContants";
			this.cb_SkipFileContants.Size = new System.Drawing.Size(170, 17);
			this.cb_SkipFileContants.TabIndex = 2;
			this.cb_SkipFileContants.Text = "Skip downloading file contents";
			this.cb_SkipFileContants.UseVisualStyleBackColor = true;
			// 
			// cb_SkipImageData
			// 
			this.cb_SkipImageData.AutoSize = true;
			this.cb_SkipImageData.Location = new System.Drawing.Point(16, 256);
			this.cb_SkipImageData.Name = "cb_SkipImageData";
			this.cb_SkipImageData.Size = new System.Drawing.Size(207, 17);
			this.cb_SkipImageData.TabIndex = 3;
			this.cb_SkipImageData.Text = "Skip downloading updated image data";
			this.cb_SkipImageData.UseVisualStyleBackColor = true;
			// 
			// cb_OverwriteUpdateDateTime
			// 
			this.cb_OverwriteUpdateDateTime.AutoSize = true;
			this.cb_OverwriteUpdateDateTime.Location = new System.Drawing.Point(16, 279);
			this.cb_OverwriteUpdateDateTime.Name = "cb_OverwriteUpdateDateTime";
			this.cb_OverwriteUpdateDateTime.Size = new System.Drawing.Size(129, 17);
			this.cb_OverwriteUpdateDateTime.TabIndex = 4;
			this.cb_OverwriteUpdateDateTime.Text = "Overwrite update time";
			this.cb_OverwriteUpdateDateTime.UseVisualStyleBackColor = true;
			// 
			// mtb_DateTime
			// 
			this.mtb_DateTime.Enabled = false;
			this.mtb_DateTime.Location = new System.Drawing.Point(151, 277);
			this.mtb_DateTime.Name = "mtb_DateTime";
			this.mtb_DateTime.Size = new System.Drawing.Size(110, 20);
			this.mtb_DateTime.TabIndex = 5;
			// 
			// btn_SelectDateTime
			// 
			this.btn_SelectDateTime.Enabled = false;
			this.btn_SelectDateTime.Image = global::KodeKeeper.Properties.Resources.cal;
			this.btn_SelectDateTime.Location = new System.Drawing.Point(259, 276);
			this.btn_SelectDateTime.Name = "btn_SelectDateTime";
			this.btn_SelectDateTime.Size = new System.Drawing.Size(27, 22);
			this.btn_SelectDateTime.TabIndex = 6;
			this.btn_SelectDateTime.UseVisualStyleBackColor = true;
			// 
			// btn_StartUpdate
			// 
			this.btn_StartUpdate.Location = new System.Drawing.Point(16, 302);
			this.btn_StartUpdate.Name = "btn_StartUpdate";
			this.btn_StartUpdate.Size = new System.Drawing.Size(129, 23);
			this.btn_StartUpdate.TabIndex = 7;
			this.btn_StartUpdate.Text = "Start Update";
			this.btn_StartUpdate.UseVisualStyleBackColor = true;
			this.btn_StartUpdate.Click += new System.EventHandler(this.btn_StartUpdate_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(157, 302);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(129, 23);
			this.btn_Close.TabIndex = 8;
			this.btn_Close.Text = "Close";
			this.btn_Close.UseVisualStyleBackColor = true;
			// 
			// ss_Status
			// 
			this.ss_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Info,
            this.toolStripStatusLabel1,
            this.pb_Progress});
			this.ss_Status.Location = new System.Drawing.Point(0, 333);
			this.ss_Status.Name = "ss_Status";
			this.ss_Status.Size = new System.Drawing.Size(302, 22);
			this.ss_Status.TabIndex = 9;
			// 
			// lbl_Info
			// 
			this.lbl_Info.Name = "lbl_Info";
			this.lbl_Info.Size = new System.Drawing.Size(10, 17);
			this.lbl_Info.Text = "|";
			// 
			// rtb_Query
			// 
			this.rtb_Query.Location = new System.Drawing.Point(328, 19);
			this.rtb_Query.Name = "rtb_Query";
			this.rtb_Query.Size = new System.Drawing.Size(460, 277);
			this.rtb_Query.TabIndex = 10;
			this.rtb_Query.Text = "";
			// 
			// btn_CopyQuery
			// 
			this.btn_CopyQuery.Location = new System.Drawing.Point(676, 302);
			this.btn_CopyQuery.Name = "btn_CopyQuery";
			this.btn_CopyQuery.Size = new System.Drawing.Size(112, 23);
			this.btn_CopyQuery.TabIndex = 11;
			this.btn_CopyQuery.Text = "Copy to Clipboard";
			this.btn_CopyQuery.UseVisualStyleBackColor = true;
			// 
			// btn_SaveQuery
			// 
			this.btn_SaveQuery.Location = new System.Drawing.Point(558, 302);
			this.btn_SaveQuery.Name = "btn_SaveQuery";
			this.btn_SaveQuery.Size = new System.Drawing.Size(112, 23);
			this.btn_SaveQuery.TabIndex = 12;
			this.btn_SaveQuery.Text = "Save to File";
			this.btn_SaveQuery.UseVisualStyleBackColor = true;
			// 
			// btn_StartQuery
			// 
			this.btn_StartQuery.Location = new System.Drawing.Point(328, 302);
			this.btn_StartQuery.Name = "btn_StartQuery";
			this.btn_StartQuery.Size = new System.Drawing.Size(224, 23);
			this.btn_StartQuery.TabIndex = 13;
			this.btn_StartQuery.Text = "===  START UPDATE  ===";
			this.btn_StartQuery.UseVisualStyleBackColor = true;
			// 
			// pb_Progress
			// 
			this.pb_Progress.Name = "pb_Progress";
			this.pb_Progress.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.pb_Progress.Size = new System.Drawing.Size(100, 16);
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(674, 17);
			this.toolStripStatusLabel1.Spring = true;
			// 
			// dataUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 355);
			this.Controls.Add(this.btn_StartQuery);
			this.Controls.Add(this.btn_SaveQuery);
			this.Controls.Add(this.btn_CopyQuery);
			this.Controls.Add(this.rtb_Query);
			this.Controls.Add(this.ss_Status);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_StartUpdate);
			this.Controls.Add(this.btn_SelectDateTime);
			this.Controls.Add(this.mtb_DateTime);
			this.Controls.Add(this.cb_OverwriteUpdateDateTime);
			this.Controls.Add(this.cb_SkipImageData);
			this.Controls.Add(this.cb_SkipFileContants);
			this.Controls.Add(this.cb_ShowQuery);
			this.Controls.Add(this.groupBox1);
			this.Name = "dataUpdate";
			this.Text = "dataUpdate";
			this.groupBox1.ResumeLayout(false);
			this.ss_Status.ResumeLayout(false);
			this.ss_Status.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lv_UpdateNumbers;
		private System.Windows.Forms.ColumnHeader ch_ID;
		private System.Windows.Forms.ColumnHeader ch_Column;
		private System.Windows.Forms.ColumnHeader ch_Number;
		private System.Windows.Forms.CheckBox cb_ShowQuery;
		private System.Windows.Forms.CheckBox cb_SkipFileContants;
		private System.Windows.Forms.CheckBox cb_SkipImageData;
		private System.Windows.Forms.CheckBox cb_OverwriteUpdateDateTime;
		private System.Windows.Forms.MaskedTextBox mtb_DateTime;
		private System.Windows.Forms.Button btn_SelectDateTime;
		private System.Windows.Forms.Button btn_StartUpdate;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.StatusStrip ss_Status;
		private System.Windows.Forms.ToolStripStatusLabel lbl_Info;
		private System.Windows.Forms.RichTextBox rtb_Query;
		private System.Windows.Forms.Button btn_CopyQuery;
		private System.Windows.Forms.Button btn_SaveQuery;
		private System.Windows.Forms.Button btn_StartQuery;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar pb_Progress;
	}
}