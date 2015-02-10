using System;
using System.Collections;
using System.Collections.Generic;

namespace Recurrence
{
    public class OccurrenceEnumerator : IEnumerator<DateTime>
    {
        private readonly IRecurrenceType _recurrenceType;
        private readonly DateTime _startDate;
        private int _occurrenceNumber;

        public OccurrenceEnumerator(IRecurrenceType recurrenceType, DateTime startDate)
        {
            if (recurrenceType == null)
                throw new ArgumentNullException("recurrenceType");

            _recurrenceType = recurrenceType;
            _startDate = startDate;
            Current = startDate;
            _occurrenceNumber = 0;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            Current = _recurrenceType.GetOccurrence(_startDate, _occurrenceNumber);
            _occurrenceNumber++;
            return true;
        }

        public void Reset()
        {
            Current = _startDate;
            _occurrenceNumber = 0;
        }

        public DateTime Current { get; private set; }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
