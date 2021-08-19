using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //TextBox1.Text

            //  the use of partial classes are for the designer.cs file is for the
            //  system generated code, while the aspx.cs is for the developers

            //  partial classes can be used for developers to work on seperate parts of 
            //  a projects

            Customer C1 = new Customer();
            C1.FirstName = "Pragim";
            C1.LastName = "Technologies";
            string FullName = C1.GetFullName();
            Response.Write("Full Name = " + FullName + "<br/>");

            PartialCustomer C2 = new PartialCustomer()
            {
                FirstName = "Pragim",
                LastName = "Tech"
            };
            string FullName2 = C2.GetFullName();
            Response.Write(FullName2 + "<br/>");

            //  test one partial class as abstract
            //SamplePartialClass samplePartial = new SamplePartialClass();

            SamplePartialClass samplePartial = new SamplePartialClass();
            //samplePartial.GetData();

        }

    }

    //public class Sample : SamplePartialClass
    //public class Sample
    //{
    //    public void GetData()
    //    {

    //    }

    //}

    //public class Employee
    //{

    //}

    public interface IEmployee
    {
        void EmployeeMethod();
    }

    public interface ICustomer
    {
        void CustomerMethod();

    }


}