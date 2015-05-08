using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
	public class an_every_number_of_years_recurrence_starting_at_a_leap_day
	{
		[Fact]
		public void returns_the_list_of_yearly_occurrences_taking_into_account_non_leap_years()
		{
			// arrange
			var occurrences =
				Recur.EveryNumberOfYears(3).StartingFrom(new DateTime(1980, 2, 29));

			// act
			var capturedOccurrences = new List<DateTime>();
			foreach (var occurrence in occurrences)
			{
				capturedOccurrences.Add(occurrence);

				if (capturedOccurrences.Count == 5)
					break;
			}

			// assert
			var expectedOccurrences = new[]
            {
                new DateTime(1980, 2, 29),
                new DateTime(1983, 2, 28),
                new DateTime(1986, 2, 28),
                new DateTime(1989, 2, 28),
                new DateTime(1992, 2, 29)
            };
			Assert.Equal(expectedOccurrences, capturedOccurrences);
		}

		[Fact]
		public void returns_the_next_occurrence_taking_into_account_non_leap_years()
		{
			// arrange
			var startDate = new DateTime(1980, 2, 29);

			// act
			var next =
				Recur.EveryNumberOfYears(3).StartingFrom(startDate).Next();

			// assert
			Assert.Equal(new DateTime(1983, 2, 28), next);
		}

		[Fact]
		public void returns_a_specific_occurrence_taking_into_account_non_leap_years()
		{
			// arrange
			var startDate = new DateTime(1980, 2, 29);

			// act
			var third = Recur.EveryNumberOfYears(3).StartingFrom(startDate).Ocurrence(2);

			// assert
			Assert.Equal(new DateTime(1986, 2, 28), third);
		} 
	}
}