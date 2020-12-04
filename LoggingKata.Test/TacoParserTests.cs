using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.989837,-85.21302,Taco Bell East Ridg...", -85.21302 )]
        [InlineData("32.381582,-86.215604,Taco Bell Montgomer...", -86.215604)]
        [InlineData("30.357759,-87.163888,Taco Bell Gulf Breez...", -87.163888)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tester = new TacoParser();                                                                        
            //Act
            var actual = tester.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.989837,-85.21302,Taco Bell East Ridg...", 34.989837)]
        [InlineData("32.381582,-86.215604,Taco Bell Montgomer...", 32.381582)]
        [InlineData("30.357759,-87.163888,Taco Bell Gulf Breez...", 30.357759)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tester = new TacoParser();

            //Act
            var actual = tester.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
