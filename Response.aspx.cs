using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Response : System.Web.UI.Page
{
    int id;
    string msg;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Int32.Parse(Request.QueryString["id"]);
        msg = Request.QueryString["txt"];
        Label1.Text = msg;
    }
    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        TaskManager ts = new TaskManager();
        string res = UserName.Text;
        ts.addResponce(id, res);
        Response.Redirect("CheckRequest.aspx");

    }
}