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
        CustomerType type=CustomerType.start;
     
        public Customer(string name, CustomerType type)
        {
            this.name = name;
            this.type = type;
            this.discount = ((double)type)/100;
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
            Console.WriteLine($"You created  a new customer: {name}, he has discount {discount:P}");
        }
        public void Buy(Callbak callback)
        {
            //call method create order;
            callback(this);
            
        }

    }
}
