using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
    public class a_monthly_recurrence_starting_at_a_given_date
    {
        [Fact]
        public void returns_the_list_of_monthly_occurrences_starting_with_that_date()
        {
            // arrange
            var occurrences =
                Recur.EveryMonth().StartingFrom(new DateTime(1980, 1, 1));
            
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
                new DateTime(1980, 2, 1),
                new DateTime(1980, 3, 1)
            };
            Assert.Equal(expectedOccurrences, capturedOccurrences);
        }
    }
}
