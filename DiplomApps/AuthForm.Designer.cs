namespace DiplomApps
{
	partial class AuthForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonAuth = new System.Windows.Forms.Button();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(260, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(386, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "TRANSPOREON";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(262, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Логин";
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLogin.Location = new System.Drawing.Point(452, 129);
			this.textBoxLogin.Multiline = true;
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(194, 32);
			this.textBoxLogin.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(262, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 32);
			this.label3.TabIndex = 3;
			this.label3.Text = "Пароль";
			// 
			// buttonAuth
			// 
			this.buttonAuth.Location = new System.Drawing.Point(356, 277);
			this.buttonAuth.Name = "buttonAuth";
			this.buttonAuth.Size = new System.Drawing.Size(190, 43);
			this.buttonAuth.TabIndex = 5;
			this.buttonAuth.Text = "Войти";
			this.buttonAuth.UseVisualStyleBackColor = true;
			this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
			// 
			// textBoxPass
			// 
			this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPass.Location = new System.Drawing.Point(452, 194);
			this.textBoxPass.Multiline = true;
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(194, 32);
			this.textBoxPass.TabIndex = 6;
			// 
			// AuthForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(862, 373);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.buttonAuth);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AuthForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonAuth;
		private System.Windows.Forms.TextBox textBoxPass;
	}
}