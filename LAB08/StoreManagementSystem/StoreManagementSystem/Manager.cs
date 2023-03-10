using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
    internal class Manager: Employee
    {
        public Manager(string name, int age, double baseSalary): base(name, age, baseSalary)
        {
            Console.WriteLine("---Manager has been added--");
            this.ShowEmployeeInfo();
        }

        public override void ShowEmployeeInfo()
        {
            Console.WriteLine($"Name: {this.Name} -- Age: {this.Age} -- BaseSalary: BDT {this.BaseSalary}");
        }

        public override void SellProduct(int id, int amt, Store store)
        {
            var p = store.FindProduct(id);
            p.Curlevel-= amt;
        }
    }
}
