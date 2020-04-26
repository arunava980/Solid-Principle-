using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPrinciple.Interface;

namespace SolidPrinciple.Client2
{
     public abstract class Employee:IEmployee,IEmployeeBonus
    {
        public int Id { get;set; }
        public string Name { get; set; }
        public Employee()
        {

        }
        public Employee(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public  abstract decimal CalculateBonus(decimal salary);


        public abstract decimal GetMinSalary();

       
    }
}
