namespace LibraryManagementSystem
{
	partial class LoginForm
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.login_username = new System.Windows.Forms.TextBox();
			this.login_password = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.login_loginBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.login_signupBtn = new System.Windows.Forms.Button();
			this.login_showPassword = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(339, 35);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(310, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "X";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(103, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 27);
			this.label2.TabIndex = 2;
			this.label2.Text = "Welcome, user!";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 253);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "Username:";
			// 
			// login_username
			// 
			this.login_username.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_username.Location = new System.Drawing.Point(23, 280);
			this.login_username.Name = "login_username";
			this.login_username.Size = new System.Drawing.Size(295, 29);
			this.login_username.TabIndex = 3;
			// 
			// login_password
			// 
			this.login_password.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_password.Location = new System.Drawing.Point(23, 347);
			this.login_password.Name = "login_password";
			this.login_password.PasswordChar = '*';
			this.login_password.Size = new System.Drawing.Size(295, 29);
			this.login_password.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 320);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 24);
			this.label4.TabIndex = 4;
			this.label4.Text = "Password:";
			// 
			// login_loginBtn
			// 
			this.login_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.login_loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.login_loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
			this.login_loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
			this.login_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.login_loginBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_loginBtn.ForeColor = System.Drawing.Color.White;
			this.login_loginBtn.Location = new System.Drawing.Point(23, 406);
			this.login_loginBtn.Name = "login_loginBtn";
			this.login_loginBtn.Size = new System.Drawing.Size(295, 46);
			this.login_loginBtn.TabIndex = 6;
			this.login_loginBtn.Text = "LOGIN";
			this.login_loginBtn.UseVisualStyleBackColor = false;
			this.login_loginBtn.Click += new System.EventHandler(this.login_loginBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(115, 499);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 18);
			this.label5.TabIndex = 1;
			this.label5.Text = "Register Account";
			// 
			// login_signupBtn
			// 
			this.login_signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.login_signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.login_signupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
			this.login_signupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
			this.login_signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.login_signupBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_signupBtn.ForeColor = System.Drawing.Color.White;
			this.login_signupBtn.Location = new System.Drawing.Point(23, 528);
			this.login_signupBtn.Name = "login_signupBtn";
			this.login_signupBtn.Size = new System.Drawing.Size(295, 31);
			this.login_signupBtn.TabIndex = 7;
			this.login_signupBtn.Text = "SIGNUP";
			this.login_signupBtn.UseVisualStyleBackColor = false;
			this.login_signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
			// 
			// login_showPassword
			// 
			this.login_showPassword.AutoSize = true;
			this.login_showPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_showPassword.Location = new System.Drawing.Point(23, 382);
			this.login_showPassword.Name = "login_showPassword";
			this.login_showPassword.Size = new System.Drawing.Size(148, 25);
			this.login_showPassword.TabIndex = 8;
			this.login_showPassword.Text = "Show Password";
			this.login_showPassword.UseVisualStyleBackColor = true;
			this.login_showPassword.CheckedChanged += new System.EventHandler(this.login_showPassword_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LibaryManagementSystem.Properties.Resources.LibraryLogo2;
			this.pictureBox1.Location = new System.Drawing.Point(121, 83);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 114);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(339, 603);
			this.Controls.Add(this.login_showPassword);
			this.Controls.Add(this.login_signupBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.login_loginBtn);
			this.Controls.Add(this.login_password);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.login_username);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox login_username;
		private System.Windows.Forms.TextBox login_password;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button login_loginBtn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button login_signupBtn;
		private System.Windows.Forms.CheckBox login_showPassword;
	}
}