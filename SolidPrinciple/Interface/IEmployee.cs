using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.Interface
{
    interface IEmployee
    {

         int Id { get; }
         string Name { get; set; }
        decimal GetMinSalary();
    }
}
