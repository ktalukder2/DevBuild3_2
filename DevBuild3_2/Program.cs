using System;
using System.Collections.Generic;

namespace DevBuild3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<decimal> shoppingListPrice = new List<decimal>();
            //shoppingListPrice.Add(1.12m);
            //shoppingListPrice.Add(0.88m);
            //shoppingListPrice.Add(2.99m);
            //shoppingListPrice.Add(4.99m);
            //shoppingListPrice.Add(2.88m);
            //shoppingListPrice.Add(1.99m);
            //shoppingListPrice.Add(1.88m);
            //shoppingListPrice.Add(5.99m);
            //List<string> shoppingListMenu = new List<string>();
            //shoppingListMenu.Add("Apple");
            //shoppingListMenu.Add("Banana");
            //shoppingListMenu.Add("Watermelon");
            //shoppingListMenu.Add("Jackfruit");
            //shoppingListMenu.Add("Strawberry");
            //shoppingListMenu.Add("Kiwi");
            //shoppingListMenu.Add("Orange");
            //shoppingListMenu.Add("Mango");

            Dictionary<string, decimal> shoppingListMenu = new Dictionary<string, decimal>();

            HashSet<string> addedToCart = new HashSet<string>();
            
            shoppingListMenu.Add("apple",1.12m);
            shoppingListMenu.Add("banana",0.88m);
            shoppingListMenu.Add("watermelon", 2.99m);
            shoppingListMenu.Add("jackfruit", 4.99m);
            shoppingListMenu.Add("strawberry", 2.88m);
            shoppingListMenu.Add("kiwi", 1.99m);
            shoppingListMenu.Add("orange", 1.88m);
            shoppingListMenu.Add("mango", 5.99m);

            //Dictionary<string> addedToCart = new Dictionary<string, decimal>();

            bool userOrderAgain =false;

            while (userOrderAgain==false)
            {
             


                Console.WriteLine("Welcome to Guenther's Fruit Market!");

                Console.WriteLine("Item" + "\t\t\tPrice");
                Console.WriteLine("==========================================");
                //Console.WriteLine(shoppingListMenu.Keys,shoppingListMenu.Values);
                foreach (var ListofMenu in shoppingListMenu)
                {
                    if (ListofMenu.Key.Length > 6)
                    {
                        Console.WriteLine($"{ListofMenu.Key}\t\t{ListofMenu.Value}");
                    }
                    else
                    {
                        Console.WriteLine($"{ListofMenu.Key}\t\t\t{ListofMenu.Value}");
                    }
                }

                //Console.WriteLine(shoppingListMenu[1] + "   \t\t" + "$" + shoppingListPrice[1]);
                //Console.WriteLine(shoppingListMenu[2] + "   \t\t" + "$" + shoppingListPrice[2]);
                //Console.WriteLine(shoppingListMenu[3] + "   \t\t" + "$" + shoppingListPrice[3]);
                //Console.WriteLine(shoppingListMenu[4] + "   \t\t" + "$" + shoppingListPrice[4]);
                //Console.WriteLine(shoppingListMenu[5] + "        \t\t" + "$" + shoppingListPrice[5]);
                //Console.WriteLine(shoppingListMenu[6] + "   \t\t" + "$" + shoppingListPrice[6]);
                //Console.WriteLine(shoppingListMenu[7] + "   \t\t" + "$" + shoppingListPrice[7]);


                Console.Write("What item would you like to order?: ");

                string userAddToCart = Console.ReadLine().ToLower();

                //shoppingListMenu.ContainsKey(userAddToCart);

                if (shoppingListMenu.ContainsKey(userAddToCart))
                {
                    Console.WriteLine($"Adding {userAddToCart} to cart ${shoppingListMenu[userAddToCart]}");
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have those. Please try again ");
                    
                }

                Console.WriteLine("Would you like to order anything else (y/n)");
                string orderAgain = Console.ReadLine().ToLower();

                if (orderAgain=="n")
                {
                   
                    userOrderAgain = true;
         

                }
                else
                {
                    addedToCart.Add(userAddToCart);
                }


               

            }
            Console.WriteLine("Thanks for . your order!");
            Console.WriteLine("Here's what you got: ");
            decimal totalValue = 0;
            int totalItem = 0;
            foreach (var itemInAddedCart in addedToCart)
            {
                //if (itemInAddedCart=="apple")
                //{
                //    Console.WriteLine(itemInAddedCart + " 1");
                //}
                totalValue = totalValue + shoppingListMenu[itemInAddedCart];
               // Console.WriteLine(shoppingListMenu[itemInAddedCart]);
                totalItem = totalItem + 1;

                
                Console.WriteLine($"{itemInAddedCart} \t\t${shoppingListMenu[itemInAddedCart]}");

             
            }

            Console.WriteLine($"average price per item in order was  \t ${totalValue/totalItem}");
        }

         
}
}
