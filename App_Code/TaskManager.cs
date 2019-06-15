using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TaskManager
/// </summary>
public class TaskManager
{
    SqlConnection con;
	public TaskManager()
	{
        con = new SqlConnection("Data Source=Mohammad\\mohammad;Initial Catalog=companyManager;Integrated Security=True;Pooling=False");
	}
    public string login(string user_name,string password)
    {
        string uml;
        string command = "SELECT * FROM [User] WHERE user_name='" + user_name + "' AND password='" + password + "'";
        try
        {
            SqlCommand com = new SqlCommand(command, con);
            SqlDataReader reader;
            con.Open();
            reader = com.ExecuteReader();
            if (reader.Read())
 
                uml = reader.GetString(3).ToString(); 
            else
                uml = "NULL";
            reader.Close();
        }
        catch (Exception ex)
        {
            uml = "NULL";
        }
        finally
        {
            con.Close();
        }
        return uml;
    }
    public bool registerUser(DataManager.user user)
    {
        string command = "SELECT * FROM User WHERE user_name='" + user.user_name + "'";
        try
        {
            SqlCommand com = new SqlCommand(command, con);
            SqlDataReader reader;
            con.Open();
            reader = com.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return false;

            }
            reader.Close();
        }
        catch (Exception ex)
        {
        }

        command = "INSERT INTO [User] (user_name,password,email,type) VALUES('" + user.user_name + "','" + user.password + "','" + user.email + "','" + user.type + "')";
       // con.Open();
        SqlCommand com2 = new SqlCommand(command, con);

        com2.ExecuteNonQuery();
        con.Close();

        return true;
    }
    public void updateUser(DataManager.user user)
    {
        string command = "UPDATE [User] SET password='" + user.password + "',email='" + user.email + "' WHERE user_name='" + user.user_name + "'";
        SqlCommand com2 = new SqlCommand(command, con);
        con.Open();
        com2.ExecuteNonQuery();
        con.Close();
    }
    public void updateCostumer(DataManager.costumer costumer)
    {
        string command = "UPDATE [Costumer] SET address='" + costumer.address + "',phone_number='" + costumer.phone + "',logo='" + costumer.img + "',website='" + costumer.website + "' WHERE user_name='" + costumer.user_name + "'";
        SqlCommand com2 = new SqlCommand(command, con);
        con.Open();
        com2.ExecuteNonQuery();
        con.Close();
    }
    public bool addCostumer(DataManager.costumer costumer)
    {
        string command = "INSERT INTO Costumer (user_name,company_name,address,phone_number,logo,website) VALUES('" + costumer.user_name + "','" + costumer.name + "','" + costumer.address + "','" + costumer.phone + "','"+costumer.img+"','"+costumer.website+"')";
        SqlCommand com2 = new SqlCommand(command, con);
        con.Open();
        com2.ExecuteNonQuery();
        con.Close();
        return true;
    }
    public List<string> getCompanies()
    {
        List<string> retVal = new List<string>();
        string command = "SELECT company_name FROM Costumer";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
            retVal.Add(reader.GetString(0));
        reader.Close();
        con.Close();
        return retVal;
    }
    public void deleteUser(string userName)
    {
        string command = "DELETE FROM [User] WHERE user_name='"+userName+"'";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
    }
    public void deleteCostumer(string userName)
    {
        string command = "DELETE FROM [Costumer] WHERE user_name='" + userName + "'";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
    }
    public List<DataManager.user> getUsers()
    {
        List<DataManager.user> retVal = new List<DataManager.user>();
        string command = "SELECT * FROM [User]";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
        {
            DataManager.user temp = new DataManager.user();
            temp.user_name = reader.GetString(0);
            temp.password = reader.GetString(1);
            temp.email = reader.GetString(2);
            temp.type = reader.GetString(3);
            retVal.Add(temp);
        }
        reader.Close();
        con.Close();
        return retVal;
    }
    public string getCompanyName(string userName)
    {
        string retVal="";
        string command = "SELECT company_name From Costumer WHERE user_name='" + userName + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if (reader.Read())
            retVal = reader.GetString(0);
        reader.Close();
        con.Close();
        return retVal;
    }
    public List<DataManager.costumer> getCompaniesDetails()
    {
        List<DataManager.costumer> retVal = new List<DataManager.costumer>();
        string command = "SELECT * FROM Costumer";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
        {
            DataManager.costumer temp = new DataManager.costumer();
            temp.user_name = reader.GetString(0);
            temp.name = reader.GetString(1);
            temp.address = reader.GetString(2);
            temp.phone = reader.GetString(3);
            temp.img = reader.GetString(4);
            try
            {
                temp.website = reader.GetString(5);
            }catch(Exception){}
            retVal.Add(temp);
        }
        reader.Close();
        con.Close();
        return retVal;
    }
    public List<DataManager.product> getProducts()
    {
        List<DataManager.product> retVal = new List<DataManager.product>();
        string command = "SELECT * FROM Product";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
        {
            DataManager.product temp = new DataManager.product();
            temp.company = reader.GetString(0);
            temp.category = reader.GetString(1);
            temp.name = reader.GetString(2);
            temp.img = reader.GetString(3);
            retVal.Add(temp);
        }
        reader.Close();
        con.Close();
        return retVal;
    }
    public bool addProdcut(DataManager.product prodcut)
    {
        string command = "INSERT INTO Product (company_name,category,name,image) VALUES('" + prodcut.company + "','" + prodcut.category + "','" + prodcut.name + "','" + prodcut.img + "')";
        con.Open();
        SqlCommand com2 = new SqlCommand(command, con);
        com2.ExecuteNonQuery();
        con.Close();
        return true;
    }
    public void addRequest(DataManager.request req)
    {
        string command = "INSERT INTO Req (company_name,Name,Type,Text,User_name) VALUES('" + req.company_name + "','" + req.name + "','" + req.type + "','" + req.text + "','"+req.user+"')";
        con.Open();
        SqlCommand com2 = new SqlCommand(command, con);
        com2.ExecuteNonQuery();
        con.Close();
    }
    public List<DataManager.request> getRequests()
    {
        List<DataManager.request> retVal= new List<DataManager.request>();
        string command= "SELECT * FROM Req";
        
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
        {
            DataManager.request temp = new DataManager.request();
            temp.id = reader.GetInt32(0);
            temp.company_name = reader.GetString(1);
            temp.name = reader.GetString(2);
            temp.type = reader.GetString(3);
            temp.text = reader.GetString(4);
            try
            {
                temp.response = reader.GetString(5);
            }
            catch (Exception) { }
            temp.user = reader.GetString(6);
            retVal.Add(temp);
        }
        reader.Close();
        con.Close();
        return retVal;
    }
    public void deleteProduct(DataManager.product prod)
    {
        string command = "DELETE FROM Product WHERE company_name='" + prod.company + "' AND name='" + prod.name + "'";
        con.Open();
        SqlCommand com2 = new SqlCommand(command, con);
        com2.ExecuteNonQuery();
        con.Close();
    }
    public void updateProduct(DataManager.product prod,string name)
    {
        string command = "UPDATE [Product] SET category='" + prod.category + "', name='" + prod.name + "',image='" + prod.img + "' WHERE company_name='" + prod.company + "' AND name='" + name + "'";
        con.Open();
        SqlCommand com2 = new SqlCommand(command, con);
        com2.ExecuteNonQuery();
        con.Close();
    }
    public void addResponce(int id, string response)
    {
        string command = "UPDATE Req Set Response='" + response + "' WHERE ID=" + id + "";
        con.Open();
        SqlCommand com2 = new SqlCommand(command, con);
        com2.ExecuteNonQuery();
        con.Close();
    }
   
}