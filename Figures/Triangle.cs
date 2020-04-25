using System;
using System.Collections.Generic;
using System.Linq;
using MindBoxTest.Base;

namespace MindBoxTest.Figures
{
	public class Triangle : Figure
	{
		public List<Side> Sides { get; }
		private Lazy<bool> _isRightAngle;
		public bool IsRightAngle => _isRightAngle.Value;

		public Triangle(params Side[] sides)
		{
			Sides = sides.OrderBy(x => x.Length).ToList();
			_isRightAngle = new Lazy<bool>(CalculateRightAngle);
			Validate();
		}

		private bool CalculateRightAngle()
		{
			return Math.Abs(Math.Pow(Sides.ElementAt(2).Length, 2) - (Math.Pow(Sides.ElementAt(0).Length, 2) + Math.Pow(Sides.ElementAt(1).Length, 2))) < Vector2D.Tolerance;
		}

		protected sealed override void Validate()
		{
			if (Sides.Count > 3)
			{
				throw new ArgumentException("Triangle cannot be with more than 3 sides");
			}

			if (!(Sides[0].Length < Sides[1].Length + Sides[2].Length || Sides[1].Length < Sides[0].Length + Sides[2].Length || Sides[2].Length < Sides[0].Length + Sides[1].Length))
			{
				throw new ArgumentException("Triangle does not exist with this sides");
			}
		}

		protected override double CalculateSquare()
		{
			var p = 0.5 * Sides.Sum(x => x.Length);
			return Math.Sqrt(p * (p - Sides.ElementAt(0).Length) * (p - Sides.ElementAt(1).Length) *
			                 (p - Sides.ElementAt(2).Length));
		}
	}
}
