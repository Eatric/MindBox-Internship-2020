using MindBoxTest.Base;
using MindBoxTest.Figures;
using NUnit.Framework;

namespace MindBoxTest.Tests
{
	[TestFixture]
	public class TriangleTests
	{
		[Test]
		public void TriangleCheckRightAngle()
		{
			var triangle = new Triangle(
				new Side(0, 0, 0, 4),
				new Side(0, 0, 3, 0),
				new Side(0, 4, 3, 0));

			Assert.AreEqual(true, triangle.IsRightAngle);
		}

		[Test]
		public void TriangleCheckRightAngleShouldBeNegative()
		{
			var triangle = new Triangle(
				new Side(0, 0, 1, 6),
				new Side(0, 0, 2, 0),
				new Side(1, 6, 2, 0));

			Assert.AreEqual(false, triangle.IsRightAngle);
		}

		[Test]
		public void TriangleCheckCorrectSquare()
		{
			var triangle = new Triangle(
				new Side(0, 0, 0, 4),
				new Side(0, 0, 3, 0),
				new Side(0, 4, 3, 0));

			Assert.AreEqual(6, triangle.Square);
		}
	}
}
