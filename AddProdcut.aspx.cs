using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddProdcut : System.Web.UI.Page
{
    TaskManager ts = new TaskManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        DropDownList1.Items.Clear();
        List<string> companies = ts.getCompanies();
        foreach (string company in companies)
            DropDownList1.Items.Add(company);
    }
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        string folderPath = Server.MapPath("~/ProdcutsImage/");
        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);
        FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
        DataManager.product product = new DataManager.product();
        product.company = DropDownList1.SelectedItem.ToString();
        product.category = Category.Text;
        product.name = Name.Text;
        product.img = "ProdcutsImage/" + Path.GetFileName(FileUpload1.FileName);
        ts.addProdcut(product);
        
    }
}