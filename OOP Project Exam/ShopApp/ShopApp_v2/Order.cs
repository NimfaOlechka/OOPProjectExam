using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp_v2
{
    class Order
    {
        //variables of order
        public delegate void MessageDelegate(string message);

        double sum; //keeping sum of the order
        protected int orderId;//automatisk id
        static int idCount = 0;// for setting unique id for each order
        double discount;//discount from order
        string customerName;

        MessageDelegate mesDel;

        public void RegisterMessageDelegate(MessageDelegate mes)
        {
            mesDel = mes;
        }

        public Order()//constructor
        {
            sum = 0;
            discount = 0.0;
            orderId = ++idCount;
            customerName = "Default customer";
        }

        public double CurrentSum
        {
            get { return sum; }
        }

        // add or delete goods from basket
        public void AddItem(double price)
        {

            sum += price;
            //discount = sum*discount;
            //sum -= discount;
            mesDel($"You added an item on sum: {price}");
            //mesDel($"Sum of ur order is: {sum}");
        }

        public void DeleteItem(double price)
        {
            if (price <= sum)
            {
                sum -= price;
                //sum += discount*10;
                mesDel($"You deleted item on sum: {price}");
                //mesDel($"Sum of ur order is: {sum}");
            }
            else
            {
                mesDel("Impossible to delete unexisted!");
            }

        }

        public void GetDiscount(string customertype)
        {

            switch (customertype)
            {
                case "base":
                    discount = 0.0;
                    break;

                case "start":
                    discount = 0.05;
                    break;
                case "middle":
                    discount = 0.1;
                    break;
                case "big":
                    discount = 0.2;
                    break;
                default:
                    discount = 0.0;
                    break;
            }
             mesDel($"Your discount is: {discount:P}");
             discount = sum * discount;
             sum -= discount;
             mesDel($"Sum of ur order is {sum:C}");
           
        }

        public override string ToString()
        {
            return ($"Order #: {orderId} made {customerName} on Total Sum: {sum:C}. discount made: {discount:P}");
        }
    }
}
