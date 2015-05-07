# Recurrence

A library that provides basic recurrence functionaltity.

## Usage

Get all weekly occurrences starting today:

```csharp
var occurrences = Recur.Weekly().StartingToday();

foreach (var occurrence in occurrences)
{
    Console.WriteLine(occurrence); // occurrence is a DateTime instance
}
```

Other recurrence types:

```csharp
Recur.EveryNumberOfWeeks(numberOfWeeks);
Recur.Monthly();
Recur.EveryNumberOfMonths(numberOfMonths);
Recur.Quarterly();
Recur.EveryNumberOfQuarters(numberOfQuarters);
Recur.Yearly();
Recur.EveryNumberOfYears(numberOfYears);
```

Get first occurrence after a specific date:

```csharp
DateTime occurrence = Recur.EveryNumberOfMonths(3).StartingFrom(new DateTime(1980, 1, 1)).Next();

Console.WriteLine(occurrence); // outputs the first of april
```

The feature set is kept small because currently it's all I have a need for. Feel free to fork this. I accept pull requests :-)
