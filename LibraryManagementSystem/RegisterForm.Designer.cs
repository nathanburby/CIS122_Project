namespace LibraryManagementSystem
{
	partial class RegisterForm
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
			this.register_showPassword = new System.Windows.Forms.CheckBox();
			this.register_loginBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.register_registerBtn = new System.Windows.Forms.Button();
			this.register_password = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.register_username = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.register_email = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// register_showPassword
			// 
			this.register_showPassword.AutoSize = true;
			this.register_showPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_showPassword.Location = new System.Drawing.Point(23, 395);
			this.register_showPassword.Name = "register_showPassword";
			this.register_showPassword.Size = new System.Drawing.Size(148, 25);
			this.register_showPassword.TabIndex = 19;
			this.register_showPassword.Text = "Show Password";
			this.register_showPassword.UseVisualStyleBackColor = true;
			this.register_showPassword.CheckedChanged += new System.EventHandler(this.register_showPassword_CheckedChanged);
			// 
			// register_loginBtn
			// 
			this.register_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.register_loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.register_loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
			this.register_loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
			this.register_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.register_loginBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_loginBtn.ForeColor = System.Drawing.Color.White;
			this.register_loginBtn.Location = new System.Drawing.Point(23, 560);
			this.register_loginBtn.Name = "register_loginBtn";
			this.register_loginBtn.Size = new System.Drawing.Size(295, 31);
			this.register_loginBtn.TabIndex = 18;
			this.register_loginBtn.Text = "LOGIN";
			this.register_loginBtn.UseVisualStyleBackColor = false;
			this.register_loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(79, 539);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(178, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "Already have an Account?";
			// 
			// register_registerBtn
			// 
			this.register_registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.register_registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.register_registerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
			this.register_registerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
			this.register_registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.register_registerBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_registerBtn.ForeColor = System.Drawing.Color.White;
			this.register_registerBtn.Location = new System.Drawing.Point(23, 426);
			this.register_registerBtn.Name = "register_registerBtn";
			this.register_registerBtn.Size = new System.Drawing.Size(295, 46);
			this.register_registerBtn.TabIndex = 17;
			this.register_registerBtn.Text = "REGISTER";
			this.register_registerBtn.UseVisualStyleBackColor = false;
			this.register_registerBtn.Click += new System.EventHandler(this.register_registerBtn_Click);
			// 
			// register_password
			// 
			this.register_password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_password.Location = new System.Drawing.Point(23, 367);
			this.register_password.Name = "register_password";
			this.register_password.PasswordChar = '*';
			this.register_password.Size = new System.Drawing.Size(295, 28);
			this.register_password.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 340);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 24);
			this.label4.TabIndex = 15;
			this.label4.Text = "Password:";
			// 
			// register_username
			// 
			this.register_username.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_username.Location = new System.Drawing.Point(23, 300);
			this.register_username.Name = "register_username";
			this.register_username.Size = new System.Drawing.Size(295, 28);
			this.register_username.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 273);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 24);
			this.label3.TabIndex = 11;
			this.label3.Text = "Username:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(99, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 27);
			this.label2.TabIndex = 13;
			this.label2.Text = "Registration Form";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.LibraryLogo2;
			this.pictureBox1.Location = new System.Drawing.Point(117, 41);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 114);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(339, 35);
			this.panel2.TabIndex = 9;
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(19, 221);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(142, 24);
			this.label6.TabIndex = 11;
			this.label6.Text = "Email Address:";
			// 
			// register_email
			// 
			this.register_email.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_email.Location = new System.Drawing.Point(23, 248);
			this.register_email.Name = "register_email";
			this.register_email.Size = new System.Drawing.Size(295, 28);
			this.register_email.TabIndex = 14;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(23, 300);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(295, 29);
			this.textBox1.TabIndex = 14;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(23, 248);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(295, 29);
			this.textBox2.TabIndex = 14;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(23, 367);
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = '*';
			this.textBox3.Size = new System.Drawing.Size(295, 29);
			this.textBox3.TabIndex = 16;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(339, 603);
			this.Controls.Add(this.register_showPassword);
			this.Controls.Add(this.register_loginBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.register_registerBtn);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.register_password);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.register_email);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.register_username);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegisterForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox register_showPassword;
		private System.Windows.Forms.Button register_loginBtn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button register_registerBtn;
		private System.Windows.Forms.TextBox register_password;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox register_username;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox register_email;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
	}
}