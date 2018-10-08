using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class forget : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack)
        {
            string isValid = "";
            string name = this.Request["name"];

            DataSetTableAdapters.registrationTableAdapter adapter = new DataSetTableAdapters.registrationTableAdapter();

            DataSet.registrationDataTable table = adapter.GetData();

            foreach (DataSet.registrationRow row in table)
            {
                if (name.Equals(row[1]) )
                {
                    isValid = "valid";

                }
            }

            if (isValid=="valid")
            {
                Response.Redirect("passwordReset.aspx");
            }
            else
            {
                Response.Write("Not a Valid User ");
            }



        }
        

    }
}