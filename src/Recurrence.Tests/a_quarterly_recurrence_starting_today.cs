using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
    public class a_quarterly_recurrence_starting_today
    {
        [Fact]
        public void returns_the_list_of_quarterly_occurrences_starting_with_today()
        {
            // arrange
            var occurrences =
                Recur.Quarterly().StartingToday();
            
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
                DateTime.Today.AddMonths(3),
                DateTime.Today.AddMonths(6)
            };
            Assert.Equal(expectedOccurrences, capturedOccurrences);
        }

        [Fact]
        public void returns_the_first_occurrence_after_today()
        {
            // act
            var next =
                Recur.Quarterly().StartingToday().Next();

            // assert
            Assert.Equal(DateTime.Today.AddMonths(3), next);
        }

        [Fact]
        public void returns_a_specific_occurrence()
        {
            // act
            var second = Recur.Quarterly().StartingToday().Ocurrence(1);

            // assert
            Assert.Equal(DateTime.Today.AddMonths(3), second);
        }
    }
}
