namespace Recurrence
{
    public static class Recur
    {
        public static OccurrenceEnumerable Weekly()
        {
            return new OccurrenceEnumerable(new WeeklyRecurrenceType());
        }

	    public static OccurrenceEnumerable EveryNumberOfWeeks(int numberOfWeeks)
	    {
		    return new OccurrenceEnumerable(new EveryNumberOfWeeksRecurrenceType(numberOfWeeks));
	    }

        public static OccurrenceEnumerable Monthly()
        {
            return new OccurrenceEnumerable(new MonthlyRecurrenceType());
        }

	    public static OccurrenceEnumerable EveryNumberOfMonths(int numberOfMonths)
	    {
		    return new OccurrenceEnumerable(new EveryNumberOfMonthsRecurrenceType(numberOfMonths));
	    }

        public static OccurrenceEnumerable Quarterly()
        {
            return new OccurrenceEnumerable(new QuarterlyRecurrenceType());
        }

	    public static OccurrenceEnumerable EveryNumberOfQuarters(int numberOfQuarters)
	    {
		    return new OccurrenceEnumerable(new EveryNumberOfQuartersRecurrenceType(numberOfQuarters));
	    }

        public static OccurrenceEnumerable Yearly()
        {
            return new OccurrenceEnumerable(new YearlyRecurrenceType());
        }

	    public static OccurrenceEnumerable EveryNumberOfYears(int numberOfYears)
	    {
		    return new OccurrenceEnumerable(new EveryNumberOfYearsRecurrenceType(numberOfYears));
	    }
    }
}
