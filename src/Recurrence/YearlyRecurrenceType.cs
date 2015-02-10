using System;

namespace Recurrence
{
    public class YearlyRecurrenceType : IRecurrenceType
    {
        public DateTime GetOccurrence(DateTime startDate, int occurrenceNumber)
        {
            return startDate.AddYears(occurrenceNumber);
        }
    }
}
