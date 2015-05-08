using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
	public class an_every_number_of_months_recurrence_starting_at_a_given_date
	{
		[Fact]
		public void returns_the_list_of_monthly_occurrences_starting_with_that_date()
		{
			// arrange
			var occurrences =
				Recur.EveryNumberOfMonths(3).StartingFrom(new DateTime(1980, 1, 1));

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
                new DateTime(1980, 1, 1),
                new DateTime(1980, 4, 1), // 3 months
                new DateTime(1980, 7, 1) // 6 months
            };
			Assert.Equal(expectedOccurrences, capturedOccurrences);
		}

		[Fact]
		public void returns_the_first_occurrence_after_that_date()
		{
			// arrange
			var startDate = new DateTime(1980, 1, 1);

			// act
			var next =
				Recur.EveryNumberOfMonths(3).StartingFrom(startDate).Next();

			// assert
			Assert.Equal(new DateTime(1980, 4, 1), next);
		}

		[Fact]
		public void returns_a_specific_occurrence()
		{
			// arrange
			var startDate = new DateTime(1980, 1, 1);

			// act
			var third = Recur.EveryNumberOfMonths(3).StartingFrom(startDate).Ocurrence(2);

			// assert
			Assert.Equal(new DateTime(1980, 7, 1), third);
		}
	}
}
