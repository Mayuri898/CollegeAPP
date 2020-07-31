using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class newapp_showattendance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["id"] != null)
            Labelname.Text = Session["id"].ToString();

        else
        {
            Response.Redirect("/newapp/LoginHOD.aspx");
        }

        if (!this.IsPostBack)
        {
            this.show();
        }

    }

    private void show()
    {
        string SQLCON = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(SQLCON);
        con.Open();
        con.Close();
    }
    protected void Save_ServerClick3(object sender, EventArgs e)
    {
        Response.Redirect("TY.aspx");
    }
    protected void Save_ServerClick1(object sender, EventArgs e)
    {
        Response.Redirect("FY.aspx");
    }
    protected void Save_ServerClick2(object sender, EventArgs e)
    {
        Response.Redirect("SY.aspx");
    }


    protected void Unnamed_ServerClick(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("/newapp/LoginHOD.aspx");
    }
}