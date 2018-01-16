﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    
    class Employee: IPerson
    {
        public delegate void Callback(IPerson person);
        internal enum EmployeeStatus { Boss, AccountManager, Worker};
        private string name;
        private double salary;
        private double discount;
        EmployeeStatus status = EmployeeStatus.Worker;
        CustomerType type = CustomerType.middle;
        Callback callback;
        public Employee(string name, double salary, EmployeeStatus status, CustomerType type)
        {
            this.name = name;
            this.salary = salary;
            this.status = status;
            this.type = type;
            this.discount = ((double)type) / 100;
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
            Console.WriteLine($"You created {status} {name}, who has salary of {salary:C} and discount {discount:P}");
        }

        public void Buy()
        {
           // call create order method
        }
    }
}
