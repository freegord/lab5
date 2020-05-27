// Currency.cs
namespace lab5
{
	class Currency
	{
		private readonly string _text;
		private readonly decimal _exRate;

		public Currency(string text, decimal exRate) => (_text, _exRate)=(text, exRate);
		public Currency(string text, double exRate) : this(text, new decimal(exRate)) { }

		public string Text => _text;

		public decimal ExRate => _exRate;

		public decimal Ratio(Currency newCurrency) => ExRate/newCurrency.ExRate;
	}
}
