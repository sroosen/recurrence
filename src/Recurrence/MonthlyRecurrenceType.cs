using System;

namespace Recurrence
{
    public class MonthlyRecurrenceType : RecurrenceType
    {
        public override DateTime GetOccurrence(DateTime startDate, int occurrenceNumber)
        {
            return startDate.AddMonths(occurrenceNumber);
        }
    }
}
