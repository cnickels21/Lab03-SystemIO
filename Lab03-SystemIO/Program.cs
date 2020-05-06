using System;

namespace Lab03_SystemIO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        

        public static string[] RemoveItemFromList(string[] input, string specifiedListItem)
        {
            try
            {
                string[] arrayWithItemRemoved = new string[input.Length - 1];
                int indexCounterForNewArray = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != specifiedListItem)
                    {
                        arrayWithItemRemoved[indexCounterForNewArray] = input[i];
                        indexCounterForNewArray++;
                    }
                }
                return arrayWithItemRemoved;
            }
            catch (IndexOutOfRangeException iex)
            {
                Console.WriteLine("That item doesn't exist!");
                return input;
                throw;
            }
        }
    }
}
