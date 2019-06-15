using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditUser : System.Web.UI.Page
{
    List<DataManager.user> users;
    List<DataManager.costumer> costumers;
    TaskManager ts = new TaskManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (RadioButton1.Checked)
            Panel1.Visible = false;
        users = ts.getUsers();
        costumers = ts.getCompaniesDetails();
        if(!IsPostBack)
        {
            loadDropDown();

        }

    }
    public void loadDropDown()
    {
        UserName.Items.Clear();
        foreach(DataManager.user temp in users)
        {
            if (RadioButton1.Checked && temp.type.Trim().Equals("STAFF"))
                UserName.Items.Add(temp.user_name);
            if(RadioButton2.Checked && temp.type.Trim().Equals("COSTUMER"))
                UserName.Items.Add(temp.user_name);
        }
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        if (RadioButton2.Checked)
        {
            Panel1.Visible = true;
            loadDropDown();
            loadUserDetails();

        }
        else
            Panel1.Visible = false;
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (RadioButton2.Checked)
            Panel1.Visible = true;
        else
        {
            Panel1.Visible = false;
            loadDropDown();
            loadUserDetails();
        }
    }
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        DataManager.user updateUser = new DataManager.user();
        updateUser.user_name = UserName.SelectedItem.ToString();
        updateUser.password = Password.Text;
        updateUser.email = TextBox2.Text;
        if (RadioButton1.Checked)
            updateUser.type = "STAFF";
        else
            updateUser.type = "COSTUMER";
        ts.updateUser(updateUser);
        if(RadioButton2.Checked)
        {
            DataManager.costumer updateCost = new DataManager.costumer();
            updateCost.name = Name1.Text;
            updateCost.phone = phno.Text;
            updateCost.website = site.Text;
            if (FileUpload1.FileName != null && FileUpload1.FileName.Length>0)
            {
                string folderPath = Server.MapPath("~/CompanyLogo/");
                FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
                updateCost.img = "CompanyLogo/" + Path.GetFileName(FileUpload1.FileName);
            }
            else
                updateCost.img = Image1.ImageUrl;
            ts.updateCostumer(updateCost);
            Response.Redirect("AdminHome.aspx");
        }
    }
    protected void UserName_SelectedIndexChanged(object sender, EventArgs e)
    {
        loadUserDetails();
    }
    public void loadUserDetails()
    {
        try
        {
            DataManager.user selectedUsers = new DataManager.user();
            foreach (DataManager.user temp in users)
                if (temp.user_name.Equals(UserName.SelectedItem.ToString()))
                    selectedUsers = temp;
            Password.Text = selectedUsers.password;
            ConfirmPassword.Text = selectedUsers.password;
            TextBox2.Text = selectedUsers.email;
            if (selectedUsers.type.Trim().Equals("STAFF"))
                return;
            DataManager.costumer selectetCostumer = new DataManager.costumer();
            foreach (DataManager.costumer temp in costumers)
                if (temp.user_name.Equals(selectedUsers.user_name))
                    selectetCostumer = temp;
            Address.Text = selectetCostumer.address;
            phno.Text = selectetCostumer.phone;
            site.Text = selectetCostumer.website;
            Name1.Text = selectetCostumer.name;
            Image1.ImageUrl = selectetCostumer.img;
        }
        catch (Exception) { }
    }
    protected void Delete_Click(object sender, EventArgs e)
    {
        ts.deleteUser(UserName.Text);
        if (RadioButton2.Checked)
            ts.deleteCostumer(UserName.Text);
        Response.Redirect("AdminHome.aspx");
    }
}