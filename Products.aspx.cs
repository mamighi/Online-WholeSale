using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Products : System.Web.UI.Page
{
    List<DataManager.product> prodcuts;
    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> categories = new List<string>();
        TaskManager ts = new TaskManager();
        prodcuts = ts.getProducts();
        foreach(DataManager.product temp in prodcuts)
        {
            if(!categories.Contains(temp.category))
                categories.Add(temp.category);
        }
       
        if (!IsPostBack)
        {
            
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("All");
            foreach (string temp in categories)
                DropDownList1.Items.Add(temp);
            loadProducts();
        }
    }
    public void loadProducts()
    {
        List<DataManager.product> proToShow = new List<DataManager.product>();
        if (DropDownList1.SelectedItem.ToString().Equals("All"))
            proToShow = prodcuts;
        else
        {
            foreach (DataManager.product temp in prodcuts)
            {
                if (temp.category.Equals(DropDownList1.SelectedItem.ToString()))
                    proToShow.Add(temp);
            }
        }
        for (int i = 0; i < proToShow.Count; i++)
        {
            TableRow row = new TableRow();
           
            for (int j = 0; j < 3; j++)
            {
                if (i == proToShow.Count) break;
                TableCell cell = new TableCell();
                ImageButton image = new ImageButton();
                image.Height = image.Width = 150;
                image.ImageUrl = proToShow[i].img;
                cell.Width = 150;
                cell.HorizontalAlign = HorizontalAlign.Center;
                image.PostBackUrl="~/Account/Login.aspx";
                Label name = new Label();
                name.Width = 150;
                name.Text = proToShow[i].name;
                Label company = new Label();
                company.Width = 150;
                company.Text = proToShow[i].company;
                Label cat = new Label();
                cat.Text = proToShow[i].category;
                cat.Width = 150;
               
                cell.Controls.Add(image);
                cell.Controls.Add(name);
                cell.Controls.Add(company);
                cell.Controls.Add(cat);
                row.Cells.Add(cell);
                i++;
            }
            Table1.Rows.Add(row);
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        loadProducts();

    }
}