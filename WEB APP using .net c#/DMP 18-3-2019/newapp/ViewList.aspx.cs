using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

public partial class newapp_ViewList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] != null)
            Labelname.Text = Session["id"].ToString();

        else
        {
            Response.Redirect("StudLog.aspx");
        }

    }



    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)

    {
        string dsitem = (this.DropDownList1.SelectedItem.Text.Trim());
        switch (dsitem)
        {

            case "I":
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString);
                    string com = "Select * from Isem";
                    SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    DropDownList2.DataSource = dt;
                    DropDownList2.DataBind();
                    DropDownList2.DataTextField = "Subject";
                    DropDownList2.DataValueField = "ID";
                    DropDownList2.DataBind();

                    break;
                }
            case "II":
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString);
                    string com = "Select * from IIsem";
                    SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    DropDownList2.DataSource = dt;
                    DropDownList2.DataBind();
                    DropDownList2.DataTextField = "Subject";
                    DropDownList2.DataValueField = "ID";
                    DropDownList2.DataBind();

                    break;
                }

        }
    }

    protected void Upload_ServerClick(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                

                string sql = "SELECT Asn,Sem,Sub,UploadDate,SubmissionDate,FileName from TYCOAssignmentsNew where Sem=@Sem AND Sub=@Sub ";
                cmd.Parameters.AddWithValue("@Sem", DropDownList1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@Sub", DropDownList2.SelectedItem.Text);
                cmd.CommandText = sql;
                cmd.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    gvCustomers.DataSource = dt;
                    gvCustomers.DataBind();
                }
            }
        }
    }
}