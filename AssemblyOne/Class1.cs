using System;

namespace AssemblyOne
{
    // types can only have internal or public access modifiers
    //private class AssemblyOneClass

    // cannot be accessed if internal outside the assembly/project
    // types are internal by default without an access modifier
    // type members are private by default without an access modifier
    public class AssemblyOneClass
    {
        int Id;

        public void Print()
        {
            Console.WriteLine("Hello");
        }
    }
}
