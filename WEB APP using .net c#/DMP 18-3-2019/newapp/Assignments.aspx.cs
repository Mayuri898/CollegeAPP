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

public partial class Assignments : System.Web.UI.Page
{
    public DataTable dt = new DataTable();
    public void SaveFilePath(string name, int size, string path)
    {


        string SQLCON = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(SQLCON);
        string insertText = "INSERT INTO TYCOAssignments(id,FileName,FileSize,FilePath) VALUES ((select isnull(max(id),0)+1 from TYCOAssignments),@FileName,@FileSize,@FilePath)";

        SqlCommand command = new SqlCommand(insertText, con);
        command.Parameters.Add("@FileName", SqlDbType.VarChar, 50);
        command.Parameters["@FileName"].Value = name;
        command.Parameters.Add("@FileSize", SqlDbType.Int);
        command.Parameters["@FileSize"].Value = size;
        command.Parameters.Add("@FilePath", SqlDbType.VarChar, 300);
        command.Parameters["@FilePath"].Value = path;

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
        if (Session["id"] != null)
            Labelname.Text = Session["id"].ToString();

        else
        {
            Response.Redirect("Login.aspx");
        }
        
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
                        
                        string filePath = Server.MapPath("~/Assignments/" + fileName);
                        FileUpload1.PostedFile.SaveAs(filePath);
                        Console.WriteLine(filePath);
                        SaveFilePath(fileName, fileSize, filePath);
                       

                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('SuccessFully Uploded')", true);
                        Response.Redirect("FinalAdding.aspx");



                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error')", true);



            }

        }


    }
}