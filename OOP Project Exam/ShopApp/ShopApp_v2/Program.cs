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
            List<Order> orders = new List<Order>();
            

            Console.WriteLine("Shop <BUY SOMETHING>");

            // create temporary object to work with
            Order tempOrder = new Order();

            tempOrder.RegisterMessageDelegate((string s) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(s);
                Console.ResetColor();
            });
            Console.Write("Write [base; start; middle or big]: ");
            string type = Console.ReadLine().ToLower();
            
            bool alive = true;
            while (alive)
            {
                
                //menu to choose 
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n1. Buy something \t2. Delete something \t3. Show existed orders");
                Console.WriteLine("4. Count Sum \t5. Close Shop");
                Console.Write("Enter number of choice:");
                Console.ForegroundColor = color;
                try
                {
                    int command = Convert.ToInt32(Console.ReadLine());

                    switch (command)
                    {
                        case 1:
                            tempOrder.AddItem(5);
                            break;
                        case 2:
                            tempOrder.DeleteItem(5);
                            break;
                        case 3:
                            orders.Add(tempOrder);
                            foreach(Order o in orders)
                            {
                                Console.WriteLine(o);
                            }
                            
                            break;
                        case 4:
                            tempOrder.GetDiscount(type);
                            break;
                        case 5:
                            alive = false;
                            continue;
                    }
                    //DoSomething();
                }
                catch (Exception ex)
                {
                    color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = color;
                }
            }
            //Console.ReadKey();
        }

        private static void ShowExistedOrders()
        {
            Console.Write("nothing to show yet!");
        }

        //private static void DeleteItem(Order order)
        //{
            
        //}

        //private static void CreateOrder()
        //{
            
            
        //}
    }
}
