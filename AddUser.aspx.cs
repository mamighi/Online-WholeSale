using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        DataManager.user user = new DataManager.user();
        user.user_name = UserName.Text;
        user.password = Password.Text;
        user.email = TextBox2.Text;
        if (RadioButton1.Checked)
            user.type = "STAFF";
        else
            user.type = "COSTUMER";
        TaskManager ts = new TaskManager();
        if(ts.registerUser(user))
        {
            if (RadioButton1.Checked)
                Response.Redirect("AdminHome.aspx");
            else
            {
                Session["Costumer"]=user.user_name;
                Response.Redirect("AddCostumer.aspx");
            }
        }
        else
            ErrorMessage.Text = "The Username Already Exist";
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        if (RadioButton2.Checked)
            Register.Text = "Next";
        else
            Register.Text = "Register";
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (RadioButton1.Checked)
            Register.Text = "Register";
        else
            Register.Text = "Next";
    }
}