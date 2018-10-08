using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack)
        {
            DataSetTableAdapters.registrationTableAdapter adapter = new DataSetTableAdapters.registrationTableAdapter();

            string name = this.Request["name"];
            string password = this.Request["password"];
            adapter.Insert(name, password);

        }
       

    }
}