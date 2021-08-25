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

        protected void btnPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];

            //  first tell the user how many Customers are in the queue
            //  before them
            // 
            lblStatus.Text = "There are " + tokenQueue.Count.ToString()
                + " customers before you in the queue";

            //  check if there are no items in the queue i.e no token number have been
            //  issued yet, null the first time so store 0 in the session variable
            //  
            if (Session["LastTokenNumberIssued"] == null)
            {
                Session["LastTokenNumberIssued"] = 0;
            }

            //  the next token number will be incremeted by 1 when clicked
            //
            int nextTokenNumberToBeIssued =
                (int)Session["LastTokenNumberIssued"] + 1;

            //  store back in the Session variable so next time it can be
            //  computed
            //
            // add to the tokenQueue with Enqueue 
            //
            Session["LastTokenNumberIssued"] = nextTokenNumberToBeIssued;
            tokenQueue.Enqueue(nextTokenNumberToBeIssued);

            AddTokensToListBox(tokenQueue);

        }

        //  if there are items within the ListBox clear them
        //  then add them to the ListBox
        //
        private void AddTokensToListBox(Queue<int> tokenQueue)
        {
            listTokens.Items.Clear();
            foreach (int token in tokenQueue)
            {
                listTokens.Items.Add(token.ToString());
            }
        }

        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];

            //  if 0, there are no customers in the Queue
            //
            if (tokenQueue.Count == 0)
            {
                txtCounter1.Text = "No Customers in the Queue";
            }
            else
            {
                //  if there are items in the Queue, Dequeue the item i.e
                //  remove the item in the queue and store it
                //
                int tokenNumberToBeServed = tokenQueue.Dequeue();
                txtCounter1.Text = tokenNumberToBeServed.ToString();
                txtDisplay.Text = " Token number : " + tokenNumberToBeServed.ToString() +
                    " Please go to counter 1";

                //  remove the item from the ListBox
                //  
                AddTokensToListBox(tokenQueue);
            }

        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServeNextCusomer(txtCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServeNextCusomer(txtCounter3, 3);
        }

        private void ServeNextCusomer(TextBox textbox, int counterNumber)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];

            if (tokenQueue.Count == 0)
            {
                txtCounter1.Text = "No Customers in the Queue";
            }
            else
            {
                int tokenNumberToBeServed = tokenQueue.Dequeue();
                textbox.Text = tokenNumberToBeServed.ToString();
                textbox.Text = " Token number : " + tokenNumberToBeServed.ToString() +
                    " Please go to counter " + counterNumber;


                AddTokensToListBox(tokenQueue);
            }
        }
    }



}