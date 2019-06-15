using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowRequest : System.Web.UI.Page
{
    List<DataManager.request> req;
    TaskManager ts = new TaskManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        req = ts.getRequests();
        string userName = Session["USER"].ToString().Trim();
        string company = ts.getCompanyName(userName);

        Table1.Rows.Clear();
        TableRow row_ = new TableRow();
        row_.BackColor = System.Drawing.Color.Black;
        row_.ForeColor = System.Drawing.Color.White;
        row_.HorizontalAlign = HorizontalAlign.Center;
        row_.Height = 30;

        TableCell name_ = new TableCell();
       
        name_.Text = "Product Name";
        TableCell type_ = new TableCell();
        type_.Text = "Req. Type";
        TableCell text_ = new TableCell();
        text_.Text = "Request";
        TableCell response_ = new TableCell();
        response_.Text = "Response";
        row_.Cells.Add(name_);
        row_.Cells.Add(type_);
        row_.Cells.Add(text_);
        row_.Cells.Add(response_);
        Table1.Rows.Add(row_);
        foreach (DataManager.request temp in req)
        {
            if (temp.company_name.Equals(company))
            {
                if (RadioButton1.Checked && temp.response != null)
                    continue;
                TableRow row = new TableRow();
                row.HorizontalAlign = HorizontalAlign.Center;
                row.Height = 30;
                TableCell name = new TableCell();
                name.Text = temp.name;
                TableCell type = new TableCell();
                type.Text = temp.type;
                TableCell text = new TableCell();
                text.Text = temp.text;
                TableCell response = new TableCell();
                if(temp.response==null)
                {
                    HyperLink res = new HyperLink();
                    res.Text = "Response";
                    res.CssClass = "btn btn-default";
                    res.NavigateUrl = "Response.aspx?id="+temp.id+"&txt="+temp.text;
                    response.Controls.Add(res);
                }
                else
                    response.Text = temp.response;
                row.Cells.Add(name);
                row.Cells.Add(type);
                row.Cells.Add(text);
                row.Cells.Add(response);
                Table1.Rows.Add(row);

            }
        }
    }
}