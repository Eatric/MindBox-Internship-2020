using System;

namespace MindBoxTest.Base
{
	public struct Side
	{
		private Lazy<double> _length;

		public double Length => _length.Value;

		public Vector2D Start { get; }

		public Vector2D End { get; }

		public Side(float xStart, float yStart, float xEnd, float yEnd) : this()
		{
			Start = new Vector2D(xStart, yStart);
			End = new Vector2D(xEnd, yEnd);
			_length = new Lazy<double>(CalculateLength);
		}

		private double CalculateLength()
		{
			return Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
		}
	}
}
