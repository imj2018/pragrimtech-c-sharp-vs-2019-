using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass : AssemblyOneClass
    { 
        public void Test()
        {
            AssemblyOneClass assemblyOne = new AssemblyOneClass();
            assemblyOne.Print();
        }
    }
}
