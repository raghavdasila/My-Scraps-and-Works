using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
public partial class Default3 : System.Web.UI.Page
{
    int user_code;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["STUDENTSConnectionString"].ConnectionString);
    bool isValid;
    //Final Variables
    string f_name,f_gender,f_hostel,f_bloodgroup,f_dept,f_father,
        f_house,f_street,f_city,f_state,f_email,f_dd,f_amount;
    string dob, dod, f_phno;
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Master.FindControl("hm").Visible = false;
        Page.Master.FindControl("lgin").Visible = false;
     
        isValid = true;
    }
    protected void RESET_Click(object sender, EventArgs e)
    {
        Name.Text = "";
        Gender.ClearSelection();
        BloodGroup.Text = "";
        Dept.Text = "";
        Father.Text = "";
        FathersPhoneNumber.Text = "";
        House.Text = "";
        Street.Text = "";
        City.Text = "";
        State.Text = "";
        email.Text = "";
        reset_textbox_color();
        isValid = true;
    }
    
    public void update_hostel()
    {
        if (Gender.SelectedIndex != 0)
        {
            if (Gender.SelectedItem.Value== "F")
            {
                Hostel.Items.FindByValue("1").Enabled = true;
                Hostel.Items.FindByValue("2").Enabled = true;
                Hostel.Items.FindByValue("3").Enabled = true;
                Hostel.Items.FindByValue("4").Enabled = false;
                Hostel.Items.FindByValue("5").Enabled = false;
                Hostel.Items.FindByValue("6").Enabled = false;
                Hostel.Visible = true;
            }
            else if (Gender.SelectedItem.Value == "M")
            {
                Hostel.Items.FindByValue("1").Enabled = false;
                Hostel.Items.FindByValue("2").Enabled = false;
                Hostel.Items.FindByValue("3").Enabled = false;
                Hostel.Items.FindByValue("4").Enabled = true;
                Hostel.Items.FindByValue("5").Enabled = true;
                Hostel.Items.FindByValue("6").Enabled = true;
                Hostel.Visible = true;
            }
        }
    }
    void name_validate(System.Web.UI.WebControls.TextBox Field)
    {
       string val = Field.Text.ToString();
       int semiVal=0;
       int  isVal = Regex.Matches(val,@"[a-zA-z]").Count;
       isVal += Regex.Matches(val, @"[.]").Count;
        isVal += Regex.Matches(val, @"\s").Count;
       semiVal= Regex.Matches(val, @"[.]").Count;
        semiVal += Regex.Matches(val, @"\s").Count;
       if (isVal!=val.Length || semiVal==isVal)
       {
           Field.ForeColor = System.Drawing.Color.Red;
           Field.ToolTip = "Enter only a-z,A-Z and spaces/dots";
            isValid=false;
       } 
    }
    void email_id_validate()
    { 
        string val = email.Text.ToString();
        int semiVal = 0;
        int isVal = Regex.Matches(val, @"[a-zA-z]").Count;
        isVal += Regex.Matches(val, @"[@.]").Count;
        semiVal = Regex.Matches(val, @"[@.]").Count;
        if (isVal != val.Length || semiVal == isVal)
        {            
            email.ForeColor = System.Drawing.Color.Red;
            email.ToolTip = "Enter a valid email address";
            isValid=false;
        }
    }
    void num_validate(System.Web.UI.WebControls.TextBox num)
    {
        string val = num.Text.ToString();
        int isval = Regex.Matches(val, @"[0123456789]").Count;
        if(isval!=val.Length)
        {
            num.ForeColor = System.Drawing.Color.Red;
            num.ToolTip = "Enter only numbers";
            isValid = false;
        }
    }
    protected void BG_Validate()
    {
        string val = BloodGroup.Text.ToString().ToUpper();
        int isval = Regex.Matches(val, @"[ABO+-]").Count;
        if (isval != val.Length || isval > 3)
        {
            BloodGroup.ForeColor = System.Drawing.Color.Red;
            BloodGroup.ToolTip = "Enter a valid Blood group";
            isValid = false;
        }
    }

    void reset_textbox_color()
    {
        Name.ForeColor = System.Drawing.Color.Black;
        Father.ForeColor = System.Drawing.Color.Black;
        City.ForeColor = System.Drawing.Color.Black;
        State.ForeColor = System.Drawing.Color.Black;
        email.ForeColor = System.Drawing.Color.Black;
        FathersPhoneNumber.ForeColor = System.Drawing.Color.Black;
        DD.ForeColor = System.Drawing.Color.Black;
        BloodGroup.ForeColor = System.Drawing.Color.Black;
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        //Names
        isValid = true;
        name_validate(Name);
        name_validate(Father);
        name_validate(City);
        name_validate(State);
        email_id_validate();
        num_validate(FathersPhoneNumber);
        num_validate(DD);
        BG_Validate();
        //Record Values
        if (isValid)
        {
            dob = bday.Text;
            f_name = Name.Text;
            f_gender = Gender.Text;
            f_hostel = Hostel.Text;
            f_bloodgroup = BloodGroup.Text.ToUpper();
            f_dept = Dept.Text;
            f_father = Father.Text;
            f_house = House.Text;
            f_street = Street.Text;
            f_city = City.Text;
            f_state = State.Text;
            f_email = email.Text;
            f_dd = DD.Text;
            f_amount = Amount.Text;
            // dob
            dod = DDDay.Text;
            f_phno = FathersPhoneNumber.Text;
            //add to db
            con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "insert into Table(Name,Gender,Hostel,DOB,Blood,Dept,F_Name,F_No,House,Street,City,State,e-mail,DD,Amt,DD_Date) values('" + f_name+ "','" + f_gender + "','"+dob+ "','" + f_bloodgroup + "','" + f_dept + "','" + f_father + "','" + f_phno + "','" + f_house +"','" + f_street + "','" + f_city + "','" + f_state + "','" + f_email + "','" + f_dd + "','" + f_dd + "')";

            SqlCommand cmd = new SqlCommand("insert into Table(Name,Gender,Hostel,DOB,Blood,Dept,F_Name,F_No,House,Street,City,State,e-mail,DD,Amt,DD_Date) values('" + f_name + "','" + f_gender + "','" + dob + "','" + f_bloodgroup + "','" + f_dept + "','" + f_father + "','" + f_phno + "','" + f_house + "','" + f_street + "','" + f_city + "','" + f_state + "','" + f_email + "','" + f_dd + "','" + f_dd + "')", con);
            cmd.CommandType = System.Data.CommandType.Text;
            //cmd.ExecuteNonQuery();
            con.Close();
            //generate report
            var dir = Server.MapPath("~\\App_Data");
            var file = Path.Combine(dir, "report");
            Directory.CreateDirectory(dir);
            File.WriteAllText(file,
                "Name: " + f_name + "\n"
                + "Date of Birth: " + dob + "\n"
                + "Gender: " + f_gender + "\n"
                + "Hostel: " + f_hostel + "\n"
                + "Blood Group: " + f_bloodgroup + "\n"
                + "Department: " + f_dept + "\n"
                + "Father's Name: " + f_father + "\n"
                + "Father's Contact: " + f_phno + "\n"
                + "House/Plot No.: " + f_house + "\n"
                + "Street/Location: " + f_street + "\n"
                + "City: " + f_city + "\n"
                + "State: " + f_state + "\n"
                + "E-mail: " + f_email + "\n"
                + "\nPayment Details : \n"
                + "DD No.: " + f_dd + "\n"
                + "Amount: " +f_amount + "\n"
                + "Date: " + dod
            );
            //for database entry
            dir = Server.MapPath("~\\App_Data");
            file = Path.Combine(dir, "data");
            File.WriteAllText(file, '$' +
                f_name + '$'
                + dob + '$'
                + f_gender + '$'
                + f_hostel + '$'
                + f_bloodgroup + '$'
                + f_dept + '$'
                + f_father + '$'
                + f_phno + '$'
                + f_house + '$'
                + f_street + '$'
                + f_city + '$'
                + f_state + '$'
                + f_email + '$'
                + f_dd + '$'
                + f_amount + '$'
                + dod + '$'
            );
            //Server.Transfer("Report.aspx");
           }
    }
    protected void Gender_SelectedIndexChanged(object sender, EventArgs e)
    {
        update_hostel();
      
    }
}