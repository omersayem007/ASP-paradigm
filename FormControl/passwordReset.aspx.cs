using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

public partial class passwordReset : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack)
        {
            
            string password = this.Request["newPassword"];

            DataSetTableAdapters.registrationTableAdapter adapter = new DataSetTableAdapters.registrationTableAdapter();

            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {

                strBuilder.Append(result[i].ToString("x2"));
            }

            string Updatedpassword = strBuilder.ToString();


            adapter.UpdateUser(Convert.ToString( Session["name"]),Updatedpassword);



           // adapter.Update(data);


        }

    }
}