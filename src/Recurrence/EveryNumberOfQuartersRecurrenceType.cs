using System;

namespace Recurrence
{
	public class EveryNumberOfQuartersRecurrenceType : IRecurrenceType
	{
		private readonly int _numberOfQuarters;

		public EveryNumberOfQuartersRecurrenceType(int numberOfQuarters)
		{
			_numberOfQuarters = numberOfQuarters;
		}

		public DateTime GetOccurrence(DateTime startDate, int occurrenceNumber)
		{
			return startDate.AddMonths(3 * occurrenceNumber * _numberOfQuarters);
		}
	}
}