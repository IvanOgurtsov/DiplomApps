using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;

namespace DiplomApps
{
	public partial class CreateTendefForm : Form
	{

		private readonly DataTable _table = new();


		private const string _connectionString = @"Data Source=C:\Users\Ivan\source\repos\DiplomApps\DiplomApps\DiplomDB.db";

		HubConnection connection;

		public CreateTendefForm()
		{
			InitializeComponent();

			

			connection = new HubConnectionBuilder().WithUrl().Build();

			LoadData();
		}

		private void LoadData()
		{
			const string select = "SELECT * FROM Tenders";

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


		private async void buttonAddTender_Click(object sender, EventArgs e)
		{
			TextBox[] textBoxes = { textBoxStartAdress, textBoxEndAdress, textBoxDateStart, textBoxFinishStart, textBoxProduct, textBoxQuantity };

			foreach (TextBox textbox in textBoxes)
			{
				if(string.IsNullOrEmpty(textbox.Text))
				{
					MessageBox.Show("Заполните всю информацию!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			//try
			
				string insert =
					$"INSERT INTO Tenders(StartCity, FinishCity, DateStart, DateFinish, Product, Quantity, ParticipantID, Price, Status) " +
					$"VALUES ('{textBoxStartAdress.Text}', '{textBoxEndAdress.Text}', '{textBoxDateStart.Text}', '{textBoxFinishStart.Text}', '{textBoxProduct.Text}', '{textBoxQuantity.Text}', '0', '50000', 'Активный')";

				using SQLiteConnection connection = new(_connectionString);
				connection.Open();

				SQLiteCommand command = new(insert, connection);
				command.ExecuteNonQuery();

				MessageBox.Show("Вы успешно внесли запись!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

				Tender tender = new()
				{
					StartCity = textBoxStartAdress.Text,
					FinishCity = textBoxEndAdress.Text,
					DateStart = textBoxDateStart.Text,
					DateFinish = textBoxFinishStart.Text,
					Product = textBoxProduct.Text,
					Quantity = textBoxQuantity.Text,
					ParticipantID = 0,
					Price = 50000,
					Status = "Активный"
				};

				await _hubConnection.Start();
				await _hubProxy.Invoke("UpdateTender", tender);

				UpdateData();

				textBoxStartAdress.Text = "";
				textBoxEndAdress.Text = "";
				textBoxDateStart.Text = "";
				textBoxFinishStart.Text = "";
				textBoxProduct.Text = "";
				textBoxQuantity.Text = "";

			
			//catch
			//{
			//	MessageBox.Show("Проверьте водимые данные!");
			//}
		}

		int selectedRow;


		private void _participantsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedRow = e.RowIndex;

			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = _gridTender.Rows[selectedRow];

				textBoxStartAdress.Text = row.Cells[1].Value.ToString();
				textBoxEndAdress.Text = row.Cells[2].Value.ToString();
				textBoxDateStart.Text = row.Cells[3].Value.ToString();
				textBoxFinishStart.Text = row.Cells[4].Value.ToString();
				textBoxProduct.Text = row.Cells[5].Value.ToString();
				textBoxQuantity.Text = row.Cells[6].Value.ToString();
			}
		}

		private async void buttonDelTender_Click(object sender, EventArgs e)
		{
			var idChange = Convert.ToInt32(_gridTender.SelectedRows[0].Cells[0].Value);

			string currentStatus = "";

			string getStatus = $"select Status from Tenders where ID = '{idChange}'";

			using SQLiteConnection connection1 = new(_connectionString);
			connection1.Open();

			SQLiteCommand sQLiteCommand = new(getStatus, connection1);

			SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
			while (sQLiteDataReader.Read())
			{
				currentStatus = sQLiteDataReader.GetString(0);
			}

			try 
			{
				var id = Convert.ToInt32(_gridTender.SelectedRows[0].Cells[0].Value);

				if (currentStatus == "Активный")
				{
					string changeCompleted = $"update Tenders set Status = 'Завершенный' where ID = '{id}'";

					using SQLiteConnection connection = new(_connectionString);
					connection.Open();

					SQLiteCommand command = new(changeCompleted, connection);
					command.ExecuteNonQuery();

					string newStatus = "Завершенный";

					MessageBox.Show("Вы успешно поменяли статус тендера!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

					var tender = new Tender { Id = id, Status = newStatus };
					await _hubProxy.Invoke("UpdateTender", tender);
				}
				else if (currentStatus == "Завершенный")
				{
					string changeActivity = $"update Tenders set Status = 'Активный' where ID = '{id}'";

					using SQLiteConnection connection = new(_connectionString);
					connection.Open();

					SQLiteCommand command = new(changeActivity, connection);
					command.ExecuteNonQuery();

					string newStatus = "Активный";

					MessageBox.Show("Вы успешно поменяли статус тендера!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

					var tender = new Tender { Id = id, Status = newStatus };
					await _hubProxy.Invoke("UpdateTender", tender);
				}
				UpdateData();
			}

			catch
			{
				MessageBox.Show("Выберите запись!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void buttonUpdateTender_Click(object sender, EventArgs e)
		{
			TextBox[] textBoxes = { textBoxStartAdress, textBoxEndAdress, textBoxDateStart, textBoxFinishStart, textBoxProduct, textBoxQuantity };

			foreach (TextBox textbox in textBoxes)
			{
				if (string.IsNullOrEmpty(textbox.Text))
				{
					MessageBox.Show("Заполните всю информацию!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			try
			{
				var id = Convert.ToInt32(_gridTender.SelectedRows[0].Cells[0].Value);
				var StartAdress = textBoxStartAdress.Text;
				var EndAdress = textBoxEndAdress.Text;
				var DateStart = textBoxDateStart.Text;
				var DateFinish = textBoxFinishStart.Text;
				var Product = textBoxProduct.Text;
				var Quantity = textBoxQuantity.Text;


				try
				{
					string change = $"update Tenders set StartCity = '{StartAdress}', FinishCity = '{EndAdress}', DateStart= '{DateStart}', DateFinish = '{DateFinish}', Product = '{Product}', Quantity = '{Quantity}' " +
						$"where ID = '{id}'";

					using SQLiteConnection connection = new(_connectionString);
					connection.Open();

					SQLiteCommand command = new(change, connection);
					command.ExecuteNonQuery();

					textBoxStartAdress.Text = "";
					textBoxEndAdress.Text = "";
					textBoxDateStart.Text = "";
					textBoxFinishStart.Text = "";
					textBoxProduct.Text = "";
					textBoxQuantity.Text = "";

					var tender = new Tender()
					{
						Id = id,
						StartCity = StartAdress,
						FinishCity = EndAdress,
						DateStart = DateStart,
						DateFinish = DateFinish,
						Product = Product,
						Quantity = Quantity
					};

					// Вызов метода UpdateTender в хабе SignalR
					await _hubProxy.Invoke("UpdateTender", tender);

				}
				catch
				{
					MessageBox.Show("Неправильный формат записи");
				}	
			}
			catch
			{
				MessageBox.Show("Выберите запись!!!");
			}

			MessageBox.Show("Вы успешно изменили запись!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

			UpdateData();
		}

		private void buttonParticipants_Click(object sender, EventArgs e)
		{
			ParticipantsCreateForm participantsCreateForm = new();

			Hide();

			participantsCreateForm.ShowDialog();

			Show();
		}

		private async void buttonDelete_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Вы уверены? При нажатии на Да, запись будет удалена без возможности восстановления!", "Завершить тендер", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialogResult == DialogResult.Yes)
			{
				try
				{
					var id = Convert.ToInt32(_gridTender.SelectedRows[0].Cells[0].Value);

					string delete =
						$"DELETE FROM Tenders " +
						$"WHERE ID = {id}";

					using SQLiteConnection connection = new(_connectionString);
					connection.Open();

					SQLiteCommand command = new(delete, connection);
					command.ExecuteNonQuery();

					await _hubProxy.Invoke("UpdateTender", new Tender());

					_gridTender.Rows.Remove(_gridTender.SelectedRows[0]);
					UpdateData();
				}
				catch
				{
					MessageBox.Show("Выберите запись!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (dialogResult == DialogResult.No)
			{
			}
		}
	}
}
