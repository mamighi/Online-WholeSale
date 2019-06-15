using System;
using System.Collections.Generic;
using System.IO;
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
        if (!IsPostBack)
        {
            Image1.ImageUrl = img;
            Label1.Text = "Seller Company: " + company;
            Category.Text = cat;
            Name.Text = name;
        }
    }
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        DataManager.product updateProd = new DataManager.product();
        updateProd.company = company;
        updateProd.name = Name.Text;
        updateProd.category = Category.Text;
        if (FileUpload1.FileName != null && FileUpload1.FileName.Length>0)
        {
            string folderPath = Server.MapPath("~/ProdcutsImage/");
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
            updateProd.img = "ProdcutsImage/" + Path.GetFileName(FileUpload1.FileName);
        }
        else
            updateProd.img = Image1.ImageUrl;
        TaskManager ts = new TaskManager();
        ts.updateProduct(updateProd, name);

        Response.Redirect("Products_A.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataManager.product deleteProd = new DataManager.product();
        deleteProd.company = company;
        deleteProd.name = name;
        TaskManager ts = new TaskManager();
        ts.deleteProduct(deleteProd);
        Response.Redirect("Products_A.aspx");
    }
}