using System;

namespace Lab03_SystemIO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void TestMethod(string path)
        {
            throw new NotImplementedException();
        }

        public static string[] RemoveItemFromList(string[] input, string specifiedListItem)
        {
            string[] arrayWithItemRemoved = new string[input.Length - 1];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != specifiedListItem)
                {
                    arrayWithItemRemoved[i] = input[i];
                }
            }
            return arrayWithItemRemoved;
        }
    }
}
