using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingMeter.Model;

namespace ParkingMeter.Tests
{
	[TestClass]
	public class MeterTests
	{
		[TestMethod]
		public void TestSetMaxDollars()
		{
			var meter = new Meter(TimeLimit.OneHour);
			meter.SetMaxDollars(10m);
			string output = meter.PrintTicket();
		}

		[TestMethod]
		public void TestSetMaxTime()
		{
			var meter = new Meter(TimeLimit.OneHour);
			meter.SetMaxTime(new TimeSpan(1, 0, 0));
			string output = meter.PrintTicket();
		}
	}
}