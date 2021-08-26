using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// comment with better understanding of ASP.NET/ASP.NET webforms
/// 
/// </summary>
namespace WebApplication1
{
    public class BasePage : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            if(Session["URLStack"] == null)
            {
                Stack<string> urlstack = new Stack<string>();
                Session["URLStack"] = urlstack;
            }

            if(Request.UrlReferrer != null && !this.Page.IsPostBack && 
                Session["BackButtonCLicked"] == null)
            {
                Stack<string> urlStack = (Stack<string>)Session["URLStack"];
                urlStack.Push(Request.UrlReferrer.AbsoluteUri);
            }

            if(Session["BackButtonClicked"] != null)
            {
                Session["BackButtonClicked"] = null;
            }


        }
    }
}