using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DiplomApps
{
	public partial class AuthForm : Form
	{


		private const string _connectionString = @"Data Source=C:\Users\Ivan\source\repos\DiplomApps\DiplomApps\DiplomDB.db";

		public AuthForm()
		{
			InitializeComponent();

			textBoxPass.MaxLength = 10;
			textBoxPass.PasswordChar = '*';
		}

		private void buttonAuth_Click(object sender, EventArgs e)
		{
			if (textBoxLogin.Text == "Admin" && textBoxPass.Text == "Admin")
			{
				CreateTendefForm createTendef = new();

				MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

				Hide();

				createTendef.ShowDialog();

				Show();

			}
			else
			{
				var loginUser = textBoxLogin.Text;
				var passUser = textBoxPass.Text;

				SQLiteDataAdapter adapter = new();
				DataTable table = new();

				string queryString = $"select Name, Password from Users where Name = '{loginUser}' and Password = '{passUser}'";

				using SQLiteConnection connection = new(_connectionString);
				connection.Open();

				SQLiteCommand command = new(queryString, connection);

				adapter.SelectCommand = command;
				adapter.Fill(table);

				if(table.Rows.Count == 1)
				{
					int id = 0;
					string getID = $"select ID from Users where Name = '{loginUser}' and Password = '{passUser}'";

					SQLiteCommand sQLiteCommand = new(getID, connection);

					SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
					while(sQLiteDataReader.Read())
					{
						id = sQLiteDataReader.GetInt32(0);
					}

					DataBank.ID = id;

                    MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ParticipantsForm participantsForm = new();
					
					Hide();

					participantsForm.ShowDialog();

					Show();
				}
				else
				{
					MessageBox.Show("Такого аккаунта не существует","Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
	}
}
