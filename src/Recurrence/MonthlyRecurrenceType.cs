using System;

namespace Recurrence
{
    public class MonthlyRecurrenceType : IRecurrenceType
    {
        public DateTime GetOccurrence(DateTime startDate, int occurrenceNumber)
        {
            return startDate.AddMonths(occurrenceNumber);
        }
    }
}
