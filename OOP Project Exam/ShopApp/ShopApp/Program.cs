using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public enum CustomerType { start=0, little=5, middle=10, big=20 };
    delegate void Callback(IPerson person);
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("WebShop", "H.C.Andersensvej 8");
            shop.DisplayTitle();

            Customer customer = new Customer("Peter Doe", CustomerType.middle);
            customer.DisplayInfo();
            customer.Buy(CreateOrder);

            Employee employee = new Employee("Jocker", 2000, Employee.EmployeeStatus.Boss,CustomerType.big);
            employee.DisplayInfo();
            employee.Buy(CreateOrder);

            Employee[] workers = new Employee[3];
            for (int i=0; i<workers.Length; i++)
            {
                workers[i] = new Employee("Mr "+(i+1), 50, Employee.EmployeeStatus.Worker, CustomerType.little);
            }

            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].DisplayInfo();
                workers[i].Buy(CreateOrder);
            }
          
            //CreateOrder(customer);
            //CreateOrder(employee);


            Console.ReadLine();

        }
        static void CreateOrder(IPerson person)
        {
            Order order = new Order();
            order.AddItem(person);
        }
    }
}
