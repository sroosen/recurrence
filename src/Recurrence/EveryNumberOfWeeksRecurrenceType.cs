using System;

namespace Recurrence
{
	public class EveryNumberOfWeeksRecurrenceType : IRecurrenceType
	{
		private readonly int _numberOfWeeks;

		public EveryNumberOfWeeksRecurrenceType(int numberOfWeeks)
		{
			_numberOfWeeks = numberOfWeeks;
		}

		public DateTime GetOccurrence(DateTime startDate, int occurrenceNumber)
		{
			return startDate.AddDays(occurrenceNumber * 7 * _numberOfWeeks);
		}
	}
}