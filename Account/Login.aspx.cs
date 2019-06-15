using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using WebSite10;

public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user password
                TaskManager ts = new TaskManager();
                string userType = ts.login(UserName.Text, Password.Text);
                userType=userType.Trim();
                if (!userType.Equals("NULL"))
                {
                    Session["USER"] = UserName.Text;
                    if(userType.Equals("ADMIN"))
                    {
                        Session["UML"] = "ADMIN";
                        Response.Redirect("../AdminHome.aspx");
                    }
                    else if(userType.Equals("CLIENT"))
                    {
                        Session["UML"] = "CLIENT";
                        Response.Redirect("../Default_C.aspx");
                    }
                    else if (userType.Equals("COSTUMER"))
                    {
                        Session["UML"] = "COSTUMER";
                        Response.Redirect("../CheckRequest.aspx");
                    }
                    else if (userType.Equals("STAFF"))
                    {
                        Session["UML"] = "STAFF";
                        Response.Redirect("../StaffHome.aspx");
                    }
                   
                }
                else
                {
                    FailureText.Text = "Invalid username or password.";
                    ErrorMessage.Visible = true;
                }
            }
        }
}