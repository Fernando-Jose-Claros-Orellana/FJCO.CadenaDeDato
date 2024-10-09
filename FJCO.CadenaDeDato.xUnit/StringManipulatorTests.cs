using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FJCO.CadenaDeDato.xUnit
{
    public class StringManipulatorTests
    {
        [Fact]
        public void ReverseString()
        {
            // Arrange
            var stringManipulator = new StringManipulator();
            var input = "Hello World!";
            var expected = "!dlroW olleH";

            // Act
            var result = stringManipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void RemoveSpaces()
        {
            // Arrange
            var stringManipulator = new StringManipulator();
            var input = "Hello World!";
            var expected = "HelloWorld!";

            // Act
            var result = stringManipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
