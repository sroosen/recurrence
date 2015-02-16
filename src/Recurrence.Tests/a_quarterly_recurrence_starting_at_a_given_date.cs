using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
    public class a_quarterly_recurrence_starting_at_a_given_date
    {
        [Fact]
        public void returns_the_list_of_quarterly_occurrences_starting_with_that_date()
        {
            // arrange
            var occurrences =
                Recur.Quarterly().StartingFrom(new DateTime(1980, 1, 1));
            
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
                new DateTime(1980, 4, 1),
                new DateTime(1980, 7, 1)
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
                Recur.Quarterly().StartingFrom(startDate).Next();

            // assert
            Assert.Equal(new DateTime(1980, 4, 1), next);
        }

        [Fact]
        public void returns_a_specific_occurrence()
        {
            // arrange
            var startDate = new DateTime(1980, 1, 1);

            // act
            var third = Recur.Quarterly().StartingFrom(startDate).Ocurrence(2);

            // assert
            Assert.Equal(new DateTime(1980, 7, 1), third);
        }
    }
}
