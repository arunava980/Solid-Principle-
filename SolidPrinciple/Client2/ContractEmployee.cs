using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPrinciple.Interface;

namespace SolidPrinciple.Client2
{
    public  class ContractEmployee: IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContractEmployee()
        {

        }
        public ContractEmployee(int Id, string Name)  {
            this.Id = Id;
            this.Name = Name;
        }
        public decimal GetMinSalary()
        {
            return 1000 / 10;
        }
    }
}
