using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
    public class a_yearly_recurrence_starting_at_a_leap_day
    {
        [Fact]
        public void returns_the_list_of_yearly_occurrences_taking_into_account_non_leap_years()
        {
            // arrange
            var occurrences =
                Recur.Yearly().StartingFrom(new DateTime(1980, 2, 29));
            
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
                new DateTime(1981, 2, 28),
                new DateTime(1982, 2, 28),
                new DateTime(1983, 2, 28),
                new DateTime(1984, 2, 29)
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
                Recur.Yearly().StartingFrom(startDate).Next();

            // assert
            Assert.Equal(new DateTime(1981, 2, 28), next);
        }
    }
}
