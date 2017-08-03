using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.RegularExpressions;
public partial class Default6 : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Master.FindControl("hm").Visible = false;
        cnfrm.Visible = true;
        var dir = Server.MapPath("~\\App_Data");
        var file = Path.Combine(dir, "report");
        var _file = File.ReadAllText(file);
        Rep.Text= _file;
        if (Rep.Text == "Unauthorised Access Detected.\n Please Login Again.")
        {
            Page.Master.FindControl("hm").Visible = true;
            Page.Master.FindControl("indx").Visible=false;
            Page.Master.FindControl("lgin").Visible = true;
            cnfrm.Visible = false;
        }
        else if(Rep.Text== "Forbidden Resource.\n You are not authorised to access this resource")
        {
            cnfrm.Visible = false;
        }
        file = Path.Combine(dir, "data");
        _file = File.ReadAllText(file);
        int a=0,b=0,c=0;
        int z = 0;
        string x;
        string[] data = new string[20];
        for (int i=0;(i<_file.Length);i++)
        {
            if(_file.ElementAt(i) =='$') 
            {
                c++;
                a = b;
                b = i;
                x = "";
                for (int j = a+1; j < b; j++)
                    x += _file.ElementAt(j);
                var sqldb=x;//REPLACE THIS LINE WITH X BEING ADDED TO THE DATABASE
                data[z] = sqldb;
            }
        }
    }
    protected void confirm(object sender,EventArgs e)
    {
        Guid ID = Guid.NewGuid();
        //ADD TO DATABASE
        var dir = Server.MapPath("~//App_Data");
        var file = Path.Combine(dir, "data");
        var _file = File.ReadAllText(file);
        int a = 0, b = 0, c = 0;
        int z = 0;
        string x;
        for (int i = 0; (i < _file.Length); i++)
        {
            if (_file.ElementAt(i) == '$')
            {
                c++;
                a = b;
                b = i;
                x = "";
                for (int j = a + 1; j < b; j++)
                    x += _file.ElementAt(j);
                var sqldb = x;//REPLACE THIS LINE WITH X BEING ADDED TO THE DATABASE
                switch (z)
                {

                    case 0:
                        break;
                    default:
                        break;
                }
                z++;
            }
        }
    }
}