using MySqlConnector;

namespace Database_Viewer
{
	internal class Database
	{
		internal MySqlConnection connection = new MySqlConnection
("server=127.0.0.1;uid=root;pwd=root;database=db");

		public void openConnection()
		{
			if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
		}

		public void closeConnection()
		{
			if (connection.State == System.Data.ConnectionState.Open) connection.Close();
		}

		public MySqlConnection getConnection()
		{
			return connection;
		}
	}
}
