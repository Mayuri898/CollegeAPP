using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
public partial class newapp_AddNotification : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] != null)
            Labelname.Text = Session["id"].ToString();

        else
        {
            Response.Redirect("Login.aspx");
        }
        DateTime nd = DateTime.Now;
        LabelDate.Text = nd.ToLongDateString();

    }
    protected void Save_ServerClick(object sender, EventArgs e)
    {


        string SQLCON = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(SQLCON);
        SqlCommand cmd = new SqlCommand("insert into Notification(id,RelatedTo,Date,Description,Regards) values ((select isnull(max(id),0)+1 from Notification),@RelatedTo,@Date,@Description,@Regards)", con);


        cmd.Parameters.AddWithValue("@RelatedTo", TextBox1.Text);
        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
        cmd.Parameters.AddWithValue("@Description", TextArea1.Text);
        cmd.Parameters.AddWithValue("@Regards", TextBox3.Text);

        if (con.State == ConnectionState.Closed)
        {
            con.Open();

        }
        if (cmd.ExecuteNonQuery() > 0)
        {

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Done!')", true);
            Response.Redirect("index.html");

            //saved

        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!')", true);

            //error
        }

    }
  
}