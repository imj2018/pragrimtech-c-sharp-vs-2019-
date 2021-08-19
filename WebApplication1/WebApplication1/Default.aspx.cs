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
            Session["Session1"] = "Session 1 Data";
            Session["Session2"] = "Session 2 Data";

            //  pull data from first session key i.e Session["Session1"]
            //  with integral indexer
            Response.Write("Session 1 Data = " + Session[0].ToString());
            Response.Write("<br/>");

            // pull data using string indexer
            Response.Write("Session 2 Data = " + Session["Session2"].ToString());

            // example
            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(CS))
            //{
            //    SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        // Using integral indexer to retrieve Id column value
            //        Response.Write("Id = " + rdr[0].ToString() + " ");
            //        // Using string indexer to retrieve Id column value
            //        Response.Write("Name = " + rdr["Name"].ToString());
            //    }
            //}

    }
















    public interface IEmployee
    {
        void EmployeeMethod();
    }

    public interface ICustomer
    {
        void CustomerMethod();

    }


}