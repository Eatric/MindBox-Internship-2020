using NUnit.Framework;
using MindBoxTest.Base;
using MindBoxTest.Figures;

namespace MindBoxTest.Tests
{
	[TestFixture]
	public class UnknownPolygonTests
	{
		[Test]
		public void UnknownPolygonCheckCorrectSquare4Points()
		{
			var polygon = new UnknownPolygon(
				new Vector2D(10, 10),
				new Vector2D(60, 10),
				new Vector2D(100, 60),
				new Vector2D(100, 10));

			Assert.AreEqual(1000, polygon.Square);
		}

		[Test]
		public void UnknownPolygonCheckCorrectSquare8Points()
		{
			var polygon = new UnknownPolygon(
				new Vector2D(10, 10),
				new Vector2D(20, 30),
				new Vector2D(20, 60),
				new Vector2D(50, 50),
				new Vector2D(110, 60),
				new Vector2D(90, 40),
				new Vector2D(100, 10),
				new Vector2D(50, 20));

			Assert.AreEqual(3050, polygon.Square);
		}
	}
}
