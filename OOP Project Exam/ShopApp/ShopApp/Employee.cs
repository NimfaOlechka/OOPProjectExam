﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    
    class Employee: IPerson, IComparable<Employee>
    {
        
        internal enum EmployeeStatus { Boss, AccountManager,SalesManager,Worker};
        private string name;
        private double salary;
        private double discount;
        EmployeeStatus status = EmployeeStatus.Worker;
        CustomerType type = CustomerType.middle;

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
            Console.WriteLine($"\n You created {status} {name}, who has salary of {salary:C} and discount {discount:P}");
        }

        //calling method to create order with delegate
        public void Buy(Callback callback)
        {
            callback(this);
        }

        public int CompareTo(Employee other)
        {
            return status.CompareTo(other.status);
            //return (int)(salary - other.salary);
        }

        public override string ToString()
        {
            return ($" {status} {name} with salary: {salary:C} and discount: {discount:P}");
        }
    }
}
