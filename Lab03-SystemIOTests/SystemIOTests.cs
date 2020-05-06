using Lab03_SystemIO;
using System;
using System.ComponentModel;
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
            string path = "tests.txt";
            string[] contents = new[] { "Hello." };

            // Act
            // Program.TestMethod(path);
            File.WriteAllLines(path, contents);

            // Assert
            Assert.Equal(contents, File.ReadAllLines(path));
        }

        [Fact]
        public void Can_read_from_file()
        {
            // Arrange
            string path = "tests.txt";
            string[] expectedContents = new[] { "Hello." };

            // Act
            string[] result = File.ReadAllLines(path);

            //
            Assert.Equal(expectedContents, result);
        }

        [Fact]
        public void Can_append_item_to_list()
        {
            // Arrange
            string path = "tests.txt";
            string[] contentsToAppend = new[] { "Hello again!" };

            // Act
            File.AppendAllLines(path, contentsToAppend);

            // Assert
            string[] expectedContents = new[] { "Hello.", "Hello again!" };
            string[] actualContents = File.ReadAllLines(path);
            Assert.Equal(expectedContents, actualContents);
        }

    }
}
