﻿using System;
using System.Collections.Generic;
using Xunit;

namespace Recurrence.Tests
{
    public class a_weekly_recurrence_starting_today
    {
        [Fact]
        public void returns_the_list_of_weekly_occurrences_starting_with_today()
        {
            // arrange
            var occurrences =
                Recur.Weekly().StartingToday();
            
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
                DateTime.Today.AddDays(7),
                DateTime.Today.AddDays(14)
            };
            Assert.Equal(expectedOccurrences, capturedOccurrences);
        }

        [Fact]
        public void returns_the_first_occurrence_after_today()
        {
            // act
            var next =
                Recur.Weekly().StartingToday().Next();

            // assert
            Assert.Equal(DateTime.Today.AddDays(7), next);
        }

        [Fact]
        public void returns_a_specific_occurrence()
        {
            // act
            var third = Recur.Weekly().StartingToday().Ocurrence(2);

            // assert
            Assert.Equal(DateTime.Today.AddDays(14), third);
        }
    }
}
