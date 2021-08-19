using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    //  if set to abstract both partial classes will be considered to be
    // abstract attempting to instantiate will not work, same with sealed
    //
    //public abstract partial class SamplePartialClass
    //public sealed partial class SamplePartialClass
    //
    //  if a partial class is inheriting both will inherit
    //public partial class SamplePartialClass : Sample
    //
    //  "Though spread accross two different files" one is implementing IEmployee
    //  the other ICustomer, the required method implementation can be done in one of
    //  the partial classes

    public partial class SamplePartialClass : IEmployee
    {
        //public void EmployeeMethod()
        //{
        //    throw new NotImplementedException();
        //}

        public void CustomerMethod()
        {
            throw new NotImplementedException();
        }

        //  the partial classes will be merged at compile time so Method1 and
        //  Method2 will be available from both
        public void Method1()
        {
            
        }
    }
}