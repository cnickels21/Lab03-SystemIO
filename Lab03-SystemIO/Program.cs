using System;
using System.IO;

namespace Lab03_SystemIO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chase's and Francesco's unordered list of best T.V. shows!\n");

            string path = "ourList.txt";
            string[] ourListForUpdating = File.ReadAllLines(path);

            UserInteractionHandler(ourListForUpdating);
  
        }

        public static void UserInteractionHandler(string[] ourList)
        {
            Console.WriteLine("\nTo view our list enter 1.\nTo add to our list enter 2.\nTo remove from our list enter 3.\nTo exit app enter 4.");
            int userAction = int.Parse(Console.ReadLine());
            string path = "ourList.txt";

            try
            {
                if (userAction == 1)
                {
                    Console.WriteLine(ViewList(path));
                    UserInteractionHandler(ourList);
                }
                if (userAction == 2)
                {
                    Console.WriteLine("\nEnter the name of the show you would like to add!");
                    string favoriteShow = Console.ReadLine();
                    string[] appendedList = AddItemToList(path, favoriteShow);
                    UserInteractionHandler(appendedList);
                }
                if (userAction == 3)
                {
                    Console.WriteLine(ViewList(path));
                    Console.WriteLine("\nEnter the name of the show you would like to remove.");
                    string specifiedListItem = Console.ReadLine();
                    string[] updatedList = RemoveItemFromList(ourList, specifiedListItem);
                    RemoveItemFromTextFile(path, updatedList);
                    UserInteractionHandler(updatedList);
                }
                if (userAction == 4)
                {
                    return;
                }
            }
            catch (FormatException fex)
            {
                Console.WriteLine("That is not an option!");
                UserInteractionHandler(ourList);
            }
        }

        public static string ViewList(string path)
        {
            string[] ourListFromStorage = File.ReadAllLines(path);
            return string.Join("\n", ourListFromStorage);
        }

        // Method to add item to list

        public static string[] AddItemToList(string path, string input)
        {
            
            File.AppendAllText(path, input);
            string[] appendedList = File.ReadAllLines(path);
            return appendedList;
        }

        // Method to rewrite text file after the array is updated

        public static void RemoveItemFromTextFile(string path, string[] input)
        {
            File.WriteAllLines(path, input);
        }

        // Method to remove item from list
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
            }
        }

        
    }
}
