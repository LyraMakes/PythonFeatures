using System;
using LyraMakes.PythonFeatures;
using Xunit;

namespace PythonFeaturesUnitTests
{
    public class PyRandomTests
    {
        [Fact]
        public void CoverageLmao()
        {
            // Arrange
            PyRandom rand = new PyRandom();
            int val = rand.RandInt();
            
            // Act
            
            
            // Assert
            Assert.InRange(val, 0, int.MaxValue);
            
            
            Assert.NotNull(rand);
        }
        
        [Fact]
        public void RandStringShouldReturnAStringOfGivenLength()
        {
            // Arrange
            const int seed = 9142021;
            Random rand = new Random(seed);
            var sut = new PyRandom(rand);
            const int len = 24;
            
            // Act
            string res = sut.RandString(len);
            // Assert
            Assert.Equal(len, res.Length);
        }
    }
}