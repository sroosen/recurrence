using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
	public class an_every_number_of_quarters_recurrence_starting_at_the_end_of_the_month
	{
		[Fact]
		public void returns_the_list_of_quarterly_occurrences_taking_into_account_the_number_of_days_in_each_month()
		{
			// arrange
			var occurrences =
				Recur.EveryNumberOfQuarters(3).StartingFrom(new DateTime(1980, 1, 31));

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
                new DateTime(1980, 1, 31),
                new DateTime(1980, 10, 31),
                new DateTime(1981, 7, 31)
            };
			Assert.Equal(expectedOccurrences, capturedOccurrences);
		}

		[Fact]
		public void returns_the_next_occurrence_taking_into_account_the_number_of_days_in_each_month()
		{
			// arrange
			var startDate = new DateTime(1980, 1, 31);

			// act
			var next =
				Recur.EveryNumberOfQuarters(3).StartingFrom(startDate).Next();

			// assert
			Assert.Equal(new DateTime(1980, 10, 31), next);
		}

		[Fact]
		public void returns_a_specific_occurrence_taking_into_account_the_number_of_days_in_each_month()
		{
			// arrange
			var startDate = new DateTime(1980, 1, 31);

			// act
			var second = Recur.EveryNumberOfQuarters(3).StartingFrom(startDate).Ocurrence(1);

			// assert
			Assert.Equal(new DateTime(1980, 10, 31), second);
		} 
	}
}