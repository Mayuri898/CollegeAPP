using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class newapp_Notification : System.Web.UI.Page
{
    public DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["id"] != null)
            Labelname.Text = Session["id"].ToString();

        else
        {
            Response.Redirect("/StudLog.aspx");

        }

        if (!this.IsPostBack)
        {
            this.SearchCustomers();
        }
    }

    private void SearchCustomers()
    {
        string SQLCON = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(SQLCON);

        SqlCommand cmd = new SqlCommand("select * from Notification order by id desc", con);
        con.Open();

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.SelectCommand = cmd;
        da.Fill(dt);
        Repeater1.DataSource = dt;
        Repeater1.DataBind();
    }

}