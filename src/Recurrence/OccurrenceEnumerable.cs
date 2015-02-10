using System;
using System.Collections;
using System.Collections.Generic;

namespace Recurrence
{
    public class OccurrenceEnumerable : IEnumerable<DateTime>
    {
        private readonly IRecurrenceType _recurrenceType;
        private DateTime _startDate;

        public OccurrenceEnumerable(IRecurrenceType recurrenceType)
        {
            if (recurrenceType == null)
                throw new ArgumentNullException("recurrenceType");

            _recurrenceType = recurrenceType;
        }

        public OccurrenceEnumerable StartingToday()
        {
            return StartingFrom(DateTime.Today);
        }

        public OccurrenceEnumerable StartingFrom(DateTime startDate)
        {
            _startDate = startDate;
            return this;
        }

        public DateTime Next()
        {
            return _recurrenceType.GetOccurrence(_startDate, 1);
        }

        public IEnumerator<DateTime> GetEnumerator()
        {
            return new OccurrenceEnumerator(_recurrenceType, _startDate);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
