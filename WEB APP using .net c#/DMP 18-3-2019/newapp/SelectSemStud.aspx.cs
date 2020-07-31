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


public partial class newapp_SelectSemStud : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelDate.Text = DateTime.Now.ToString();
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
        string SQLCON = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(SQLCON);

        SqlCommand cmd = new SqlCommand("insert into forjoinStud(id,Sem,Sub,SubmissionDate,Rno) values ((select isnull(max(id),0)+1 from forjoinStud),@Sem,@Sub,@SubmissionDate,@Rno)", con);
        
        cmd.Parameters.AddWithValue("@Sem", DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@Sub", DropDownList2.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@SubmissionDate", DateTime.Now);
        cmd.Parameters.AddWithValue("@Rno", TextBox1.Text);
        

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        if (cmd.ExecuteNonQuery() > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Done!')", true);

            Response.Redirect("AddSubmission.aspx");

        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!')", true);

        }
    }

}