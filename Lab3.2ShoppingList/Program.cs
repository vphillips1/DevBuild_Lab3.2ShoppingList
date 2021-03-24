using System;
using System.Collections.Generic;

namespace Lab3._2ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to V's Market!\n");

            Dictionary<string, decimal> marketItem = new Dictionary<string, decimal>();

            marketItem.Add("apple", 0.99m);
            marketItem.Add("banana", 0.59m);
            marketItem.Add("cauliflower", 1.59m);
            marketItem.Add("dragonfruit", 2.19m);
            marketItem.Add("elderberry", 1.79m);
            marketItem.Add("figs", 2.09m);
            marketItem.Add("grapefruit", 1.99m);
            marketItem.Add("honeydew", 3.49m);

            List<string> item = new List<string>();
           

            List<decimal> price = new List<decimal>();

            

            Console.WriteLine("\tItem     \tPrice");
            Console.WriteLine(" ================================ ");

            foreach ( var listItem in marketItem)
            {
                Console.WriteLine($"\t{listItem.Key}    \t${listItem.Value}\t\t");
            }
            bool shouldContinue = true;

            while (shouldContinue)
            {

                Console.WriteLine("\nWhat item would you like to order?\n");
                string entry = Console.ReadLine();

                if (marketItem.ContainsKey(entry))
                {
                    item.Add(entry);
                    price.Add(marketItem[entry]);
                    Console.WriteLine($"Adding {entry} to cart at ${marketItem[entry]}");
                } 
                else
                {

                    Console.WriteLine("Sorry, that item is not available.");
                    continue;
                }


                bool again = true;
                while (again)
                {


                    Console.WriteLine("Would you like to order anything else (y/n)?");
                    string userInput = Console.ReadLine();

                    if (userInput.Equals("y", StringComparison.OrdinalIgnoreCase))
                    {

                        foreach (var listItem in marketItem)
                        {
                            Console.WriteLine($"\t{listItem.Key}    \t${listItem.Value}\t\t");
                        }
                        shouldContinue = true;
                        break;
                    }
                    else if (userInput.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        decimal total = 0;
                        Console.WriteLine("Thanks for your order!\n");
                        Console.Write($"Here's what you got: ");
                        Console.WriteLine($"{item.Count} item(s)");

                        for (int i = 0; i < item.Count; i++)
                        {
                            Console.WriteLine($"\t{item[i]}    \t${price[i]}");
                          
                            total += price[i];
                        }

                        Console.WriteLine($"Average price per item in order was ${total / item.Count}.");
                        Console.WriteLine("Thank you! Have a great day!");

                        shouldContinue = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid selection. Please try again.");
                       again = true;
                    }





                }
                              

            }
            
        }
    }
}
