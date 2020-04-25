using MindBoxTest.Base;
using NUnit.Framework;

namespace MindBoxTest.Tests
{
	[TestFixture]
	class SideTests
	{
		[Test]
		public void SideCorrectLengthCalculate()
		{
			var side = new Side(0, 0, 5, 0);

			Assert.AreEqual(5, side.Length);
		}
	}
}
