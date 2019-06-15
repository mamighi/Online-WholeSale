using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using WebSite10;

public partial class Account_Register : Page
{
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        TaskManager ts = new TaskManager();
        DataManager.user user = new DataManager.user();
        user.user_name = UserName.Text;
        user.password = Password.Text;
        user.email = TextBox2.Text;
        user.type = "CLIENT";
        if (ts.registerUser(user))
        {
         
        }
        else
        {
            ErrorMessage.Text = "The Username Already Exist";
        }
    }
}