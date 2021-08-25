using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  only if there is nothing in the Session variable
            //  
            if (Session["TokenQueue"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();

                //  web application work on stateless protocol
                //  so it must be stored in a session variable or a database, xml etc
                // 
                //  the key is called TokenQueue
                // 
                Session["TokenQueue"] = queueTokens;
            }
        }

        //  when the button is clicked retrieve the session variable
        //  then compute the next session numbers to add to the ListBox
        //
        protected void btnPrint_Click(object sender, EventArgs e)
        {

            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];

            //  first tell the user how many Customers are in the queue before
            //  them
            //lblStatus



            tokenQueue.Count();
        }
    }
}