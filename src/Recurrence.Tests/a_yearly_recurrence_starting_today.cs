using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
    public class a_yearly_recurrence_starting_today
    {
        [Fact]
        public void returns_the_list_of_yearly_occurrences_starting_with_today()
        {
            // arrange
            var occurrences =
                Recur.Yearly().StartingToday();
            
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
                DateTime.Today.AddYears(1),
                DateTime.Today.AddYears(2)
            };
            Assert.Equal(expectedOccurrences, capturedOccurrences);
        }

        [Fact]
        public void returns_the_first_occurrence_after_today()
        {
            // act
            var next =
                Recur.Yearly().StartingToday().Next();

            // assert
            Assert.Equal(DateTime.Today.AddYears(1), next);
        }
    }
}
