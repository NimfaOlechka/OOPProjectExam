using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Order
    {
        //private int orderId;
        //private int customerId;
        protected double orderSum;
        protected double discount;
        protected double itemPrice;

        public Order()
        {
            //this.orderId = 0;
            //this.customerId = 0;
            this.orderSum = 0;
            this.discount = 0;
        }

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
        }


    }
}
