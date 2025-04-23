namespace LibraryManagementSystem
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
			this.panel4 = new System.Windows.Forms.Panel();
			this.exit_btn = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dashboard_btn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.ReturnBtn = new System.Windows.Forms.Button();
			this.IssueBtn = new System.Windows.Forms.Button();
			this.logOutImg = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dashboard2 = new LibraryManagementSystem.Dashboard();
			this.issueBooks2 = new LibraryManagementSystem.IssueBooks();
			this.returnBooks2 = new LibraryManagementSystem.ReturnBooks();
			this.addBooks2 = new LibraryManagementSystem.AddBooks();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logOutImg)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.exit_btn);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1100, 35);
			this.panel4.TabIndex = 0;
			// 
			// exit_btn
			// 
			this.exit_btn.AutoSize = true;
			this.exit_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit_btn.ForeColor = System.Drawing.Color.White;
			this.exit_btn.Location = new System.Drawing.Point(1069, 9);
			this.exit_btn.Name = "exit_btn";
			this.exit_btn.Size = new System.Drawing.Size(19, 22);
			this.exit_btn.TabIndex = 0;
			this.exit_btn.Text = "X";
			this.exit_btn.Click += new System.EventHandler(this.label1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(3, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(377, 24);
			this.label5.TabIndex = 1;
			this.label5.Text = "Library Management System | Main Form";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.label7);
			this.panel5.Controls.Add(this.logOutImg);
			this.panel5.Controls.Add(this.ReturnBtn);
			this.panel5.Controls.Add(this.IssueBtn);
			this.panel5.Controls.Add(this.AddBtn);
			this.panel5.Controls.Add(this.dashboard_btn);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Controls.Add(this.pictureBox2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new System.Drawing.Point(0, 35);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(220, 565);
			this.panel5.TabIndex = 1;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.LibraryLogo2;
			this.pictureBox2.Location = new System.Drawing.Point(55, 18);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 100);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(24, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 24);
			this.label6.TabIndex = 1;
			this.label6.Text = "Welcome, Admin";
			// 
			// dashboard_btn
			// 
			this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
			this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
			this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dashboard_btn.ForeColor = System.Drawing.Color.White;
			this.dashboard_btn.Location = new System.Drawing.Point(11, 178);
			this.dashboard_btn.Name = "dashboard_btn";
			this.dashboard_btn.Size = new System.Drawing.Size(200, 45);
			this.dashboard_btn.TabIndex = 2;
			this.dashboard_btn.Text = "DASHBOARD";
			this.dashboard_btn.UseVisualStyleBackColor = false;
			this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
			this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
			this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddBtn.ForeColor = System.Drawing.Color.White;
			this.AddBtn.Location = new System.Drawing.Point(11, 245);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(200, 45);
			this.AddBtn.TabIndex = 3;
			this.AddBtn.Text = "ADD BOOKS";
			this.AddBtn.UseVisualStyleBackColor = false;
			this.AddBtn.Click += new System.EventHandler(this.addBooks_btn_Click);
			// 
			// ReturnBtn
			// 
			this.ReturnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.ReturnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
			this.ReturnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
			this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ReturnBtn.ForeColor = System.Drawing.Color.White;
			this.ReturnBtn.Location = new System.Drawing.Point(11, 381);
			this.ReturnBtn.Name = "ReturnBtn";
			this.ReturnBtn.Size = new System.Drawing.Size(200, 45);
			this.ReturnBtn.TabIndex = 5;
			this.ReturnBtn.Text = "RETURN BOOKS";
			this.ReturnBtn.UseVisualStyleBackColor = false;
			this.ReturnBtn.Click += new System.EventHandler(this.returnBooks_btn_Click);
			// 
			// IssueBtn
			// 
			this.IssueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.IssueBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
			this.IssueBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
			this.IssueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IssueBtn.ForeColor = System.Drawing.Color.White;
			this.IssueBtn.Location = new System.Drawing.Point(11, 314);
			this.IssueBtn.Name = "IssueBtn";
			this.IssueBtn.Size = new System.Drawing.Size(200, 45);
			this.IssueBtn.TabIndex = 4;
			this.IssueBtn.Text = "ISSUE BOOKS";
			this.IssueBtn.UseVisualStyleBackColor = false;
			this.IssueBtn.Click += new System.EventHandler(this.issueBooks_btn_Click);
			// 
			// logOutImg
			// 
			this.logOutImg.Image = global::LibraryManagementSystem.Properties.Resources.logOut3;
			this.logOutImg.Location = new System.Drawing.Point(11, 507);
			this.logOutImg.Name = "logOutImg";
			this.logOutImg.Size = new System.Drawing.Size(45, 45);
			this.logOutImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logOutImg.TabIndex = 6;
			this.logOutImg.TabStop = false;
			this.logOutImg.Click += new System.EventHandler(this.logout_btn_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(63, 535);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 21);
			this.label7.TabIndex = 7;
			this.label7.Text = "Log out";
			// 
			// dashboard2
			// 
			this.dashboard2.Location = new System.Drawing.Point(218, 35);
			this.dashboard2.Name = "dashboard2";
			this.dashboard2.Size = new System.Drawing.Size(880, 565);
			this.dashboard2.TabIndex = 5;
			// 
			// issueBooks2
			// 
			this.issueBooks2.Location = new System.Drawing.Point(218, 35);
			this.issueBooks2.Name = "issueBooks2";
			this.issueBooks2.Size = new System.Drawing.Size(880, 565);
			this.issueBooks2.TabIndex = 3;
			// 
			// returnBooks2
			// 
			this.returnBooks2.Location = new System.Drawing.Point(218, 35);
			this.returnBooks2.Name = "returnBooks2";
			this.returnBooks2.Size = new System.Drawing.Size(880, 565);
			this.returnBooks2.TabIndex = 4;
			// 
			// addBooks2
			// 
			this.addBooks2.Location = new System.Drawing.Point(220, 35);
			this.addBooks2.Name = "addBooks2";
			this.addBooks2.Size = new System.Drawing.Size(880, 565);
			this.addBooks2.TabIndex = 6;
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(1100, 600);
			this.Controls.Add(this.addBooks2);
			this.Controls.Add(this.dashboard2);
			this.Controls.Add(this.returnBooks2);
			this.Controls.Add(this.issueBooks2);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logOutImg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button addBooksBtn;
		private System.Windows.Forms.Button dashboardBtn;
		private System.Windows.Forms.Label greet_label;
		private System.Windows.Forms.Button returnBooksBtn;
		private System.Windows.Forms.Button issueBooksBtn;
		private System.Windows.Forms.PictureBox logOutPic;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private AddBooks addBooks1;
		private IssueBooks issueBooks1;
		private ReturnBooks returnBooks1;
		private Dashboard dashboard1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label exit_btn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button dashboard_btn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox logOutImg;
		private System.Windows.Forms.Button ReturnBtn;
		private System.Windows.Forms.Button IssueBtn;
		private System.Windows.Forms.Button AddBtn;
		private IssueBooks issueBooks2;
		private Dashboard dashboard2;
		private ReturnBooks returnBooks2;
		private AddBooks addBooks2;
	}
}