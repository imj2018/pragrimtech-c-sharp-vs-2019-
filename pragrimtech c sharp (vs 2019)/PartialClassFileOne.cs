using System;
using System.Collections.Generic;
using System.Text;

namespace pragrimtech_c_sharp__vs_2019_
{
    //  must be a partial class to use partial methods
    //public class SamplePartialClass
    public partial class SamplePartialClass
    {
        //  if there are no implementation details, the declaration/definition
        //  and any invocations will be ignored at runtime
        //
        //  partial methods are private by default and cannot have access modifiers
        partial void SamplePartialMethod();

        //  must have the same signature
        //partial void SamplePartialMethod(int i);


        //  can be implemented directly so long as there is a seperate declaration
        //partial void SamplePartialMethod()
        //{
        //    Console.WriteLine("SamplePartialMethod Invoked");
        //}

        //  having both the declaration and implementation will have a compiler
        //  error as the declaration and implementation are in the same place like
        //  a normal method
        //
        //  partial methods must be void
        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplePartialMethod Invoked");
        }

        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod Invoked");
            SamplePartialMethod();
        }
    }
}
