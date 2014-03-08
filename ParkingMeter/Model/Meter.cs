using System;

namespace ParkingMeter.Model
{
	public class Meter
	{
		private const decimal StandardRate = 1.75m;
		private readonly TimeLimit _timeLimit;
		private readonly decimal _rate;

		private DateTime _endTime;
		private decimal _amountCharged;
		private decimal _minutesPurchased;

		public Meter(TimeLimit timeLimit)
		{
			_timeLimit = timeLimit;
			_rate = StandardRate;
		}

		public DateTime EndTime { get { return _endTime; } }
		public decimal AmountCharged { get { return _amountCharged; } }
		public decimal MinutesPurchased { get { return _minutesPurchased; } }

		public void SetMaxAmount(DateTime now, decimal dollars)
		{
			throw new NotImplementedException();
		}

		public void SetMaxTime(DateTime now, double minutes)
		{
			throw new NotImplementedException();
		}

		public string PrintTicket()
		{
			throw new NotImplementedException();
		}
	}
}