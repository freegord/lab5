namespace lab5
{
	using System;

	class Account
	{
		private decimal _balance;

		public decimal Balance => _balance;

		public void Add(Currency currency, Currency baseCurrency, decimal transactionValue) =>
			_balance+=transactionValue*currency.Ratio(baseCurrency);

		public void Subtract(Currency currency, Currency baseCurrency, decimal transactionValue)
		{
			var tmp=transactionValue*currency.Ratio(baseCurrency);
			if(tmp>_balance)
				throw new InsufficientFundsException();
			_balance-=transactionValue*currency.Ratio(baseCurrency);
		}

		public class InsufficientFundsException : Exception { }
	}
}
