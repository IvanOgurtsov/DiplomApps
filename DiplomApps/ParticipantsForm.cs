using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomApps
{
	public partial class ParticipantsForm : Form
	{
		private readonly DataTable _table = new();

		private const string _connectionString = @"Data Source=C:\Users\Ivan\source\repos\DiplomApps\DiplomApps\DiplomDB.db";

		public ParticipantsForm()
		{
			InitializeComponent();
			LoadData();
		}

		private void LoadData()
		{
			const string select = "SELECT * FROM Tenders where Status = 'Активный'";

			using SQLiteConnection connection = new(_connectionString);
			connection.Open();

			SQLiteCommand command = new(select, connection);
			SQLiteDataReader reader = command.ExecuteReader();

			_table.Load(reader);

			_gridTender.DataSource = _table;
			_gridTender.Refresh();
		}

		private void UpdateData()
		{
			LoadData();
		}


		private void buttonUpdatePrice_Click(object sender, EventArgs e)
		{
			
			try
			{
				var id = Convert.ToInt32(_gridTender.SelectedRows[0].Cells[0].Value);
				int Price;

				if (int.TryParse(textBox_Price.Text, out Price))
				{
					var idChange = Convert.ToInt32(_gridTender.SelectedRows[0].Cells[0].Value);

					int thisPrice = 0;

					string getID = $"select Price from Tenders where ID = '{idChange}'";

					using SQLiteConnection connection1 = new(_connectionString);
					connection1.Open();

					SQLiteCommand sQLiteCommand = new(getID, connection1);

					SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
					while (sQLiteDataReader.Read())
					{
						thisPrice = sQLiteDataReader.GetInt32(0);
					}

					if(Price > thisPrice)
					{
						MessageBox.Show("Предложенная цена не может быть выше текущей!", "Внимание!");
					}

					else
					{
						try
						{

							string change = $"update Tenders set Price = '{Price}', ParticipantID = '{DataBank.ID}' where ID = '{id}'";

							using SQLiteConnection connection = new(_connectionString);
							connection.Open();

							SQLiteCommand command = new(change, connection);
							command.ExecuteNonQuery();

							MessageBox.Show("Изменение прошло успешно!");

							textBox_Price.Text = "";

						}
						catch
						{
							MessageBox.Show("Неправильный формат записи!");
						}
					}
				}
				else
				{
					MessageBox.Show("Проверьте водимую цену!");
				}
			}
			catch
			{
				MessageBox.Show("Выберите запись!!!");
			}

			UpdateData();
		}
	}
}
