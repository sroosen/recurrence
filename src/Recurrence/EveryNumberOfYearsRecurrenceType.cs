using System;

namespace Recurrence
{
	public class EveryNumberOfYearsRecurrenceType : IRecurrenceType
	{
		private readonly int _numberOfYears;

		public EveryNumberOfYearsRecurrenceType(int numberOfYears)
		{
			_numberOfYears = numberOfYears;
		}

		public DateTime GetOccurrence(DateTime startDate, int occurrenceNumber)
		{
			return startDate.AddYears(occurrenceNumber * _numberOfYears);
		}
	}
}