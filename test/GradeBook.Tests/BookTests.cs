using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
           var result = book.GetStatistics();

           //assert
           Assert.Equal(85.6, result.Average, 1);
           Assert.Equal(90.5, result.High, 1);
           Assert.Equal(77.3, result.Low, 1);
        }

        [Fact]
        public void BookWontAcceptNumberHigherThan100()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(102.5);
            book.AddGrade(105.5);
            book.AddGrade(82.5);

            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(82.5, result.Average, 1);
            Assert.Equal(82.5, result.High, 1);
            Assert.Equal(82.5, result.Low, 1);
        }
    }
}