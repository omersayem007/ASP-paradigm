using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class passwordReset : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack)
        {
            
            string password = this.Request["newPassword"];

            DataSetTableAdapters.registrationTableAdapter adapter = new DataSetTableAdapters.registrationTableAdapter();

           

            adapter.Update(data)


        }

    }
}