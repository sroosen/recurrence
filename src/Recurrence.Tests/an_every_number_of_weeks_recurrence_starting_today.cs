using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
	public class an_every_number_of_weeks_recurrence_starting_today
	{
		[Fact]
		public void returns_the_list_of_every_number_of_weeks_occurrences_starting_with_today()
		{
			// arrange
			var occurrences =
				Recur.EveryNumberOfWeeks(3).StartingToday();

			// act
			var capturedOccurrences = new List<DateTime>();
			foreach (var occurrence in occurrences)
			{
				capturedOccurrences.Add(occurrence);

				if (capturedOccurrences.Count == 3)
					break;
			}

			// assert
			var expectedOccurrences = new[]
            {
                DateTime.Today,
                DateTime.Today.AddDays(21), // 3 weeks
                DateTime.Today.AddDays(42)  // 6 weeks
            };
			Assert.Equal(expectedOccurrences, capturedOccurrences);
		}

		[Fact]
		public void returns_the_first_occurrence_after_today()
		{
			// act
			var next =
				Recur.EveryNumberOfWeeks(3).StartingToday().Next();

			// assert
			Assert.Equal(DateTime.Today.AddDays(21), next);
		}

		[Fact]
		public void returns_a_specific_occurrence()
		{
			// act
			var third = Recur.EveryNumberOfWeeks(3).StartingToday().Ocurrence(2);

			// assert
			Assert.Equal(DateTime.Today.AddDays(42), third);
		}
	}
}
