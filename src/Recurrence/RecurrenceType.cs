using System;

namespace Recurrence
{
    public abstract class RecurrenceType
    {
        public abstract DateTime GetOccurrence(DateTime startDate, int occurrenceNumber);
    }
}
