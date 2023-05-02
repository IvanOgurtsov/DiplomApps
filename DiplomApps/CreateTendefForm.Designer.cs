namespace DiplomApps
{
	partial class CreateTendefForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonUpdateTender = new System.Windows.Forms.Button();
			this.buttonDelTender = new System.Windows.Forms.Button();
			this.buttonAddTender = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxStartAdress = new System.Windows.Forms.TextBox();
			this.textBoxEndAdress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxDateStart = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxFinishStart = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxProduct = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonParticipants = new System.Windows.Forms.Button();
			this._gridTender = new System.Windows.Forms.DataGridView();
			this.buttonDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._gridTender)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonUpdateTender
			// 
			this.buttonUpdateTender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonUpdateTender.Location = new System.Drawing.Point(471, 526);
			this.buttonUpdateTender.Name = "buttonUpdateTender";
			this.buttonUpdateTender.Size = new System.Drawing.Size(132, 39);
			this.buttonUpdateTender.TabIndex = 6;
			this.buttonUpdateTender.Text = "Изменить";
			this.buttonUpdateTender.UseVisualStyleBackColor = true;
			this.buttonUpdateTender.Click += new System.EventHandler(this.buttonUpdateTender_Click);
			// 
			// buttonDelTender
			// 
			this.buttonDelTender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelTender.Location = new System.Drawing.Point(783, 526);
			this.buttonDelTender.Name = "buttonDelTender";
			this.buttonDelTender.Size = new System.Drawing.Size(322, 39);
			this.buttonDelTender.TabIndex = 5;
			this.buttonDelTender.Text = "Завершить/Активировать тендер";
			this.buttonDelTender.UseVisualStyleBackColor = true;
			this.buttonDelTender.Click += new System.EventHandler(this.buttonDelTender_Click);
			// 
			// buttonAddTender
			// 
			this.buttonAddTender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddTender.Location = new System.Drawing.Point(308, 526);
			this.buttonAddTender.Name = "buttonAddTender";
			this.buttonAddTender.Size = new System.Drawing.Size(132, 39);
			this.buttonAddTender.TabIndex = 4;
			this.buttonAddTender.Text = "Добавить";
			this.buttonAddTender.UseVisualStyleBackColor = true;
			this.buttonAddTender.Click += new System.EventHandler(this.buttonAddTender_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(5, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Начальный адрес";
			// 
			// textBoxStartAdress
			// 
			this.textBoxStartAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxStartAdress.Location = new System.Drawing.Point(178, 78);
			this.textBoxStartAdress.Name = "textBoxStartAdress";
			this.textBoxStartAdress.Size = new System.Drawing.Size(124, 27);
			this.textBoxStartAdress.TabIndex = 8;
			// 
			// textBoxEndAdress
			// 
			this.textBoxEndAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxEndAdress.Location = new System.Drawing.Point(178, 136);
			this.textBoxEndAdress.Name = "textBoxEndAdress";
			this.textBoxEndAdress.Size = new System.Drawing.Size(124, 27);
			this.textBoxEndAdress.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(11, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Конечный адрес";
			// 
			// textBoxDateStart
			// 
			this.textBoxDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDateStart.Location = new System.Drawing.Point(178, 190);
			this.textBoxDateStart.Name = "textBoxDateStart";
			this.textBoxDateStart.Size = new System.Drawing.Size(124, 27);
			this.textBoxDateStart.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(20, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Дата загрузки";
			// 
			// textBoxFinishStart
			// 
			this.textBoxFinishStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxFinishStart.Location = new System.Drawing.Point(178, 263);
			this.textBoxFinishStart.Name = "textBoxFinishStart";
			this.textBoxFinishStart.Size = new System.Drawing.Size(124, 27);
			this.textBoxFinishStart.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(19, 266);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Дата выгрузки";
			// 
			// textBoxProduct
			// 
			this.textBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxProduct.Location = new System.Drawing.Point(178, 334);
			this.textBoxProduct.Name = "textBoxProduct";
			this.textBoxProduct.Size = new System.Drawing.Size(124, 27);
			this.textBoxProduct.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(45, 337);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Продукт";
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxQuantity.Location = new System.Drawing.Point(178, 407);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.Size = new System.Drawing.Size(124, 27);
			this.textBoxQuantity.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(31, 410);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 20);
			this.label6.TabIndex = 17;
			this.label6.Text = "Количество";
			// 
			// buttonParticipants
			// 
			this.buttonParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonParticipants.Location = new System.Drawing.Point(1122, 526);
			this.buttonParticipants.Name = "buttonParticipants";
			this.buttonParticipants.Size = new System.Drawing.Size(193, 39);
			this.buttonParticipants.TabIndex = 20;
			this.buttonParticipants.Text = "Список участников";
			this.buttonParticipants.UseVisualStyleBackColor = true;
			this.buttonParticipants.Click += new System.EventHandler(this.buttonParticipants_Click);
			// 
			// _gridTender
			// 
			this._gridTender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._gridTender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._gridTender.Location = new System.Drawing.Point(320, 12);
			this._gridTender.Name = "_gridTender";
			this._gridTender.RowHeadersWidth = 51;
			this._gridTender.RowTemplate.Height = 24;
			this._gridTender.RowTemplate.ReadOnly = true;
			this._gridTender.Size = new System.Drawing.Size(995, 498);
			this._gridTender.TabIndex = 22;
			this._gridTender.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._participantsGrid_CellClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(627, 526);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(132, 39);
			this.buttonDelete.TabIndex = 24;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// CreateTendefForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(1327, 581);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this._gridTender);
			this.Controls.Add(this.buttonParticipants);
			this.Controls.Add(this.textBoxQuantity);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxProduct);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxFinishStart);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxDateStart);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxEndAdress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxStartAdress);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonUpdateTender);
			this.Controls.Add(this.buttonDelTender);
			this.Controls.Add(this.buttonAddTender);
			this.Name = "CreateTendefForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Создание тендера";
			((System.ComponentModel.ISupportInitialize)(this._gridTender)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonUpdateTender;
		private System.Windows.Forms.Button buttonDelTender;
		private System.Windows.Forms.Button buttonAddTender;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxStartAdress;
		private System.Windows.Forms.TextBox textBoxEndAdress;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxDateStart;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxFinishStart;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxProduct;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonParticipants;
		private System.Windows.Forms.DataGridView _gridTender;
		private System.Windows.Forms.Button buttonDelete;
	}
}