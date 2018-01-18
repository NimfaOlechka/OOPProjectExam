using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public enum CustomerType { start = 0, little = 5, middle = 10, big = 20 };
    delegate void Callback(IPerson person);
    class Program
    {
        static void Main(string[] args)
        {
            //start shop
            Shop shop = new Shop("WebShop", "H.C.Andersensvej 8");
            shop.DisplayTitle();

            bool alive = true;
            while (alive)
            {
                

                //menu with options to choose 
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n1. Create Customer \t 2. Create Employee  \t 3. Show existed employees");
                Console.WriteLine("4. Show orders \t 5. Close Shop");
                Console.Write("Enter number of choice:");
                Console.ForegroundColor = color;
                try
                {
                    int command = Convert.ToInt32(Console.ReadLine());

                    switch (command)
                    {
                        case 1:
                            CreateCustomer();
                            break;
                        case 2:
                            CreateEmployee();
                            break;
                        case 3:
                            ShowExistedEmployees();
                            break;
                        case 4:
                            ShowOrders();
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

            //CreateOrder(customer);
            //CreateOrder(employee);
            // Console.ReadLine();

        }

        //private static void DoSomething()
        //{
        //    throw new NotImplementedException();
        //}

        private static void ShowOrders()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Option 3 from menu: creates 5 employess 
        /// Then displays them ordered by employee status field
        /// </summary>
        private static void ShowExistedEmployees()
        {
            //create random employees 
            Employee[] employees = new Employee[5];
            Random rnd = new Random();

            //just filling 3 employees with a little random data
            for (int i = 0; i < employees.Length - 2; i++)
            {
                CustomerType rndCustomer = (CustomerType)rnd.Next(0, 2);
                employees[i] = new Employee("Mr " + (i + 1), 50 - i, Employee.EmployeeStatus.Worker, rndCustomer);
            }
            // an et par of them manually 
            employees[3] = new Employee("Mira Money", 2000, Employee.EmployeeStatus.AccountManager, CustomerType.middle);
            employees[4] = new Employee("Jocker", 10000, Employee.EmployeeStatus.Boss, CustomerType.big);

            //sort them efter status n display info
            Array.Sort(employees);
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
        /// <summary>
        /// Customer class representation with otion to make an order
        /// </summary>
        static void CreateCustomer()
        {
            //create customer and make an order;
            Customer customer = new Customer("Peter Doe", CustomerType.middle);
            customer.DisplayInfo();
            customer.Buy(CreateOrder);
        }

        /// <summary>
        /// Employee class representation with option to make an order
        /// </summary>
        static void CreateEmployee()
        {
            //create employee and make an order;
            Employee employee1 = new Employee("Jocker", 2000, Employee.EmployeeStatus.Boss, CustomerType.big);
            employee1.DisplayInfo();
            employee1.Buy(CreateOrder);

        }
        /// <summary>
        /// Create Order method called via delegate.
        /// User can enter integer or float values.
        /// </summary>
        /// <param name="person"> Customer or Employee, depending of user choice </param>
        static void CreateOrder(IPerson person)
        {
            Order order = new Order();
            order.AddItem(person);
        }
    }
}
