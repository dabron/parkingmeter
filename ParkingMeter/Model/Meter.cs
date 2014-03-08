using System;

namespace ParkingMeter.Model
{
	public class Meter
	{
		private const decimal StandardHourlyRate = 1.75m;
		private readonly TimeLimit _timeLimit;
		private readonly decimal _minuteRate;

		private DateTime _endTime;
		private decimal _amountCharged;
		private double _minutesPurchased;

		public Meter(TimeLimit timeLimit)
		{
			_timeLimit = timeLimit;
			_minuteRate = StandardHourlyRate / 60m;
		}

		public DateTime EndTime
		{
			get { return _endTime; }
			private set { _endTime = value; }
		}

		public decimal AmountCharged
		{
			get { return _amountCharged; }
			private set { _amountCharged = Math.Round(value, 2); }
		}

		public double MinutesPurchased
		{
			get { return _minutesPurchased; }
			private set { _minutesPurchased = value; }
		}

		public void SetMaxAmount(DateTime now, decimal dollars)
		{
			throw new NotImplementedException();
		}

		public void SetMaxTime(DateTime now, double minutes)
		{
			EndTime = now.AddMinutes(minutes);
			AmountCharged = (decimal)minutes  * _minuteRate;
			MinutesPurchased = minutes;
		}

		public string PrintTicket()
		{
			throw new NotImplementedException();
		}
	}
}