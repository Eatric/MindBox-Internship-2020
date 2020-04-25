using System;

namespace MindBoxTest.Base
{
	public abstract class Figure
	{
		private readonly Lazy<double> _square;

		public double Square => _square.Value;

		protected Figure()
		{
			_square = new Lazy<double>(CalculateSquare);
		}

		protected abstract void Validate();

		protected abstract double CalculateSquare();
	}
}
