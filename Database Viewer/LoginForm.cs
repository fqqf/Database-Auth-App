using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Viewer
{
	public partial class LoginForm : Form
	{
		public RegisterForm registerForm;

		public LoginForm()
		{
			InitializeComponent();

			loginField.Text = "Your login";
			loginField.ForeColor = Color.Gray;

			passwordField.Text = "Your password";
			passwordField.ForeColor = Color.Gray;
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			String login = loginField.Text;
			String password = passwordField.Text;

			Database database = new Database();

			DataTable table = new DataTable();

			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login=@uL AND password=@uP;", database.getConnection());
			command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
			command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (table.Rows.Count == 1) MessageBox.Show("Auth successfully"); else MessageBox.Show("Auth failed");
		}

		private void loginBox_Enter(object sender, EventArgs e)
		{
			if (loginField.Text == "Your login")
			{
				loginField.Text = "";
				loginField.ForeColor = Color.Black;
			}
		}

		private void loginBox_Leave(object sender, EventArgs e)
		{
			if (loginField.Text == "")
			{
				loginField.Text = "Your login";
				loginField.ForeColor = Color.Gray;
			}
		}

		private void passBox_Enter(object sender, EventArgs e)
		{
			if (passwordField.Text == "Your password")
			{
				passwordField.Text = "";
				passwordField.ForeColor = Color.Black;
			}
		}

		private void passBox_Leave(object sender, EventArgs e)
		{
			if (passwordField.Text == "")
			{
				passwordField.Text = "Your password";
				passwordField.ForeColor = Color.Gray;
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{
			this.Hide();
			registerForm.Show();
		}

		Point lastPoint = new Point();

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint.X = e.X; lastPoint.Y = e.Y;
		}
	}
}
