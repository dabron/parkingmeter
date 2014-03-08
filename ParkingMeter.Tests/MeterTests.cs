using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingMeter.Model;

namespace ParkingMeter.Tests
{
	[TestClass]
	public class MeterTests
	{
		[TestMethod]
		public void TestSetMaxAmount()
		{
			var now = new DateTime(2002, 6, 22, 3, 14, 0);
			var meter = new Meter(TimeLimit.OneHour);
			meter.SetMaxAmount(now, 10m);

			Assert.AreEqual(new DateTime(2002, 6, 22, 3, 29, 0), meter.EndTime);
			Assert.AreEqual(1.75m, meter.AmountCharged);
			Assert.AreEqual(15d, meter.MinutesPurchased);
		}

		[TestMethod]
		public void TestSetMaxTime()
		{
			var now = new DateTime(2002, 6, 22, 3, 14, 0);
			var meter = new Meter(TimeLimit.OneHour);
			meter.SetMaxTime(now, 60d);

			Assert.AreEqual(new DateTime(2002, 6, 22, 4, 14, 0), meter.EndTime);
			Assert.AreEqual(1.75m, meter.AmountCharged);
			Assert.AreEqual(60d, meter.MinutesPurchased);
		}
	}
}