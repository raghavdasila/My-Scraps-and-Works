using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Master.FindControl("indx").Visible = false;
        Page.Master.FindControl("lgout").Visible = false;
        var dir = Server.MapPath("~\\App_Data");
        var file = Path.Combine(dir, "user-entry");
        File.WriteAllText(file, "");
        file = Path.Combine(dir, "auth");
        File.WriteAllText(file, "");
    }
}