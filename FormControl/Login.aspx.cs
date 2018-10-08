using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Security.Cryptography; 

public partial class Login : System.Web.UI.Page
{

    
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (IsPostBack)
        {
            string name = this.Request["name"];
            string password = this.Request["password"];

            


            DataSetTableAdapters.registrationTableAdapter adapter = new DataSetTableAdapters.registrationTableAdapter();

            DataSet.registrationDataTable table = adapter.GetData();



            foreach (DataSet.registrationRow row in table)
            {
               if (name.Equals(row[1]) && Equals(row[2]))
                {
                    Session["name"] = row[1]; 
                    
                }  
            }

            if (Convert.ToString( Session["name"])==name)
            {
                Response.Redirect("Home.aspx"); 
            }
            else
            {
                Response.Write("worng Credentials");
            }

            

        }

        

    }
}