using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class newapp_RegistrationOfStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string SQLCON = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(SQLCON);

        SqlCommand cmd = new SqlCommand("if exists (select * from IdCard where [Unique Id]=@Uniqueid)begin if not exists(select 0 from RegisterDB where [UniqueId]=@UniqueId) begin insert into RegisterDB(id,Name,LastName,MobileNo,EmailId,UniqueId,Username,password) values ((select isnull(max(id),0)+1 from RegisterDB),@Name,@LastName,@MobileNo,@EmailId,@UniqueId,@Username,@password) end end  ", con);
        cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
        cmd.Parameters.AddWithValue("@LastName", TextBox2.Text);
        cmd.Parameters.AddWithValue("@MobileNo", TextBox3.Text);
        cmd.Parameters.AddWithValue("@EmailId", TextBox4.Text);
        cmd.Parameters.AddWithValue("@UniqueId", TextBox5.Text);
        cmd.Parameters.AddWithValue("@Username", TextBox6.Text);
        cmd.Parameters.AddWithValue("@password", TextBox7.Text);

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        if (cmd.ExecuteNonQuery() > 0)
        {
            Label1.Text = "Register Successfully";
            Label1.ForeColor = System.Drawing.Color.Green;


            Response.Redirect("Login.aspx");


        }
        else
        {
            Label1.Text = "Register Failed";
            Label1.ForeColor = System.Drawing.Color.Red;
        }
    }
}