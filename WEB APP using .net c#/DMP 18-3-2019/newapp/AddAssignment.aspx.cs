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

public partial class AddAssignment : System.Web.UI.Page
{
    public DataTable dt = new DataTable();
    public void SaveFilePath(string name, int size, string path)
    {


        string SQLCON = ConfigurationManager.ConnectionStrings["hateConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(SQLCON);
        string insertText = "INSERT INTO Assignments(id,FileName,FileSize,FilePath,Semister,Subject,updDate,subDate) VALUES ((select isnull(max(id),0)+1 from Assignments),@FileName,@FileSize,@FilePath,@Semister,@Subject,@updDate,@subDate)";

        SqlCommand command = new SqlCommand(insertText, con);
        command.Parameters.Add("@FileName", SqlDbType.VarChar, 50);
        command.Parameters["@FileName"].Value = name;
        command.Parameters.Add("@FileSize", SqlDbType.Int);
        command.Parameters["@FileSize"].Value = size;
        command.Parameters.Add("@FilePath", SqlDbType.VarChar, 300);
        command.Parameters["@FilePath"].Value = path;
        command.Parameters.AddWithValue("@Semister",DropDownList1.SelectedValue);
        command.Parameters.AddWithValue("@Subject",DropDownList2.SelectedValue);
        command.Parameters.AddWithValue("@updDate",DateTime.Now);
        command.Parameters.AddWithValue("@subDate",TextBox1.Text);

        try
        {
            con.Open();
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {

        }
        finally
        {
            con.Close();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["UserName"] != null)
        //    Label2.Text = Session["UserName"].ToString();
        //else
        //{
        //    Response.Redirect("/loginForm.aspx");
        //}
    }
    protected void Unnamed_ServerClick(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("loginForm.aspx");
    }

    protected void Upload_ServerClick(object sender, EventArgs e)
    {

        bool correctExtension = false;

        if (FileUpload1.HasFile)
        {
            string fileName = FileUpload1.PostedFile.FileName;
            int fileSize = FileUpload1.PostedFile.ContentLength;
            string fileExtension = Path.GetExtension(fileName).ToLower();

            string[] extensionsAllowed = { ".doc", ".docx", ".xls", ".xlsx", ".txt", ".jpg", ".png", ".pdf" };

            if (extensionsAllowed.Contains(fileExtension))
            {
                correctExtension = true;
            }


            if (correctExtension)
            {
                if (fileExtension == ".pdf" || fileExtension == ".doc" || fileExtension == ".docx" || fileExtension == ".txt" || fileExtension == ".xlsx" || fileExtension == ".jpg" || fileExtension == ".png")
                {
                    try
                    {
                        string filePath = Server.MapPath("/Assignments/" + fileName);
                        FileUpload1.PostedFile.SaveAs(filePath);
                        SaveFilePath(fileName, fileSize, filePath);
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('SuccessFully Uploded')", true);





                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
            else
            {
                
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Due to Some error issue Not done')", true);


            }

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
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
    
    protected void logout_ServerClick(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("/newapp/Login.aspx");
    }
   

    
}