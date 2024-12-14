using AdventOfCode._2024_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Tests
{
    public class LocationIDSorterTests
    {
        private readonly LocationIDSorter _sorter;

        private readonly int[] testInput1 = {3, 4, 2, 1, 3, 3};
        private readonly int[] testInput2 = {4, 3, 5, 3, 9, 3};

        public LocationIDSorterTests()
        {
            _sorter = new LocationIDSorter();
        }

        [Fact]
        public void SortInputs_ShouldSortLowToHigh()
        {
            //Arrange
            int[] expectedOutput1 = { 1, 2, 3, 3, 3, 4 };
            int[] expectedOutput2 = { 3, 3, 3, 4, 5, 9 };

            //Act
            _sorter.SortInputs(testInput1, testInput2);

            //Assert
            Assert.Equal(testInput1, expectedOutput1);
            Assert.Equal(testInput2, expectedOutput2);
        }

        [Fact]
        public void Solve_ShouldSolveCorrectly()
        {
            //Arrange
            int expectedAnswer = 11;

            //Act
            int answer = _sorter.Solve(testInput1, testInput2);

            //Assert
            Assert.Equal(answer, expectedAnswer);
        }
    }
}
