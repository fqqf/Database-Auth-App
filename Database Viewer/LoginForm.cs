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
		public LoginForm()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			String login = loginBox.Text;
			String password = passBox.Text;

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
	}
}
