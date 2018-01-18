using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Customer : IPerson
    {

        private string name;
        private double discount;
        private DateTime created;
        CustomerType type = CustomerType.start;

        public Customer(string name, CustomerType type)
        {
            this.name = name;
            this.type = type;
            created = DateTime.Now;
            discount = ((double)type) / 100;
        }

        public string GetName()
        {
            return name;
        }
        public double GetDiscount()
        {
            return discount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\n You created  a new customer: {name}, he has discount {discount:P}. Created:{created}");
        }
        public void Buy(Callback callback)
        {
            //call method create order;
            callback(this);

        }

    }
}
