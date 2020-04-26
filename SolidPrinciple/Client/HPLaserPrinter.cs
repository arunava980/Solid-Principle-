using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.Client
{
     public class HPLaserPrinter: IPrintTasks
    {

        public bool PrintContent(string content){
            Console.WriteLine("the content is {0}",content);
            return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("the content is {0}", content);
            return true;
        }
        public bool FaxContent(string content)
        {
            Console.WriteLine("the content is {0}", content);
            return true;
        }
         public  bool PhotocopyContent(string content)
        {
            Console.WriteLine("the content is {0}", content);
            return true;
        }
    }
}
