using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    interface IUser
    {
        //user interfsce with all responsibility segreate intio different interfaces to break the responsibilities
        bool Login(string userName, string password);
        bool Register(string emailContent, string userName, string password);
        bool SendMail(string emailContent);
        bool LogError(string error);

    }

    interface IUsers
    {
        //user interfsce with all responsibility segreate intio different interfaces to break the responsibilities
        bool Login(string userName, string password);
        bool Register(string emailContent, string userName, string password);

    }
    interface IEmail
    {
        //user interfsce with all responsibility segreate intio different interfaces to break the responsibilities       
        bool SendMail(string emailContent);
    }
    interface ILogger
    {
        //user interfsce with all responsibility segreate intio different interfaces to break the responsibilities
        bool LogError(string error);
    }
}
