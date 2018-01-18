using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating list of orders to keep created orders 
            //so they could ve viewd efter choosing menu option 4
            List<Order> orders = new List<Order>();

            Console.WriteLine("Shop <BUY SOMETHING>");

            // create temporary object to work with
            Order tempOrder = new Order();

            //Lambda expression  assigned to delegate
            tempOrder.RegisterMessageDelegate((string s) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(s);
                Console.ResetColor();
            });


            bool alive = true;
            while (alive)
            {
                //menu of the shop to choose 
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n1. Buy something  2. Delete something   3. Count Total Sum");
                Console.WriteLine("4. Show existed orders  5. Close Shop");

                Console.Write("Enter number of choice:");
                Console.ForegroundColor = color;
                try
                {   // vaiable to keep user choice of menu option
                    int command = Convert.ToInt32(Console.ReadLine());

                    switch (command)//menu options
                    {
                        case 1:
                            tempOrder.AddItem(5);
                            break;

                        case 2:
                            tempOrder.DeleteItem(5);
                            break;

                        case 3:
                            Console.Write("Write [base; start; middle or big]: ");
                            string type = Console.ReadLine().ToLower();
                            tempOrder.GetDiscount(type);
                            orders.Add(tempOrder);
                            tempOrder = new Order();
                            tempOrder.RegisterMessageDelegate((string s) =>
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(s);
                                Console.ResetColor();
                            });
                            break;

                        case 4:
                            //Show current order status;
                            Console.WriteLine("Current order information:");
                            Console.WriteLine(tempOrder);
                            //Show existed orders
                            Console.WriteLine("Previous orders:");
                            foreach (Order o in orders)
                            {
                                Console.WriteLine(o);
                            }
                            break;

                        case 5:
                            alive = false;
                            continue;
                    }

                }
                catch (Exception ex)
                {
                    // warning user of exception with red color
                    color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = color;
                }
            }

        }

    }
}
