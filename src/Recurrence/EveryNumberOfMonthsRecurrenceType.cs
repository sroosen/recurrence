using System;

namespace Recurrence
{
	public class EveryNumberOfMonthsRecurrenceType : IRecurrenceType
	{
		private readonly int _numberOfMonths;

		public EveryNumberOfMonthsRecurrenceType(int numberOfMonths)
		{
			_numberOfMonths = numberOfMonths;
		}

		public DateTime GetOccurrence(DateTime startDate, int occurrenceNumber)
		{
			return startDate.AddMonths(occurrenceNumber * _numberOfMonths);
		}
	}
}