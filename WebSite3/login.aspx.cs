using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        DataSetTableAdapters.userInfoTableAdapter adapter = new DataSetTableAdapters.userInfoTableAdapter();

        DataSet.userInfoDataTable table = adapter.GetData();

        foreach (DataSet.userInfoRow row in table)
        {
            Response.Write(row[1] + "</br>");
        }

    }
    
}