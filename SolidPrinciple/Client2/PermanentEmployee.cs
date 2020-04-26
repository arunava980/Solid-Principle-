using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.Client2
{
    public class PermanentEmployee:Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PermanentEmployee()
        {

        }
        public PermanentEmployee(int Id, string Name) : base(Id, Name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary / 10;
        }
        public override decimal GetMinSalary()
        {
            return 1000 / 10;
        }

    }
}
