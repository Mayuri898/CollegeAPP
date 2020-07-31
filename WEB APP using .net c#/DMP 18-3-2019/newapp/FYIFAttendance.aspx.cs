using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
public partial class newapp_FYIFAttendance : System.Web.UI.Page
{
    string s;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] != null)
            Labelname.Text = Session["id"].ToString();

        else
        {
            Response.Redirect("/newapp/Login.aspx");
        }
        if (!this.IsPostBack)
        {
            this.PopulateStudentDetails();
        }
    }



    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
    private void PopulateStudentDetails()
    {
        string constr = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string SD = this.TextBox1.Text.Trim();

                string sql = "SELECT IDNUM,Name FROM RegisterDBStud where Year = 'FY' ";
                
                cmd.CommandText = sql;
                cmd.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataSet dt = new DataSet();
                    sda.Fill(dt);
                    gvStudents.DataSource = dt.Tables[0];
                    gvStudents.DataBind();
                }
            }
        }
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString);
        //SqlDataAdapter da = new SqlDataAdapter("SELECT IDNUM,Name FROM RegisterDBStud where Year='FY'", con);
        //DataSet ds = new DataSet();
        //da.Fill(ds);
        //gvStudents.DataSource = ds.Tables[0];
        //gvStudents.DataBind();
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
    protected void SaveStudentAttendance(object sender, EventArgs e)
    {
        foreach (GridViewRow row in gvStudents.Rows)
        {
            if (row.RowType == DataControlRowType.DataRow)
            {

                string ans = ((Label)row.FindControl("lblRollNo")).Text;
                string ansname = ((Label)row.FindControl("lblRollName")).Text;
                //string ans =ans.Trim();
                string constring = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(constring);

                string sub = (this.DropDownList2.SelectedItem.Text.Trim());
                switch (sub)
                {
                    case "ENG":
                        {
                            var checkbox = row.FindControl("chkAttendence") as CheckBox;
                            if (checkbox.Checked)
                            {
                                s = "A";
                            }
                            else { s = "P"; }
                            //String CD = this.txtDate.Text.Trim();
                            con.Open();
                            SqlCommand cmdCount = new SqlCommand("SELECT count(*) from FYIFsemI WHERE IDNUM = @IDNUM", con);
                            cmdCount.Parameters.AddWithValue("@IDNUM", ans);
                            
                            int count = (int)cmdCount.ExecuteScalar();

                            if (count > 0)
                            {
                                // UPDATE STATEMENT
                                SqlCommand updCommand = new SqlCommand("UPDATE FYIFsemI SET ENG = @ENG , DateofAtten=@DateofAtten where IDNUM=@IDNUM ", con);
                                updCommand.Parameters.AddWithValue("@IDNUM", ans);

                                updCommand.Parameters.AddWithValue("@ENG", s);
                                updCommand.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);

                                int rowsUpdated = updCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            else
                            {

                                // INSERT STATEMENT
                                SqlCommand insCommand = new SqlCommand("INSERT into FYIFsemI (id,IDNUM,Name, DateofAtten, ENG) VALUES ((select isnull(max(id),0)+1 from FYIFsemI),@IDNUM,@Name, @DateofAtten, @ENG)", con);
                                insCommand.Parameters.AddWithValue("@IDNUM", ans);
                                insCommand.Parameters.AddWithValue("@Name", ansname);
                                insCommand.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);

                                insCommand.Parameters.AddWithValue("@ENG", s);
                                int rowsUpdated = insCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You Add the Attendance Record Successfully')", true);


                            break;
                        }
                    case "BMS":
                        {
                            var checkbox = row.FindControl("chkAttendence") as CheckBox;
                            if (checkbox.Checked)
                            {
                                s = "A";
                            }
                            else { s = "P"; }
                            //String CD = this.txtDate.Text.Trim();
                            con.Open();
                            SqlCommand cmdCount = new SqlCommand("SELECT count(*) from FYIFsemI WHERE IDNUM = @IDNUM", con);
                            cmdCount.Parameters.AddWithValue("@IDNUM", ans);
                            int count = (int)cmdCount.ExecuteScalar();

                            if (count > 0)
                            {
                                // UPDATE STATEMENT
                                SqlCommand updCommand = new SqlCommand("UPDATE FYIFsemI SET BMS = @BMS , DateofAtten=@DateofAtten  where IDNUM=@IDNUM ", con);
                                updCommand.Parameters.AddWithValue("@IDNUM",ans);

                                updCommand.Parameters.AddWithValue("@BMS", s);
                                updCommand.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);

                                int rowsUpdated = updCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            else
                            {

                                // INSERT STATEMENT
                                SqlCommand insCommand = new SqlCommand("INSERT into FYIFsemI (id,Name,IDNUM, DateofAtten, BMS) VALUES ((select isnull(max(id),0)+1 from FYIFsemI),@IDNUM,@Name, @DateofAtten, @BMS)", con);
                                insCommand.Parameters.AddWithValue("@IDNUM",ans);
                                insCommand.Parameters.AddWithValue("@Name", ansname);
                                insCommand.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);

                                insCommand.Parameters.AddWithValue("@BMS", s);
                                int rowsUpdated = insCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You Add the Attendance Record Successfully')", true);


                            break;
                        }
                    case "JAVA":
                        {
                            var checkbox = row.FindControl("chkAttendence") as CheckBox;
                            if (checkbox.Checked)
                            {
                                s = "A";
                            }
                            else { s = "P"; }
                            //String CD = this.txtDate.Text.Trim();
                            con.Open();
                            SqlCommand cmdCount = new SqlCommand("SELECT count(*) from FYIFsemI WHERE IDNUM = @IDNUM", con);
                            cmdCount.Parameters.AddWithValue("@IDNUM",ans);
                            int count = (int)cmdCount.ExecuteScalar();

                            if (count > 0)
                            {
                                // UPDATE STATEMENT
                                SqlCommand updCommand = new SqlCommand("UPDATE FYIFsemI SET JAVA = @JAVA , DateofAtten=@DateofAtten  where IDNUM=@IDNUM ", con);
                                updCommand.Parameters.AddWithValue("@IDNUM",ans);

                                updCommand.Parameters.AddWithValue("@JAVA", s);
                                updCommand.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);

                                int rowsUpdated = updCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            else
                            {

                                // INSERT STATEMENT
                                SqlCommand insCommand = new SqlCommand("INSERT into FYIFsemI (id,IDNUM,Name DateofAtten, JAVA) VALUES ((select isnull(max(id),0)+1 from FYIFsemI),@IDNUM,@Name, @DateofAtten, @JAVA)", con);
                                insCommand.Parameters.AddWithValue("@IDNUM",ans);
                                insCommand.Parameters.AddWithValue("@Name", ansname);

                                insCommand.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);

                                insCommand.Parameters.AddWithValue("@JAVA", s);
                                int rowsUpdated = insCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You Add the Attendance Record Successfully')", true);


                            break;
                        }
                    case "C":
                        {
                            var checkbox = row.FindControl("chkAttendence") as CheckBox;
                            if (checkbox.Checked)
                            {
                                s = "A";
                            }
                            else { s = "P"; }
                            //String CD = this.txtDate.Text.Trim();
                            con.Open();
                            SqlCommand cmdCount = new SqlCommand("SELECT count(*) from FYIFsemI WHERE IDNUM = @IDNUM", con);
                            cmdCount.Parameters.AddWithValue("@IDNUM",ans);
                            int count = (int)cmdCount.ExecuteScalar();

                            if (count > 0)
                            {
                                // UPDATE STATEMENT
                                SqlCommand updCommand = new SqlCommand("UPDATE FYIFsemI SET C = @C , DateofAtten=@DateofAtten  where IDNUM=@IDNUM ", con);
                                updCommand.Parameters.AddWithValue("@IDNUM",ans);

                                updCommand.Parameters.AddWithValue("@C", s);
                                updCommand.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);

                                int rowsUpdated = updCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            else
                            {

                                // INSERT STATEMENT
                                SqlCommand insCommand = new SqlCommand("INSERT into FYIFsemI (id,IDNUM,Name, DateofAtten, C) VALUES ((select isnull(max(id),0)+1 from FYIFsemI),@IDNUM,@Name, @DateofAtten, @C)", con);
                                insCommand.Parameters.AddWithValue("@IDNUM",ans);
                                insCommand.Parameters.AddWithValue("@Name", ansname);

                                insCommand.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);

                                insCommand.Parameters.AddWithValue("@C", s);
                                int rowsUpdated = insCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You Add the Attendance Record Successfully')", true);


                            break;
                        }
                    case "PHY":
                        {
                            var checkbox = row.FindControl("chkAttendence") as CheckBox;
                            if (checkbox.Checked)
                            {
                                s = "A";
                            }
                            else { s = "P"; }
                            //String CD = this.txtDate.Text.Trim();
                            con.Open();
                            SqlCommand cmdCount = new SqlCommand("SELECT count(*) from FYIFsemI WHERE IDNUM = @IDNUM", con);
                            cmdCount.Parameters.AddWithValue("@IDNUM",ans);
                            int count = (int)cmdCount.ExecuteScalar();

                            if (count > 0)
                            {
                                // UPDATE STATEMENT
                                SqlCommand updCommand = new SqlCommand("UPDATE FYIFsemI SET PHY = @PHY , DateofAtten=@DateofAtten  where IDNUM=@IDNUM ", con);
                                updCommand.Parameters.AddWithValue("@IDNUM",ans);

                                updCommand.Parameters.AddWithValue("@PHY", s);
                                updCommand.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);

                                int rowsUpdated = updCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            else
                            {

                                // INSERT STATEMENT
                                SqlCommand insCommand = new SqlCommand("INSERT into FYIFsemI (id,IDNUM,Name, DateofAtten, PHY) VALUES ((select isnull(max(id),0)+1 from FYIFsemI),@IDNUM,@Name, @DateofAtten, @PHY)", con);
                                insCommand.Parameters.AddWithValue("@IDNUM",ans);
                                insCommand.Parameters.AddWithValue("@Name", ansname);
                                insCommand.Parameters.AddWithValue("@DateofAtten", Calendar1.SelectedDate);

                                insCommand.Parameters.AddWithValue("@PHY", s);
                                int rowsUpdated = insCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You Add the Attendance Record Successfully')", true);


                            break;
                        }


                }
            }
        }

    }
    protected void Unnamed_ServerClick(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("/newapp/Login.aspx");
    }
    protected void btn_click(object sender, EventArgs e)
    {

        Response.Redirect("timetable.aspx");
    }
}