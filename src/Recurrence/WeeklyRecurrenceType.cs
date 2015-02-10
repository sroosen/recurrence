using System;

namespace Recurrence
{
    public class WeeklyRecurrenceType : IRecurrenceType
    {
        public DateTime GetOccurrence(DateTime startDate, int occurrenceNumber)
        {
            return startDate.AddDays(occurrenceNumber*7);
        }
    }
}
