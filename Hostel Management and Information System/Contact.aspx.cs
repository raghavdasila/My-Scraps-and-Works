using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class Contact : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var dir = Server.MapPath("~\\App_Data");
        var file = Path.Combine(dir, "user-entry");
        var _file = File.ReadAllText(file);
        if (_file == "")
        {
            Page.Master.FindControl("lgout").Visible = false;
            Page.Master.FindControl("indx").Visible = false;
            Page.Master.FindControl("lgin").Visible = true;
        }
        else
            Page.Master.FindControl("hm").Visible = false;
    }
}