using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        loadCompanies();
    }
    public void loadCompanies()
    {
        TaskManager ts = new TaskManager();
        List<DataManager.costumer> costumer = ts.getCompaniesDetails();
        for (int i = 0; i < costumer.Count; i++)
        {
            TableRow row = new TableRow();

            for (int j = 0; j < 3; j++)
            {
                if (i == costumer.Count) break;
                TableCell cell = new TableCell();
                ImageButton image = new ImageButton();
                image.Height = image.Width = 150;
                image.ImageUrl = costumer[i].img;
                cell.Width = 150;
                cell.HorizontalAlign = HorizontalAlign.Left;
                cell.HorizontalAlign = HorizontalAlign.Center;
                image.PostBackUrl=costumer[i].website;
                cell.Controls.Add(image);
                row.Cells.Add(cell);
                i++;
            }
            Table1.Rows.Add(row);
        }
    }
}