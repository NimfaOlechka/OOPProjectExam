using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public enum CustomerType { start=0, little=5, middle=10, big=20 };
    delegate void Callbak(IPerson person);
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("WebShop", "H.C.Andersensvej 8");
            shop.DisplayTitle();

            Customer customer = new Customer("Peter Doe", CustomerType.middle);
            customer.DisplayInfo();
            customer.Buy(CreateOrder);

            Employee employee = new Employee("Marta Ross", 2000, Employee.EmployeeStatus.Boss,CustomerType.big);
            employee.DisplayInfo();
           

            
            CreateOrder(customer);
            CreateOrder(employee);


            Console.ReadLine();

        }
        static void CreateOrder(IPerson person)
        {
            Order order = new Order();
            order.AddItem(person);
        }
    }
}
