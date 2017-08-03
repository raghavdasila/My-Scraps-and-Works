using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using System.IO;
public partial class Default2 : System.Web.UI.Page
{
    int user_code;
    string global_user_authentication_key1 = "SomeLongRandomTextToServeAsSaltForUser1";
    string global_user_authentication_key2 = "SomeLongRandomTextToServeAsSaltForUser2";
    string global_user_authentication_key3 = "SomeLongRandomTextToServeAsSaltForUser3";
    void user_authentication()
    {
        var dir = Server.MapPath("~\\App_Data");
        var file = Path.Combine(dir, "user");
        string _file=File.ReadAllText(file);
        SHA512 hashed = new SHA512Managed();
        if (_file == Convert.ToBase64String(hashed.ComputeHash(Encoding.UTF8.GetBytes(global_user_authentication_key1))))
            user_code = 1;
        else if (_file == Convert.ToBase64String(hashed.ComputeHash(Encoding.UTF8.GetBytes(global_user_authentication_key2))))
            user_code = 2;
        else if (_file == Convert.ToBase64String(hashed.ComputeHash(Encoding.UTF8.GetBytes(global_user_authentication_key3))))
            user_code = 3;
    }
   void authentication_code()
    {
        string global_authentication_key = "RaghavendraSinghDasilaRA1411003020186";
        var dir = Server.MapPath("~\\App_Data");
        string authkey = global_authentication_key;
        dir = Server.MapPath("~\\App_Data");
        var file = Path.Combine(dir, "user-entry");
        string entry = File.ReadAllText(file);
        string entrytime=entry;
        if (entry.Length>0) entrytime=entry.Substring(2);
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
        user_authentication();
        if(user_code==1)
        {
            Button2.Visible = false;
            Button1.Text = "View Rooms";
            Button3.Text = "View Students";
        }
        if(user_code==2)
        {
            Button1.Visible = false;
        }
        passT.Visible=true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        chngpswrd.Visible = false;
        Server.Transfer("Admission.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        chngpswrd.Visible = false;
        Server.Transfer("Rooms.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        chngpswrd.Visible = false;
        Server.Transfer("Students.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        chngpswrd.Visible = true;
    }

    protected void auth_Click(object sender, EventArgs e)
    {
        string op = hash_text(opass.Text);
        var dir = Server.MapPath("~\\App_Data");
        string passfile="pass";
        if(user_code==1)
            passfile="pass";
        else if (user_code == 2)
            passfile = "pass2";
        var file = Path.Combine(dir, passfile);
        string cp = File.ReadAllText(file);
        if (cp!=op)
        {
            stat.Visible = true;
            stat.Text = "Incorrect Password";
        }
        else
        {
            if(npass.Text=="")
            {
                stat.Visible = true;
                stat.Text = "Password Cannot Be Blank";
            }
            else if (npass.Text.Equals(npass2.Text))
            {
                string np = hash_text(npass.Text);
                File.WriteAllText(file, np);
                stat.Visible = true;
                stat.Text = "Password Changed Successfully";
                passT.Visible = false;
            }
            else
            {
                stat.Visible = true;
                stat.Text = "New Passwords Do Not Match";
            }
        }
    }

    protected string hash_text(string pash)
    {
        SHA512 hashed = new SHA512Managed();
        byte[] htxt = hashed.ComputeHash(Encoding.UTF8.GetBytes(pash));
        return Convert.ToBase64String(htxt);
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Server.Transfer("Default3.aspx");
    }
}