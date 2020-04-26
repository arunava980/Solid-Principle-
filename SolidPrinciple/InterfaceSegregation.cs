using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    interface IPrintTasks
    {
        //all the methods under same interface .In the future if a new method is added under a interface

        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotocopyContent(string content);

    }

    //segregate the new methods in diferent interface
    interface IDuplexContent
    {
        bool DuplexContent(string content);

    }

}
