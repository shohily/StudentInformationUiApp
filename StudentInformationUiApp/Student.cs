using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationUiApp
{
    class Student
    {
        public string regNo;
        public string firstName;
        public string lastName;

        public string GetFullname()
        {
            return firstName + " " + lastName;
        }

        public string GetCode(string code)
        {
            return regNo + code;
        }
    }

    

   

}
