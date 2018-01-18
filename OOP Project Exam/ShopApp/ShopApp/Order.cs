using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Order
    {
        protected int orderId;
        static int idCount = 0;
        protected string customerName;
        protected double orderSum;
        protected double discount;
        protected double itemPrice;

        public Order()// constructor with default values
        {
            orderId = ++idCount;
            customerName = "Default Customer";
            orderSum = 0;
            discount = 0;
        }

        public int OrderID
        {
            get { return orderId; }
        }
        /// <summary>
        /// Buy item method: Ask user to enter manually price of item double or integer type
        /// user should enter -1 to finsih buying and get total sum with discount 
        /// </summary>
        /// <param name="person"> Customer or Employee class as part of IPerson</param>
        public void AddItem(IPerson person)
        {
            discount = person.GetDiscount();
            string name = person.GetName();

            double subTotal = 0;
            while (itemPrice != -1)
            {
                subTotal += itemPrice;
                Console.Write("Enter price of item [-1 to quit]: ");
                itemPrice = double.Parse(Console.ReadLine());
            }
            orderSum = subTotal - subTotal * discount;

            Console.WriteLine($"Sum of ur order {subTotal}. Total sum with discount is {orderSum}");
            Console.WriteLine($"Thank you {person.GetName()} for your choice. Number of ur order is {OrderID} ");
        }


    }
}
