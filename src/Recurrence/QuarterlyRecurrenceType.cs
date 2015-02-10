using System;

namespace Recurrence
{
    public class QuarterlyRecurrenceType : IRecurrenceType
    {
        public DateTime GetOccurrence(DateTime startDate, int occurrenceNumber)
        {
            return startDate.AddMonths(3*occurrenceNumber);
        }
    }
}
