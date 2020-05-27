// Form1.cs
namespace lab5
{
	using System;
	using System.Windows.Forms;

	public partial class Form1 : Form
	{
		private readonly Account account = new Account();
		private readonly Currency[] currencies;
		private readonly Currency baseCurrency;
		public Form1()
		{
			InitializeComponent();
			currencies = new[]
			{
				new Currency("RUR", 1.0),
				new Currency("USD", 70.0),
				new Currency("EUR", 80.0),
			};

			baseCurrency=currencies[0];

			foreach (var field in new[]{accCurrency, trCurrency})
			{
				foreach (var currency in currencies)
					_=field.Items.Add(currency.Text);
				field.SelectedIndex=0;
			}

			foreach(var field in new []{ balance, transaction})
				field.Controls[0].Visible=false;

		}

		private void Plus_Click(object sender, EventArgs e)
		{
			account.Add(currencies[trCurrency.SelectedIndex],
						 baseCurrency,
						 transaction.Value);
			RefreshBalance();
		}

		private void Minus_Click(object sender, EventArgs e)
		{
			try
			{
				account.Subtract(currencies[trCurrency.SelectedIndex],
								  baseCurrency,
								  transaction.Value);
			}
			catch (Account.InsufficientFundsException)
			{
				_=MessageBox.Show("Вы не можете себе этого позволить!\r\nОткат транзакции.",
								  "Транзакция прервана.",
								  MessageBoxButtons.OK,
								  MessageBoxIcon.Error);
			}
			RefreshBalance();
		}

		private void AccCurrency_SelectedIndexChanged(object sender, EventArgs e) => RefreshBalance();

		private void RefreshBalance()
		{
			var newCurrency=currencies[accCurrency.SelectedIndex];
			balance.Value=account.Balance*baseCurrency.Ratio(newCurrency);
		}
	}
}
