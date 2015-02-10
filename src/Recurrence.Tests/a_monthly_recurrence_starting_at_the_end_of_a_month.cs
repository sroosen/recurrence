using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
    public class a_monthly_recurrence_starting_at_the_end_of_a_month
    {
        [Fact]
        public void returns_the_list_of_monthly_occurrences_taking_into_account_the_number_of_days_in_each_month()
        {
            // arrange
            var occurrences =
                Recur.Monthly().StartingFrom(new DateTime(1980, 1, 31));
            
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
                new DateTime(1980, 2, 29),
                new DateTime(1980, 3, 31)
            };
            Assert.Equal(expectedOccurrences, capturedOccurrences);
        }
    }
}
