﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;


public partial class newapp_tablejoin : System.Web.UI.Page
{
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
        string SQLCON = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(SQLCON);

        SqlCommand cmd = new SqlCommand("insert into TYCOAssignmentsNew(id,FileName,FileSize,FilePath,Sem,Sub,UploadDate,SubmissionDate,Asn)(select TYCOAssignments.id, TYCOAssignments.FileName, TYCOAssignments.FileSize, TYCOAssignments.FilePath, forjoin.Sem, forjoin.Sub, forjoin.UploadDate, forjoin.SubmissionDate, forjoin.Asn from TYCOAssignments, forjoin)", con);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        if (cmd.ExecuteNonQuery() > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Done')", true);

           

        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error')", true);

        }

    }

}