using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp_v2
{
    class Order
    {
        //delegate calls method to write messages to user after actions
        public delegate void MessageDelegate(string message);

        double sum; //keeping sum of the order
        protected int orderId;//automatisk id
        static int idCount = 0;// for setting unique id for each order
        double discount;
        string customerName;

        //create delegate variable
        MessageDelegate mesDel;

        //register delegate
        public void RegisterMessageDelegate(MessageDelegate mes)
        {
            mesDel = mes;
        }

        public Order()//constructor setting default values
        {
            sum = 0;
            discount = 0.0;
            orderId = ++idCount;
            customerName = "Default customer";
        }
        // property allows only read value of the sum
        public double CurrentSum
        {
            get { return sum; }
        }
        //property to return orderID
        public int OrderId
        {
            get { return orderId; }
        }

        // add goods to the cart
        public void AddItem(double price)
        {
            sum += price;
                  mesDel($"You added an item on sum: {price}");
        }
        //delete item from basket 
        public void DeleteItem(double price)
        {
            if (price <= sum)
            {
                sum -= price;
                mesDel($"You deleted item on sum: {price}");
            }
            else
            {
                mesDel("Impossible to delete unexisted!");
            }
        }

        //setting discount values depending of customer type
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
            return ($"Order #: {OrderId} made {customerName} on Total Sum: {CurrentSum:C}. discount made: {discount:P}");
        }
    }
}
