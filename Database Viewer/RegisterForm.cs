using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Database_Viewer
{
	public partial class RegisterForm : Form
	{
		LoginForm loginForm = new LoginForm();

		public RegisterForm()
		{
			InitializeComponent();

			nameField.Text = "Your name";
			nameField.ForeColor = Color.Gray;

			surnameField.Text = "Your surname";
			surnameField.ForeColor = Color.Gray;

			loginField.Text = "Your login";
			loginField.ForeColor = Color.Gray;

			passwordField.Text = "Your password";
			passwordField.ForeColor = Color.Gray;

			loginForm.registerForm = this;
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		Point lastPoint = new Point();
		private void panel2_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint.X = e.X; lastPoint.Y = e.Y;
		}

		private void nameField_Enter(object sender, EventArgs e)
		{
			if (nameField.Text == "Your name")
			{
				nameField.Text = "";
				nameField.ForeColor = Color.Black;
			}
		}

		private void nameField_Leave(object sender, EventArgs e)
		{
			if (nameField.Text == "")
			{
				nameField.Text = "Your name";
				nameField.ForeColor = Color.Gray;
			}
		}

		private void surnameField_Enter(object sender, EventArgs e)
		{
			if (surnameField.Text == "Your surname")
			{
				surnameField.Text = "";
				surnameField.ForeColor = Color.Black;
			}
		}

		private void surnameField_Leave(object sender, EventArgs e)
		{
			if (surnameField.Text == "")
			{
				surnameField.Text = "Your surname";
				surnameField.ForeColor = Color.Gray;
			}
		}

		private void loginField_Enter(object sender, EventArgs e)
		{
			if (loginField.Text == "Your login")
			{
				loginField.Text = "";
				loginField.ForeColor = Color.Black;
			}
		}

		private void loginField_Leave(object sender, EventArgs e)
		{
			if (loginField.Text == "")
			{
				loginField.Text = "Your login";
				loginField.ForeColor = Color.Gray;
			}
		}

		private void passwordField_Enter(object sender, EventArgs e)
		{
			if (passwordField.Text == "Your password")
			{
				passwordField.Text = "";
				passwordField.ForeColor = Color.Black;
			}
		}

		private void passwordField_Leave(object sender, EventArgs e)
		{
			if (passwordField.Text == "")
			{
				passwordField.Text = "Your password";
				passwordField.ForeColor = Color.Gray;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (userExists()) { MessageBox.Show("This user already exists!"); return; }

			Database database = new Database();

			MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`id`, `login`, `password`, `name`, `surname`) VALUES(NULL, @login, @password, @name, @surname)", database.getConnection());
			command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
			command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordField.Text;
			command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
			command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameField.Text;

			database.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				MessageBox.Show("Account was created");
			}
			else
			{
				MessageBox.Show("Account was not created");
			}

			database.closeConnection();
		}

		private Boolean userExists()
		{
			String login = loginField.Text;

			Database database = new Database();

			DataTable table = new DataTable();

			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login=@uL;", database.getConnection());
			command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return (table.Rows.Count == 1) ? true : false;
		}


		private void label1_Click(object sender, EventArgs e)
		{
			this.Hide();
			loginForm.Show();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
