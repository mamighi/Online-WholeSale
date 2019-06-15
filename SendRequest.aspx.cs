using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SendRequest : System.Web.UI.Page
{
    string img, company, name, cat;
    protected void Page_Load(object sender, EventArgs e)
    {
        img = Request.QueryString["image"];
        company = Request.QueryString["company"];
        name = Request.QueryString["name"];
        cat = Request.QueryString["cat"];

        Image1.ImageUrl = img;
        Label1.Text = "Product Name: " + name;
        Label2.Text = "Prodcut Category: " + cat;
        Label3.Text = "Seller Company: " + company;
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        DataManager.request req = new DataManager.request();
        req.company_name = company;
        req.name = name;
        req.text = TEXT.Text;
        req.user = Session["USER"].ToString().Trim();
        if (RadioButton1.Checked)
            req.type = "REQUEST";
        else
            req.type = "FEEDBACK";
        TaskManager ts = new TaskManager();
        ts.addRequest(req);
        Response.Redirect("Products_C.aspx");
    }
}