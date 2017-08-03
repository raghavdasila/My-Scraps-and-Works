using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.IO;
using System.Text;
public partial class _Default : Page
{
    string c_user, c_pass;
    string global_authentication_key = "RaghavendraSinghDasilaRA1411003020186";
    string global_user_authentication_key1 = "SomeLongRandomTextToServeAsSaltForUser1";
    string global_user_authentication_key2 = "SomeLongRandomTextToServeAsSaltForUser2";
    string global_user_authentication_key3 = "SomeLongRandomTextToServeAsSaltForUser3";
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Master.FindControl("lgout").Visible = false;
        Page.Master.FindControl("lgin").Visible = false;
        Page.Master.FindControl("indx").Visible = false;
    }
    protected void Authenticate(object sender, EventArgs e)
    {
        
        c_user = login.Text;
        c_pass = pass.Text;
        if (login2.Text != "")
        {
            c_user = login2.Text;
            c_pass = pass2.Text;
        }
        string pass_string;
        switch (c_user)
        {
            case "admin":
                pass_string = "pass";
                break;
            case "admin2":
                pass_string = "pass2";
                break;
            case "admin3":
                pass_string = "pass3";
                break;
            default:
                pass_string = "pass";
                break;
        }
        var dir = Server.MapPath("~\\App_Data");
        var file = Path.Combine(dir, pass_string);
        string _file = File.ReadAllText(file);
        switch (c_user)
        {
            //Administrator
            case "admin":
                if (hash_text(c_pass) == _file)
                {
                    dir = Server.MapPath("~\\App_Data");
                    string authkey =global_authentication_key + DateTime.Now.ToString();
                    file = Path.Combine(dir, "user-entry");
                    File.WriteAllText(file,"ad"+DateTime.Now.ToString());
                    file = Path.Combine(dir, "auth");
                    File.WriteAllText(file, hash_text(authkey));
                    file = Path.Combine(dir, "user");
                    File.WriteAllText(file, hash_text(global_user_authentication_key1));
                    Server.Transfer("Index.aspx");
                }
                else
                    Stat.Text = "Incorrect Password";
                if(login2.Text!="")
                {
                    Stat2.Text = "Incorrect Password";
                }
                break;
            //Manager..or someone like a manager
            case "admin2":
                if (hash_text(c_pass) == _file)
                {
                    dir = Server.MapPath("~\\App_Data");
                    string authkey = global_authentication_key + DateTime.Now.ToString();
                    file = Path.Combine(dir, "user-entry");
                    File.WriteAllText(file, "ad" + DateTime.Now.ToString());
                    file = Path.Combine(dir, "auth");
                    File.WriteAllText(file, hash_text(authkey));
                    file = Path.Combine(dir, "user");
                    File.WriteAllText(file, hash_text(global_user_authentication_key2));
                    Server.Transfer("Index.aspx");
                }
                else
                    Stat.Text = "Incorrect Password";
                if (login2.Text != "")
                {
                    Stat2.Text = "Incorrect Password";
                }
                break;
            case "admin3":
                if (hash_text(c_pass) == _file)
                {
                    dir = Server.MapPath("~\\App_Data");
                    string authkey = global_authentication_key + DateTime.Now.ToString();
                    file = Path.Combine(dir, "user-entry");
                    File.WriteAllText(file, "ad" + DateTime.Now.ToString());
                    file = Path.Combine(dir, "auth");
                    File.WriteAllText(file, hash_text(authkey));
                    file = Path.Combine(dir, "user");
                    File.WriteAllText(file, hash_text(global_user_authentication_key3));
                    Server.Transfer("Index.aspx");
                }
                else
                    Stat.Text = "Incorrect Password";
                break;
            default:
                Stat.Text = "Incorrect Credentials";
                if (login2.Text != "")
                {
                    Stat2.Text = "Incorrect Password";
                }
                break;
        }
    }
    protected string hash_text(string pash)
    {
        SHA512 hashed = new SHA512Managed();
        byte[] htxt = hashed.ComputeHash(Encoding.UTF8.GetBytes(pash));
        return Convert.ToBase64String(htxt);
    }
}