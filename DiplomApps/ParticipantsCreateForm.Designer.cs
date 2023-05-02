namespace DiplomApps
{
	partial class ParticipantsCreateForm
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
			this._participantsGrid = new System.Windows.Forms.DataGridView();
			this.buttonAddPart = new System.Windows.Forms.Button();
			this.buttonDelPart = new System.Windows.Forms.Button();
			this.buttonUpdatePart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxTelephone = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxCompany = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._participantsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// _participantsGrid
			// 
			this._participantsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._participantsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._participantsGrid.Location = new System.Drawing.Point(232, 88);
			this._participantsGrid.Name = "_participantsGrid";
			this._participantsGrid.RowHeadersWidth = 51;
			this._participantsGrid.RowTemplate.Height = 24;
			this._participantsGrid.RowTemplate.ReadOnly = true;
			this._participantsGrid.Size = new System.Drawing.Size(778, 338);
			this._participantsGrid.TabIndex = 0;
			this._participantsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._participantsGrid_CellClick);
			// 
			// buttonAddPart
			// 
			this.buttonAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddPart.Location = new System.Drawing.Point(317, 528);
			this.buttonAddPart.Name = "buttonAddPart";
			this.buttonAddPart.Size = new System.Drawing.Size(132, 39);
			this.buttonAddPart.TabIndex = 1;
			this.buttonAddPart.Text = "Добавить";
			this.buttonAddPart.UseVisualStyleBackColor = true;
			this.buttonAddPart.Click += new System.EventHandler(this.buttonAddPart_Click);
			// 
			// buttonDelPart
			// 
			this.buttonDelPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelPart.Location = new System.Drawing.Point(491, 528);
			this.buttonDelPart.Name = "buttonDelPart";
			this.buttonDelPart.Size = new System.Drawing.Size(132, 39);
			this.buttonDelPart.TabIndex = 2;
			this.buttonDelPart.Text = "Удалить";
			this.buttonDelPart.UseVisualStyleBackColor = true;
			this.buttonDelPart.Click += new System.EventHandler(this.buttonDelPart_Click);
			// 
			// buttonUpdatePart
			// 
			this.buttonUpdatePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonUpdatePart.Location = new System.Drawing.Point(671, 528);
			this.buttonUpdatePart.Name = "buttonUpdatePart";
			this.buttonUpdatePart.Size = new System.Drawing.Size(132, 39);
			this.buttonUpdatePart.TabIndex = 3;
			this.buttonUpdatePart.Text = "Изменить";
			this.buttonUpdatePart.UseVisualStyleBackColor = true;
			this.buttonUpdatePart.Click += new System.EventHandler(this.buttonUpdatePart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(172, 465);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Имя";
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxName.Location = new System.Drawing.Point(220, 465);
			this.textBoxName.MaxLength = 10;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(148, 27);
			this.textBoxName.TabIndex = 5;
			// 
			// textBoxTelephone
			// 
			this.textBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxTelephone.Location = new System.Drawing.Point(479, 465);
			this.textBoxTelephone.MaxLength = 12;
			this.textBoxTelephone.Name = "textBoxTelephone";
			this.textBoxTelephone.Size = new System.Drawing.Size(125, 27);
			this.textBoxTelephone.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(388, 465);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Телефон";
			// 
			// textBoxCompany
			// 
			this.textBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCompany.Location = new System.Drawing.Point(724, 465);
			this.textBoxCompany.MaxLength = 20;
			this.textBoxCompany.Name = "textBoxCompany";
			this.textBoxCompany.Size = new System.Drawing.Size(119, 27);
			this.textBoxCompany.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(626, 465);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Компания";
			// 
			// textBoxPass
			// 
			this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPass.Location = new System.Drawing.Point(943, 465);
			this.textBoxPass.MaxLength = 10;
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(116, 27);
			this.textBoxPass.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(865, 465);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "Пароль";
			// 
			// ParticipantsCreateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(1201, 599);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxCompany);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxTelephone);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonUpdatePart);
			this.Controls.Add(this.buttonDelPart);
			this.Controls.Add(this.buttonAddPart);
			this.Controls.Add(this._participantsGrid);
			this.Name = "ParticipantsCreateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Список участников";
			((System.ComponentModel.ISupportInitialize)(this._participantsGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView _participantsGrid;
		private System.Windows.Forms.Button buttonAddPart;
		private System.Windows.Forms.Button buttonDelPart;
		private System.Windows.Forms.Button buttonUpdatePart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxTelephone;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxCompany;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPass;
		private System.Windows.Forms.Label label4;
	}
}