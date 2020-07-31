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

public partial class AfterFacultyLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Upload_ServerClick(object sender, EventArgs e)
    {
        Response.Redirect("timetable.aspx");

    }
    protected void Upload1_ServerClick(object sender, EventArgs e)
    {
        Response.Redirect("AddNotification.aspx");

    }
    protected void Upload2_ServerClick(object sender, EventArgs e)
    {
        Response.Redirect("SelectSem.aspx");

    }
    protected void Upload3_ServerClick(object sender, EventArgs e)
    {
        Response.Redirect("ViewSubmission.aspx");

    }
}