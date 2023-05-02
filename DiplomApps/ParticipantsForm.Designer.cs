namespace DiplomApps
{
	partial class ParticipantsForm
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
			this._gridTender = new System.Windows.Forms.DataGridView();
			this.buttonUpdatePrice = new System.Windows.Forms.Button();
			this.textBox_Price = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this._gridTender)).BeginInit();
			this.SuspendLayout();
			// 
			// _gridTender
			// 
			this._gridTender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._gridTender.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
			this._gridTender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._gridTender.Location = new System.Drawing.Point(23, 12);
			this._gridTender.Name = "_gridTender";
			this._gridTender.ReadOnly = true;
			this._gridTender.RowHeadersWidth = 51;
			this._gridTender.RowTemplate.Height = 24;
			this._gridTender.Size = new System.Drawing.Size(1166, 415);
			this._gridTender.TabIndex = 0;
			// 
			// buttonUpdatePrice
			// 
			this.buttonUpdatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonUpdatePrice.Location = new System.Drawing.Point(258, 500);
			this.buttonUpdatePrice.Name = "buttonUpdatePrice";
			this.buttonUpdatePrice.Size = new System.Drawing.Size(210, 41);
			this.buttonUpdatePrice.TabIndex = 1;
			this.buttonUpdatePrice.Text = "Предложить цену";
			this.buttonUpdatePrice.UseVisualStyleBackColor = true;
			this.buttonUpdatePrice.Click += new System.EventHandler(this.buttonUpdatePrice_Click);
			// 
			// textBox_Price
			// 
			this.textBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_Price.Location = new System.Drawing.Point(33, 500);
			this.textBox_Price.Multiline = true;
			this.textBox_Price.Name = "textBox_Price";
			this.textBox_Price.Size = new System.Drawing.Size(183, 41);
			this.textBox_Price.TabIndex = 2;
			// 
			// ParticipantsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(1201, 599);
			this.Controls.Add(this.textBox_Price);
			this.Controls.Add(this.buttonUpdatePrice);
			this.Controls.Add(this._gridTender);
			this.Name = "ParticipantsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Форма участников";
			((System.ComponentModel.ISupportInitialize)(this._gridTender)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView _gridTender;
		private System.Windows.Forms.Button buttonUpdatePrice;
		private System.Windows.Forms.TextBox textBox_Price;
	}
}