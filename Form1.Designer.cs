namespace lab5
{
	partial class Form1
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
			if (disposing&&(components!=null))
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.balance = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.accCurrency = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.transaction = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.minus = new System.Windows.Forms.Button();
			this.plus = new System.Windows.Forms.Button();
			this.trCurrency = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.balance)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.transaction)).BeginInit();
			this.SuspendLayout();
			//
			// groupBox1
			//
			this.groupBox1.Controls.Add(this.balance);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.accCurrency);
			this.groupBox1.Location = new System.Drawing.Point(36, 43);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(366, 185);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Состояние счета";
			this.groupBox1.UseCompatibleTextRendering = true;
			//
			// balance
			//
			this.balance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.balance.DecimalPlaces = 2;
			this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.balance.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.balance.InterceptArrowKeys = false;
			this.balance.Location = new System.Drawing.Point(110, 50);
			this.balance.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.balance.Name = "balance";
			this.balance.ReadOnly = true;
			this.balance.Size = new System.Drawing.Size(226, 32);
			this.balance.TabIndex = 2;
			this.balance.ThousandsSeparator = true;
			//
			// label2
			//
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Валюта";
			//
			// label1
			//
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Баланс";
			//
			// accCurrency
			//
			this.accCurrency.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.accCurrency.DisplayMember = "0";
			this.accCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.accCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.accCurrency.FormattingEnabled = true;
			this.accCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.accCurrency.Location = new System.Drawing.Point(110, 120);
			this.accCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.accCurrency.Name = "accCurrency";
			this.accCurrency.Size = new System.Drawing.Size(226, 33);
			this.accCurrency.TabIndex = 1;
			this.accCurrency.TabStop = false;
			this.accCurrency.SelectedIndexChanged += new System.EventHandler(this.AccCurrency_SelectedIndexChanged);
			//
			// groupBox2
			//
			this.groupBox2.Controls.Add(this.transaction);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.minus);
			this.groupBox2.Controls.Add(this.plus);
			this.groupBox2.Controls.Add(this.trCurrency);
			this.groupBox2.Location = new System.Drawing.Point(36, 289);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Size = new System.Drawing.Size(366, 291);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Транзакция";
			this.groupBox2.UseCompatibleTextRendering = true;
			//
			// transaction
			//
			this.transaction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.transaction.DecimalPlaces = 2;
			this.transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.transaction.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.transaction.InterceptArrowKeys = false;
			this.transaction.Location = new System.Drawing.Point(110, 55);
			this.transaction.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.transaction.Name = "transaction";
			this.transaction.Size = new System.Drawing.Size(226, 32);
			this.transaction.TabIndex = 4;
			this.transaction.ThousandsSeparator = true;
			//
			// label4
			//
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Сумма";
			//
			// label3
			//
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Валюта";
			//
			// minus
			//
			this.minus.Location = new System.Drawing.Point(191, 197);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(145, 43);
			this.minus.TabIndex = 5;
			this.minus.Text = "Снять";
			this.minus.UseVisualStyleBackColor = true;
			this.minus.Click += new System.EventHandler(this.Minus_Click);
			//
			// plus
			//
			this.plus.Location = new System.Drawing.Point(7, 197);
			this.plus.Name = "plus";
			this.plus.Size = new System.Drawing.Size(145, 43);
			this.plus.TabIndex = 4;
			this.plus.Text = "Зачислить";
			this.plus.UseVisualStyleBackColor = true;
			this.plus.Click += new System.EventHandler(this.Plus_Click);
			//
			// trCurrency
			//
			this.trCurrency.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.trCurrency.DisplayMember = "0";
			this.trCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.trCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.trCurrency.FormattingEnabled = true;
			this.trCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.trCurrency.Location = new System.Drawing.Point(110, 112);
			this.trCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.trCurrency.Name = "trCurrency";
			this.trCurrency.Size = new System.Drawing.Size(226, 33);
			this.trCurrency.TabIndex = 3;
			this.trCurrency.TabStop = false;
			//
			// Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(446, 591);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Банковский счет";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.balance)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.transaction)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox accCurrency;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button plus;
		private System.Windows.Forms.ComboBox trCurrency;
		private System.Windows.Forms.NumericUpDown balance;
		private System.Windows.Forms.NumericUpDown transaction;
	}
}

