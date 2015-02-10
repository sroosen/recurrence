using System;

namespace Recurrence
{
    public interface IRecurrenceType
    {
        DateTime GetOccurrence(DateTime startDate, int occurrenceNumber);
    }
}
