using System;
using AssemblyOne;

namespace AssemblyTwo
{
    //public class AssemblyTwoClassI
    public class AssemblyTwoClassI : AssemblyOneClassI
    { 
        public void Print()
        {
            // can't access without Reference/assembly to AssemblyOne
            // and the using directory
            AssemblyOneClassI AI = new AssemblyOneClassI();

            // can't access outside of AssemblyOne as it is internal
            //AI.ID = 101;
            base.ID = 101;

            // can access the field as the class is inheriting
            AssemblyTwoClassI A2 = new AssemblyTwoClassI();
            A2.ID = 101;


        }
    }
}
