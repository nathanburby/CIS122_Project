﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
	public partial class LoginForm : Form
	{
		SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nqbur\OneDrive\Documents\LibraryManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
		public LoginForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void signupBtn_Click(object sender, EventArgs e)
		{
			RegisterForm rForm = new RegisterForm();
			rForm.Show();
			this.Hide();
		}

		private void login_showPassword_CheckedChanged(object sender, EventArgs e)
		{
			login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';
		}

		private void login_loginBtn_Click(object sender, EventArgs e)
		{
			if (login_username.Text == "" || login_password.Text == "")
			{
				MessageBox.Show("Please fill in all blank fields", "Error Message",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (connect.State != ConnectionState.Open)
				{
					try
					{
						connect.Open();

						String selectData = "SELECT * FROM users WHERE username = @username AND password = @password";
						using (SqlCommand cmd = new SqlCommand(selectData, connect))
						{
							cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
							cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

							SqlDataAdapter adapter = new SqlDataAdapter(cmd);
							DataTable table = new DataTable();
							adapter.Fill(table);

							if (table.Rows.Count >= 1)
							{
								MessageBox.Show("Login Succesful", "Information Message",
									MessageBoxButtons.OK, MessageBoxIcon.Information);

								MainForm mForm = new MainForm();
								mForm.Show();
								this.Hide();
							}
							else
							{
								MessageBox.Show("Incorrect Username or Password", "Error Message", 
									MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error connecting Database" + ex, "Error Message",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						connect.Close();
					}

				}
			}
		}
	}
}
