using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class newapp_RegistrationOfHOD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string SQLCON = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(SQLCON);

        SqlCommand cmd = new SqlCommand("if exists (select * from IdCardHOD where [Unique Id]=@Uniqueid)begin if not exists(select 0 from RegisterDBHOD where [UniqueId]=@UniqueId) begin insert into RegisterDBHOD(id,Name,LastName,MobileNo,EmailId,UniqueId,Username,password) values ((select isnull(max(id),0)+1 from RegisterDBHOD),@Name,@LastName,@MobileNo,@EmailId,@UniqueId,@Username,@password) end end  ", con);
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
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Register Successfully..So  you can Login now ')", true);


            Response.Redirect("LoginHOD.aspx");


        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Register! ')", true);

        }
    }
}