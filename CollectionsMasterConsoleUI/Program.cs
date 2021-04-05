using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // DONE - Create an integer Array of size 50 

            int[] myArray = new int[50];

            // DONE - Create a method to populate the number array with 50 random numbers that are between 0 and 50

            // DONE - created instance of Random class from System
            //Random rnd = new Random();

            Populater(myArray);

            // DONE created for loop to be used to assign numbers to each index of myArray
            // add the below to the Populator() method at the bottom.

            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = rng.Next(0, 50);
            //}

            // DONE - Print the first number of the array

            Console.Write("This is the first number of myArray: ");
            Console.WriteLine(myArray[0]);

            // DONE - Print the last number of the array

            Console.Write("This is the last number of myArray: ");
            Console.WriteLine(myArray[myArray.Length - 1]);

            Console.WriteLine(); // added to seperate the section

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");

            NumberPrinter(myArray);

            // Not using NumberPrinter() method. created foreach loop to display the numbers on fewer lines in the console.

            //{
            //    foreach (int i in myArray)
            //    {
            //        Console.Write(i + ", ");
            //    }
            //}
            
            Console.WriteLine(); // added as a line separator for the next section

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine(); // added as a line separator for the next section

            Console.WriteLine("All Numbers Reversed:");
            Console.WriteLine("-------------------");

            ReverseArray(myArray);

            Console.WriteLine(); // added as a line separator for the next section

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine(); // added as a line separator for the next section

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(myArray);

            Console.WriteLine(); // added as a line separator for the next section

            Console.WriteLine("-------------------");

            // DONE - Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            // DONE -Create an integer List

            List<int> myList = new List<int>();

            // DONE - Print the capacity of the list to the console

            Console.WriteLine($"Start Capacity: {myList.Count}");

            // DONE - Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(myList);


            //Print the new capacity

            Console.WriteLine($"New Capicity: {myList.Count}");
            

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            int userNunber;
            bool isANumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userNunber);

            } while (isANumber == false);

            NumberChecker(myList, userNunber);
            

            
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            // DONE - Print all numbers in the list
            //NumberPrinter();

            NumberPrinter(myList);

            Console.WriteLine("-------------------");

            // DONE - Create a method that will remove all odd numbers from the list then print results


            Console.WriteLine("Evens Only!!"); // changed to evens 

            OddKiller(myList);
            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!"); //changed to evens

            myList.Sort(); // sorts the list

            NumberPrinter(myList); // method prints the list
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            
            var newArray = myList.ToArray();

            //Clear the list

            myList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i); // or use numberList.Remove(numberList[i]);
                }
            }

            NumberPrinter(numberList);
                 
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            // Print to the consoled that the number is inside of the list
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes your number {searchNumber} is contained in the list.");
            }
            else
            {
                Console.WriteLine($"Your number is not in the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {

            //Random rng = new Random();

            // Using a while loop
            while (numberList.Count < 50)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);

                numberList.Add(number);
            }

            NumberPrinter(numberList);

            // Another way to poulate the list
            //for (int i = 0; i < numberList.Count; i++)
            //{

            //    numberList.Add(i);
            //    NumberPrinter(numberList);
            //}

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);

            }

        }


        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                // changed from
                //Console.WriteLine(item);

                // to

                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
