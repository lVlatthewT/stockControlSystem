using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* //////////////////////////////////////////////////////////////////////////////////////
Author: Matthew Tattersall                                                             //
                                                                                       //
Program Title: Stock control system                                                    //
                                                                                       //
Date: 28/01/25                                                                         //
                                                                                       //
Description: This program is a stock control system, which allows the user to          //
to view the contents of items within the management system. alternatively, the user    //
can add new items into the system.                                                     //
                                                                                       //
                                                                                       //
                                                                                       //
 *///////////////////////////////////////////////////////////////////////////////////////

namespace stockControlSystem
{
    internal class Program
    {

        public static  /* Initiates a multidimensional, which has 5 rows with the following values below */
            string[][] productTypes = new string[5][]
            {
                new string[] {"Meat"},
                new string[] {"Dairy"},
                new string[] {"Fruit n Veg"},
                new string[] {"Tinned"},
                new string[] {"Bathroom"}
            };


        /* initialises a sorted list which stores products as keys and product types as value. */
        public static SortedList<string, string> productList = new SortedList<string, string>() {
                {"Milk", "Dairy"},
                {"Beans", "Tinned"},
                {"Mice", "Meat"},
                {"Butter", "Dairy"}
            };
        static void Main(string[] args)
        {
            /* Initiates the main loop of the program allowing via displaying possible
             * navigational options, which is accomplished by calling the menu method. */
            while (true)
            {
                Console.WriteLine("1. Product Types");
                Console.WriteLine("2. Products");
                Console.WriteLine("3. Add Product");
                Console.WriteLine("4. Exit Program");

                menu();

                
                
            }
        }
        static void menu()
        {
            int mainMenuChoice;
            //prompts user for menu option input
            Console.Write("Please select an option: ");
            mainMenuChoice = int.Parse(Console.ReadLine());


            /* This switch case statement is used to decide and call the appropriate
             * method based on the user's input */
            switch (mainMenuChoice) {
                case 1:
                    listProductTypes();
                    break;
                case 2:
                    listProducts();
                    break;
                case 3:
                    addProduct();
                    break;
                case 4:

                    /* exits the program once the user selects the option 4 */
                    Console.WriteLine("goodbye...");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("This is an invalid option. Please choose again.");
                    break;
            
            }
        }


        static void listProductTypes()
        {
           


            

            Console.WriteLine("-------------------------------------");
            
            /*  the outer for loop iterates through each row of my multidimensional array
             *  which is used to display the order of products in numerical order*/
            for (int row = 0; row < productTypes.Length; row++)
            {
                Console.Write(row + ":  ");


                /* The inner for loop is used to iterate through each column of the array
                 further printing both an index number and product items in a numerical and vertical manner.*/
                for (int col = 0; col < productTypes[row].Length; col++)
                {
                    Console.WriteLine(productTypes[row][col] + " ");
                    
                    
                }
                
            } 
            Console.WriteLine();
        }



        static void listProducts()
        {
            
            Console.WriteLine();
            Console.WriteLine("Product: \t Product Type: ");
            Console.WriteLine("----------------------------------");

            /* This foreach loop is used to iterate through each key/value pair
             * stored within my previously initialised sorted list. finally
            , foreach loop prints each key/value pair to the console.
            */
            foreach (KeyValuePair<string, string> keyvalue in productList)
            {
                Console.WriteLine($"{keyvalue.Key} \t\t {keyvalue.Value}");
                
            }
            Console.WriteLine();
        }

        static void addProduct()
        {
            string userProductChoice;
            int userProductTypeChoice;
            //prompts for user input
            Console.Write("Please input a product: ");
            userProductChoice = Console.ReadLine();
            Console.WriteLine("----------------------------");
            listProducts();
            Console.WriteLine("----------------------------");





            //lists all product types and prompts for user input
            Console.WriteLine("1. Meat");
            Console.WriteLine("2. Dairy");
            Console.WriteLine("3. Fruit n veg");
            Console.WriteLine("4. Tinned");
            Console.WriteLine("5. Bathroom");
            Console.Write("Please a product type from 1-5: ");
            userProductTypeChoice = int.Parse(Console.ReadLine());

            /* 
                once the user has inputted their product, they will then be asked to input
                a number from 1 - 5, which depending on the input of a number, it will perform a certain task
                . for example, choosing option 1 would add the product input into the sorted list as a key
                and a product type as a value.
             
             
             */
            switch (userProductTypeChoice)
            {
                case 1:
                    productList.Add(userProductChoice, "Meat");
                    break;
                case 2:
                    productList.Add(userProductChoice, "Dairy");
                    break;
                case 3:
                    productList.Add(userProductChoice, "Fruit n Veg");
                    break;
                case 4:
                    productList.Add(userProductChoice, "Tinned");
                    break;
                case 5:
                    productList.Add(userProductChoice, "Bathroom");
                    break;
                default:
                    Console.WriteLine("This is an invalid choice. please choose a number between 1 - 5");
                    break;

            }

            
            /* recalls the list products method, which will show the additional item
             * added via user input*/
            listProducts();

        }
    }
}
