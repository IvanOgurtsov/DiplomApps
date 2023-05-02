using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DiplomApps
{
	public partial class ParticipantsCreateForm : Form
	{
		private readonly DataTable _table = new();

		int selectedRow;

		private const string _connectionString = @"Data Source=C:\Users\Ivan\source\repos\DiplomApps\DiplomApps\DiplomDB.db";


		public ParticipantsCreateForm()
		{
			InitializeComponent(); 
			LoadData();
		}

		private void LoadData()
		{
			const string select = "SELECT * FROM Users";

			using SQLiteConnection connection = new(_connectionString);
			connection.Open();

			SQLiteCommand command = new(select, connection);
			SQLiteDataReader reader = command.ExecuteReader();

			_table.Load(reader);

			_participantsGrid.DataSource = _table;
			_participantsGrid.Refresh();
		}

		private void UpdateData()
		{
			LoadData();
		}

		private void buttonAddPart_Click(object sender, EventArgs e)
		{
			try
			{
				string insert =
					$"INSERT INTO Users(Name, Telephone, Company, Password) " +
					$"VALUES ('{textBoxName.Text}', '{textBoxTelephone.Text}', '{textBoxCompany.Text}', '{textBoxPass.Text}')";

				using SQLiteConnection connection = new(_connectionString);
				connection.Open();

				SQLiteCommand command = new(insert, connection);
				command.ExecuteNonQuery();

				UpdateData();

				textBoxName.Text = "";
				textBoxTelephone.Text = "";
				textBoxCompany.Text = "";
				textBoxPass.Text = "";
			}
			catch
			{
				MessageBox.Show("Данный пароль используется!");
				textBoxPass.Text = "";
			}
		}

		private void buttonDelPart_Click(object sender, EventArgs e)
		{
			try
			{
				string delete =
					$"DELETE FROM Users " +
					$"WHERE ID = {Convert.ToInt32(_participantsGrid.SelectedRows[0].Cells[0].Value)}";

				using SQLiteConnection connection = new(_connectionString);
				connection.Open();

				SQLiteCommand command = new(delete, connection);
				command.ExecuteNonQuery();

				_participantsGrid.Rows.Remove(_participantsGrid.SelectedRows[0]);
				UpdateData();
			}
			catch 
			{
				MessageBox.Show("Выберите запись!");
			}
		}

		private void _participantsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedRow = e.RowIndex;

			if(e.RowIndex >= 0)
			{
				DataGridViewRow row = _participantsGrid.Rows[selectedRow];

				textBoxName.Text = row.Cells[1].Value.ToString();
				textBoxTelephone.Text = row.Cells[2].Value.ToString();
				textBoxCompany.Text = row.Cells[3].Value.ToString();
				textBoxPass.Text = row.Cells[4].Value.ToString();
			}
		}

		private void buttonUpdatePart_Click(object sender, EventArgs e)
		{
			var id = Convert.ToInt32(_participantsGrid.SelectedRows[0].Cells[0].Value);
			var name = textBoxName.Text;
			int telephone;
			var company = textBoxCompany.Text;
			var pass = textBoxPass.Text;

			if(int.TryParse(textBoxTelephone.Text, out telephone))
			{
				try
				{
					string change = $"update Users set Name = '{name}', Telephone = '{telephone}', Company = '{company}', Password = '{pass}' " +
						$"where ID = '{id}'";

					using SQLiteConnection connection = new(_connectionString);
					connection.Open();

					SQLiteCommand command = new(change, connection);
					command.ExecuteNonQuery();
				}
				catch
				{
					MessageBox.Show("Неправильный формат записи");
				}
			}
			else
			{
				MessageBox.Show("Проверьте водимый номер телефона");
			}


			UpdateData();

		}
	}
}
