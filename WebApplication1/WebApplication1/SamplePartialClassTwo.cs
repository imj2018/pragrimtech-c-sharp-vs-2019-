using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    //  multiple inheritance/attempting to inherit from a different class
    //  for one of the other partial classes will not work
    //public partial class SamplePartialClass : Employee
    public partial class SamplePartialClass : ICustomer
    {
        //  implementing IEmployee interface members from here though
        //  implementing ICustomer from this partial class
        public void EmployeeMethod()
        {
            throw new NotImplementedException();
        }

        public void Method2()
        {

        }
    }
}