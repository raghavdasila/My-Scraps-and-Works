using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using System.IO;

public partial class Default5 : System.Web.UI.Page
{
    void authentication_code()
    {
        string global_authentication_key = "RaghavendraSinghDasilaRA1411003020186";
        var dir = Server.MapPath("~\\App_Data");
        string authkey = global_authentication_key;
        dir = Server.MapPath("~\\App_Data");
        var file = Path.Combine(dir, "user-entry");
        string entry = File.ReadAllText(file);
        string entrytime = entry;
        if (entry.Length > 0) entrytime = entry.Substring(2);
        file = Path.Combine(dir, "auth");
        string authcode = File.ReadAllText(file);
        string auth = global_authentication_key + entrytime;
        SHA512 hashed = new SHA512Managed();
        byte[] htxt = hashed.ComputeHash(Encoding.UTF8.GetBytes(auth));
        string authchk = Convert.ToBase64String(htxt);
        if (authchk != authcode)
        {
            dir = Server.MapPath("~\\App_Data");
            file = Path.Combine(dir, "report");
            File.WriteAllText(file, "Unauthorised Access Detected.\n Please Login Again.");
            Server.Transfer("Report.aspx");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Master.FindControl("hm").Visible = false;
        Page.Master.FindControl("lgin").Visible = false;
        authentication_code();
    }
    protected void populate()
    {
  
    }
}