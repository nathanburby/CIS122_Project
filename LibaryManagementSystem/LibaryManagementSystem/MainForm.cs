﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			dashboard2.Visible = true;
			addBooks1.Visible = false;
			returnBooks1.Visible = false;
			issueBooks2.Visible = false;
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void logout_btn_Click(object sender, EventArgs e)
		{
			DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (check == DialogResult.Yes)
			{
				LoginForm lForm = new LoginForm();
				lForm.Show();
				this.Hide();
			}

		}

		private void dashboard_btn_Click(object sender, EventArgs e)
		{
			dashboard2.Visible = true;
			addBooks1.Visible = false;
			returnBooks1.Visible = false;
			issueBooks2.Visible = false;

		}

		private void addBooks_btn_Click(object sender, EventArgs e)
		{
			dashboard2.Visible = false;
			addBooks1.Visible = true;
			returnBooks1.Visible = false;
			issueBooks2.Visible = false;
		}

		private void issueBooks_btn_Click(object sender, EventArgs e)
		{
			dashboard2.Visible = false;
			addBooks1.Visible = false;
			returnBooks1.Visible = false;
			issueBooks2.Visible = true;
		}

		private void returnBooks_btn_Click(object sender, EventArgs e)
		{
			dashboard2.Visible = false;
			addBooks1.Visible = false;
			returnBooks1.Visible = true;
			issueBooks2.Visible = false;
		}
	}
}