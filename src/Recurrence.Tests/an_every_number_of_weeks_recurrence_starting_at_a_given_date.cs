using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
	public class an_every_number_of_weeks_recurrence_starting_at_a_given_date
	{
		[Fact]
		public void returns_the_list_of_every_number_of_weeks_occurrences_starting_with_that_date()
		{
			// arrange
			var occurrences =
				Recur.EveryNumberOfWeeks(3).StartingFrom(new DateTime(1980, 1, 1));

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
				new DateTime(1980, 1, 22), // 3 weeks
				new DateTime(1980, 2, 12) // 6 weeks
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
				Recur.EveryNumberOfWeeks(3).StartingFrom(startDate).Next();

			// assert
			Assert.Equal(new DateTime(1980, 1, 22), next);
		}

		[Fact]
		public void returns_a_specific_occurrence()
		{
			// arrange
			var startDate = new DateTime(1980, 1, 1);

			// act
			var third = Recur.EveryNumberOfWeeks(3).StartingFrom(startDate).Ocurrence(2);

			// assert
			Assert.Equal(new DateTime(1980, 2, 12), third);
		}
	}
}
