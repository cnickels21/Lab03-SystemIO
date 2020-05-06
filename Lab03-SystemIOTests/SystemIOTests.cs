using System;
using System.IO;
using Xunit;

namespace Lab03_SystemIOTests
{
    public class SystemIOTests
    {
        [Fact]
        public void Can_write_to_file()
        {
            // Arrange
            // From parameters
            string path = "tests.txt";
            string[] contents = new[] { "Hello" };

            // Act
            File.WriteAllLines(path, contents);

            // Assert
            Assert.Equal(contents, File.ReadAllLines(path));
        }
    }
}
