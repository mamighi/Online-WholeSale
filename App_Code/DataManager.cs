using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataManager
/// </summary>
public class DataManager
{
	public DataManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public class user
    {
        public string user_name, password, email, type;
    }
    public class costumer
    {
        public string user_name, name, address, phone;
        public string img,website;
    }
    public class product
    {
        public string company,category, name;
        public string img;
    }
    public class request
    {
        public int id;
        public string company_name, name, type, text, response,user;
    }
}