using System;

namespace Recurrence
{
    public class WeeklyRecurrenceType : RecurrenceType
    {
        public override DateTime GetOccurrence(DateTime startDate, int occurrenceNumber)
        {
            return startDate.AddDays(occurrenceNumber*7);
        }
    }
}
