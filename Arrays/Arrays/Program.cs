using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<List<int>> myList = new List<List<int>>();

                Console.WriteLine("**************************************** ");
                Console.WriteLine("***    CREATING LIST     ***");
                Console.WriteLine("**************************************** ");
                List<int> NewList = new List<int>();
                Console.WriteLine("Input total of items in the array:");
                int HowManyItems = Convert.ToInt16(Console.ReadLine()); // Read the total of items of the new array
                for (int x = 0; x <= HowManyItems; x++)
                {
                    Console.WriteLine(" is this a new array Y/N:");
                    string ItIsAnArray = Console.ReadLine();

                    if (ItIsAnArray != "Y" && ItIsAnArray != "N")
                    { // Valid that the input value is valid
                        do
                        {
                            Console.WriteLine("******** INPUT A VALID VALUE ******");
                            Console.WriteLine(" is this a Sub Array Y/N:");
                            ItIsAnArray = Console.ReadLine();
                        } while (ItIsAnArray != "Y" && ItIsAnArray != "N");
                    }
                    if (ItIsAnArray == "Y")  // if it is a new array
                    {
                        List<int> Y = new List<int>();
                        Y = CreateSubList(x); // Manage sub arrays
                        int r = 0;
                        foreach (int item in Y) // managing the one list output
                        {

                            NewList.Add(item);
                            r++;
                        }
                        myList.Add(NewList);
                    }
                    else
                    {
                        Console.WriteLine(" Input Value:");
                        NewList.Add(Convert.ToInt16(Console.ReadLine()));
                        myList.Add(NewList);
                    }
                    //    }
                    Console.WriteLine("********XXXXXXXXXXXXXXXXXXXXXXXX ******");
                    Console.WriteLine("**TOTAL OF ITEMS TILL NOW MAIN ARRAY **");
                    Console.WriteLine("** " + myList.Count.ToString() + " **");
                    Console.WriteLine("********XXXXXXXXXXXXXXXXXXXXXXXX ******");

                }
                Console.WriteLine("********XXXXXXXXXXXXXXXXXXXXXXXX ******");
                Console.WriteLine("**FINAL TOTAL OF ITEMS IN MAIN ARRAY **");
                Console.WriteLine("** " + myList.Count.ToString() + " **");
                Console.WriteLine("********XXXXXXXXXXXXXXXXXXXXXXXX ******");

                Console.WriteLine(" Do you whant to see all the items in main array: Y/N");
                string answard = Console.ReadLine();
                if (answard == "Y")
                {
                    int r = 0;
                    foreach (int item in NewList)
                    {

                        Console.WriteLine(item.ToString()); // Displaying the list of all the arrays
                        r++;
                    }
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                // if any error occurs
                Console.WriteLine("An error occurred: '{0}'", e);
                Console.ReadLine();
            }
        }
        public static List<int> CreateSubList(int parent)
        {
            List<int> NewSubList = new List<int>();
            Console.WriteLine("Input total of items in the subarray #" + parent + ":");
            int HowManySubItems = Convert.ToInt16(Console.ReadLine()); // read total of items in subarray
            for (int x = 0; x <= HowManySubItems; x++)
            {
                Console.WriteLine("sub Array #" + parent + " - Value - " + x + " (is this an new Sub array Y/N):");
                string ItIsAnArray = Console.ReadLine();
                if (ItIsAnArray != "Y" && ItIsAnArray != "N")
                { // Valid that the input value is valid
                    do
                    {
                        Console.WriteLine("******** INPUT A VALID VALUE ******");
                        Console.WriteLine("Array #" + parent + " - Value - " + x + " (is this a Sub Array Y/N):");
                        ItIsAnArray = Console.ReadLine();
                    } while (ItIsAnArray != "Y" && ItIsAnArray != "N");
                }
                if (ItIsAnArray == "Y")  // if it is a new array
                {
                    Console.WriteLine("Input total of items in the subarray #" + parent + " + Third level array(" + x.ToString() + ") :");
                    int ThirdLevelTotal = Convert.ToInt16(Console.ReadLine()); // read total of items in subarray
                    List<int> ThirdSubList = new List<int>();
                    for (int s = 0; s <= ThirdLevelTotal; s++)
                    {
                        Console.WriteLine("Input Array #" + x + " third Level item(" + s.ToString() + ") - Value:");
                        ThirdSubList.Add(Convert.ToInt16(Console.ReadLine()));
                    }
                    int r = 0; // Consolidate only in one array (because the output is requeried like this)
                    foreach (int item in ThirdSubList)
                    {

                        NewSubList.Add(item);
                        r++;
                    }
                }
                else
                {
                    Console.WriteLine("Input Array #" + x + " - Value - " + x + ":");
                    NewSubList.Add(Convert.ToInt16(Console.ReadLine())); // Catch the item
                }
            }
            return NewSubList;
        }
    }
}
