using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class newapp_FY : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] != null)
            Labelname.Text = Session["id"].ToString();

        else
        {
            Response.Redirect("LoginHOD.aspx");
        }

        if (!this.IsPostBack)
        {
            this.SearchCustomers();
        }


    }
    private void SearchCustomers()
    { }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)//calender
    {
        Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
    protected void Save_ServerClick(object sender, EventArgs e)//Filter

    {
        
            string constr = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string SD = this.TextBox1.Text.Trim();

                    string sql = "SELECT IDNUM,NAME,DateofAtten,ENG,BMS,JAVA,C,PHY FROM FYIFsemI where DateofAtten=@DateofAtten AND ENG = 'A' OR BMS='A' OR JAVA='A' OR C='A'  OR PHY='A'  OR ENG='A' AND BMS='A'  OR ENG='A' AND JAVA='A'  OR ENG='A' AND C='A'  OR ENG='A' AND PHY='A' ";
                    cmd.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        gvCustomers1.DataSource = dt;
                        gvCustomers1.DataBind();
                    }
                }
            }
        
        
    }
    protected void Save_ServerClick6(object sender, EventArgs e)//whole attendance

    {
       
            string constr = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string SD = this.TextBox1.Text.Trim();

                    string sql = " select * from FYIFsemI";
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

    protected void Save_ServerClick4(object sender, EventArgs e)//export sheet

    {
        foreach (GridViewRow row in gvCustomers.Rows)
        {
            if (row.RowType == DataControlRowType.DataRow)
            {
                string IDNUM = row.Cells[0].Text;
                string NAME = row.Cells[1].Text;
                string ENG = row.Cells[2].Text;
                string BMS = row.Cells[3].Text;
                string JAVA = row.Cells[4].Text;
                string C = row.Cells[5].Text;
                string PHY = row.Cells[6].Text;
                string constring = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand insCommand = new SqlCommand("INSERT into DailyabsentFYIFsemI (id,IDNUM, Name,DateofAtten, ENG,BMS,JAVA,C,PHY) VALUES ((select isnull(max(id),0)+1 from DailyabsentFYIFsemI),@IDNUM,@Name, @DateofAtten, @ENG,@BMS,@JAVA,@C,@PHY)", con);
                insCommand.Parameters.AddWithValue("@IDNUM", IDNUM);
                insCommand.Parameters.AddWithValue("@Name", NAME);
                insCommand.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);
                insCommand.Parameters.AddWithValue("@ENG", ENG);
                insCommand.Parameters.AddWithValue("@BMS", BMS);
                insCommand.Parameters.AddWithValue("@JAVA", JAVA);
                insCommand.Parameters.AddWithValue("@C", C);
                insCommand.Parameters.AddWithValue("@PHY", PHY);
                int rowsUpdated = insCommand.ExecuteNonQuery();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Export AttendanceSheet Successfully')", true);

                con.Close();


            }
        }
    }
    protected void Save_ServerClick3(object sender, EventArgs e)//delete record
    {
        string constring = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        con.Open();
        SqlCommand insCommand = new SqlCommand("Delete from DailyabsentFYIFsemI", con);
        insCommand.ExecuteNonQuery();
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Deleted!')", true);
        con.Close();



    }
    //string SQLCON = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
    //SqlConnection con = new SqlConnection(SQLCON);

    //SqlCommand cmd = new SqlCommand("insert into DailyabsentFYIFsemI(IDNUM,Name,DateofAtten,ENG,BMS,JAVA,C,PHY)(select IDNUM, Name, DateofAtten, ENG, BMS, JAVA, C, PHY from FYIFsemI)", con);
    //if (con.State == ConnectionState.Closed)
    //{
    //    con.Open();
    //}
    //if (cmd.ExecuteNonQuery() > 0)
    //{
    //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Done')", true);



    //}
    //else
    //{
    //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error')", true);

    //}




    protected void Unnamed_ServerClick(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("LoginHOD.aspx");
    }
}