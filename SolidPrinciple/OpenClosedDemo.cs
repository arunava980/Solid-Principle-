using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public abstract class Employee
    {
        public int Id;
        public string Name;

        //
        public Employee() { }

        public Employee(int Id, string name) {//string empType
            this.Id = Id;
            this.Name = name;
            //this.empType=empType;
        }


        //public decimal CalculateBonus(decimal salary)
        //{
        //    //if(this.empType = "permenant"){return salary * .1M;}else return {}

        //    return salary * .1M;

        //}

        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return string.Format("Id {0}{1}", this.Id, this.Name);
        }
    }

    public class PermanentEmployee:Employee{
        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
    public class TemporaryEmployee : Employee
    {
        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}
