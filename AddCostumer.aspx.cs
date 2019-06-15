using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCostumer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        string folderPath = Server.MapPath("~/CompanyLogo/");
        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);
        FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
        DataManager.costumer costumer = new DataManager.costumer();
        costumer.name = UserName.Text;
        costumer.address = Address.Text;
        costumer.phone = phno.Text;
        costumer.img = "CompanyLogo/" + Path.GetFileName(FileUpload1.FileName);
        costumer.user_name = Session["Costumer"].ToString().Trim();
        costumer.website = site.Text;
        TaskManager ts = new TaskManager();
        ts.addCostumer(costumer);
        Response.Redirect("AdminHome.aspx");
    }
}