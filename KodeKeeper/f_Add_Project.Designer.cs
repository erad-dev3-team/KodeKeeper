namespace KodeKeeper
{
	partial class f_Add_Project
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
			this.label1 = new System.Windows.Forms.Label();
			this.tb_ProjectName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_ProjectComment = new System.Windows.Forms.TextBox();
			this.btn_SaveProject = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_ShowProjectFiles = new System.Windows.Forms.Button();
			this.lbl_InsertUser = new System.Windows.Forms.Label();
			this.lbl_ProjModified = new System.Windows.Forms.Label();
			this.lbl_ProjAdded = new System.Windows.Forms.Label();
			this.lbl_NumOfFiles = new System.Windows.Forms.Label();
			this.lbl_ProjectUId = new System.Windows.Forms.Label();
			this.lbl_ProjectId = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_DeleteProject = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Project Name: ";
			// 
			// tb_ProjectName
			// 
			this.tb_ProjectName.Location = new System.Drawing.Point(95, 6);
			this.tb_ProjectName.Name = "tb_ProjectName";
			this.tb_ProjectName.Size = new System.Drawing.Size(230, 20);
			this.tb_ProjectName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Comment: ";
			// 
			// tb_ProjectComment
			// 
			this.tb_ProjectComment.Location = new System.Drawing.Point(95, 34);
			this.tb_ProjectComment.Multiline = true;
			this.tb_ProjectComment.Name = "tb_ProjectComment";
			this.tb_ProjectComment.Size = new System.Drawing.Size(230, 139);
			this.tb_ProjectComment.TabIndex = 3;
			// 
			// btn_SaveProject
			// 
			this.btn_SaveProject.Location = new System.Drawing.Point(15, 193);
			this.btn_SaveProject.Name = "btn_SaveProject";
			this.btn_SaveProject.Size = new System.Drawing.Size(75, 23);
			this.btn_SaveProject.TabIndex = 4;
			this.btn_SaveProject.Text = "Save";
			this.btn_SaveProject.UseVisualStyleBackColor = true;
			this.btn_SaveProject.Click += new System.EventHandler(this.btn_SaveProject_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(250, 193);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 5;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_ShowProjectFiles);
			this.groupBox1.Controls.Add(this.lbl_InsertUser);
			this.groupBox1.Controls.Add(this.lbl_ProjModified);
			this.groupBox1.Controls.Add(this.lbl_ProjAdded);
			this.groupBox1.Controls.Add(this.lbl_NumOfFiles);
			this.groupBox1.Controls.Add(this.lbl_ProjectUId);
			this.groupBox1.Controls.Add(this.lbl_ProjectId);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(343, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(291, 167);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Project Data";
			// 
			// btn_ShowProjectFiles
			// 
			this.btn_ShowProjectFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_ShowProjectFiles.Location = new System.Drawing.Point(3, 141);
			this.btn_ShowProjectFiles.Name = "btn_ShowProjectFiles";
			this.btn_ShowProjectFiles.Size = new System.Drawing.Size(285, 23);
			this.btn_ShowProjectFiles.TabIndex = 12;
			this.btn_ShowProjectFiles.Text = "Show files in this project";
			this.btn_ShowProjectFiles.UseVisualStyleBackColor = true;
			// 
			// lbl_InsertUser
			// 
			this.lbl_InsertUser.AutoSize = true;
			this.lbl_InsertUser.Location = new System.Drawing.Point(85, 123);
			this.lbl_InsertUser.Name = "lbl_InsertUser";
			this.lbl_InsertUser.Size = new System.Drawing.Size(9, 13);
			this.lbl_InsertUser.TabIndex = 11;
			this.lbl_InsertUser.Text = "|";
			// 
			// lbl_ProjModified
			// 
			this.lbl_ProjModified.AutoSize = true;
			this.lbl_ProjModified.Location = new System.Drawing.Point(85, 104);
			this.lbl_ProjModified.Name = "lbl_ProjModified";
			this.lbl_ProjModified.Size = new System.Drawing.Size(9, 13);
			this.lbl_ProjModified.TabIndex = 10;
			this.lbl_ProjModified.Text = "|";
			// 
			// lbl_ProjAdded
			// 
			this.lbl_ProjAdded.AutoSize = true;
			this.lbl_ProjAdded.Location = new System.Drawing.Point(85, 85);
			this.lbl_ProjAdded.Name = "lbl_ProjAdded";
			this.lbl_ProjAdded.Size = new System.Drawing.Size(9, 13);
			this.lbl_ProjAdded.TabIndex = 9;
			this.lbl_ProjAdded.Text = "|";
			// 
			// lbl_NumOfFiles
			// 
			this.lbl_NumOfFiles.AutoSize = true;
			this.lbl_NumOfFiles.Location = new System.Drawing.Point(85, 66);
			this.lbl_NumOfFiles.Name = "lbl_NumOfFiles";
			this.lbl_NumOfFiles.Size = new System.Drawing.Size(9, 13);
			this.lbl_NumOfFiles.TabIndex = 8;
			this.lbl_NumOfFiles.Text = "|";
			// 
			// lbl_ProjectUId
			// 
			this.lbl_ProjectUId.AutoSize = true;
			this.lbl_ProjectUId.Location = new System.Drawing.Point(85, 47);
			this.lbl_ProjectUId.Name = "lbl_ProjectUId";
			this.lbl_ProjectUId.Size = new System.Drawing.Size(9, 13);
			this.lbl_ProjectUId.TabIndex = 7;
			this.lbl_ProjectUId.Text = "|";
			// 
			// lbl_ProjectId
			// 
			this.lbl_ProjectId.AutoSize = true;
			this.lbl_ProjectId.Location = new System.Drawing.Point(85, 28);
			this.lbl_ProjectId.Name = "lbl_ProjectId";
			this.lbl_ProjectId.Size = new System.Drawing.Size(9, 13);
			this.lbl_ProjectId.TabIndex = 6;
			this.lbl_ProjectId.Text = "|";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 123);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Insert User: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Proj. Modified: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Proj. Added: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "# of files: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "UID: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "ID: ";
			// 
			// btn_DeleteProject
			// 
			this.btn_DeleteProject.Location = new System.Drawing.Point(470, 193);
			this.btn_DeleteProject.Name = "btn_DeleteProject";
			this.btn_DeleteProject.Size = new System.Drawing.Size(164, 23);
			this.btn_DeleteProject.TabIndex = 7;
			this.btn_DeleteProject.Text = "Delete Project";
			this.btn_DeleteProject.UseVisualStyleBackColor = true;
			this.btn_DeleteProject.Click += new System.EventHandler(this.btn_DeleteProject_Click);
			// 
			// f_Add_Project
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 228);
			this.Controls.Add(this.btn_DeleteProject);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_SaveProject);
			this.Controls.Add(this.tb_ProjectComment);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_ProjectName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "f_Add_Project";
			this.Text = "Add Project";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_ProjectName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_ProjectComment;
		private System.Windows.Forms.Button btn_SaveProject;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_ShowProjectFiles;
		private System.Windows.Forms.Label lbl_InsertUser;
		private System.Windows.Forms.Label lbl_ProjModified;
		private System.Windows.Forms.Label lbl_ProjAdded;
		private System.Windows.Forms.Label lbl_NumOfFiles;
		private System.Windows.Forms.Label lbl_ProjectUId;
		private System.Windows.Forms.Label lbl_ProjectId;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn_DeleteProject;
	}
}