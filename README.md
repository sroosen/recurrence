# Recurrence

A library that provides basic recurrence functionaltity.

## Usage

```csharp
var occurrences = Recur.EveryWeek().StartingToday();

foreach (var occurrence in Recur.EveryWeek().StartingToday())
{
    Console.WriteLine(occurrence); // occurrence is a DateTime instance
}
```

The feature set is kept small because currently it's allI have a need for. Feel free to fork this. I accept pull requests :-)