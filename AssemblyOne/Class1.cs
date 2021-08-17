using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        // internal members will be available to within the project/assembly
        //internal int ID = 101;

        // any class deriving from this class can access it even in another
        // project or assembly
        protected internal int ID = 101;
    }

    public class AssemblyOneClassII
    {
        public void SampleMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            Console.WriteLine(A1.ID);
        }
    }
}
