namespace Recurrence
{
    public static class Recur
    {
        public static OccurrenceEnumerable EveryWeek()
        {
            return new OccurrenceEnumerable(new WeeklyRecurrenceType());
        }

        public static OccurrenceEnumerable EveryMonth()
        {
            return new OccurrenceEnumerable(new MonthlyRecurrenceType());
        }
    }
}
