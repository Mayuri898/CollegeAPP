using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
public partial class newapp_timetable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["id"] != null)
            Labelname.Text = Session["id"].ToString();

        else
        {
            Response.Redirect("Login.aspx");
        }
        if (!this.IsPostBack)
        {
            this.SearchCustomers();
        }
    }
    private void SearchCustomers()
    {

        string constring = ConfigurationManager.ConnectionStrings["DB_A46585_mayuri898ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        con.Open();

        var check1 = CheckBox1 as CheckBox;
        var check2 = CheckBox2 as CheckBox;
        var check3 = CheckBox3 as CheckBox;
        var check4 = CheckBox4 as CheckBox;
        var check5 = CheckBox5 as CheckBox;
        var check6 = CheckBox6 as CheckBox;
        var check7 = CheckBox7 as CheckBox;
        var check8 = CheckBox8 as CheckBox;
        var check9 = CheckBox9 as CheckBox;
        var check10 = CheckBox10 as CheckBox;

        var check11 = CheckBox11 as CheckBox;
        var check12 = CheckBox12 as CheckBox;
        var check13 = CheckBox13 as CheckBox;
        var check14 = CheckBox14 as CheckBox;
        var check15 = CheckBox15 as CheckBox;
        var check16 = CheckBox16 as CheckBox;
        var check17 = CheckBox17 as CheckBox;
        var check18 = CheckBox18 as CheckBox;
        var check19 = CheckBox19 as CheckBox;
        var check20 = CheckBox20 as CheckBox;

        var check21 = CheckBox21 as CheckBox;
        var check22 = CheckBox22 as CheckBox;
        var check23 = CheckBox23 as CheckBox;
        var check24 = CheckBox24 as CheckBox;
        var check25 = CheckBox25 as CheckBox;
        var check26 = CheckBox26 as CheckBox;
        var check27 = CheckBox27 as CheckBox;
        var check28 = CheckBox28 as CheckBox;
        var check29 = CheckBox29 as CheckBox;
        var check30 = CheckBox30 as CheckBox;

        var check31 = CheckBox31 as CheckBox;
        var check32 = CheckBox32 as CheckBox;
        var check33 = CheckBox33 as CheckBox;
        var check34 = CheckBox34 as CheckBox;
        var check35 = CheckBox35 as CheckBox;
        var check36 = CheckBox36 as CheckBox;
        var check37 = CheckBox37 as CheckBox;
        var check38 = CheckBox38 as CheckBox;
        var check39 = CheckBox39 as CheckBox;
        var check40 = CheckBox40 as CheckBox;

        var check41 = CheckBox41 as CheckBox;
        var check42 = CheckBox42 as CheckBox;
        var check43 = CheckBox43 as CheckBox;
        var check44 = CheckBox44 as CheckBox;
        var check45 = CheckBox45 as CheckBox;
        var check46 = CheckBox46 as CheckBox;
        var check47 = CheckBox47 as CheckBox;
        var check48 = CheckBox48 as CheckBox;
        var check49 = CheckBox49 as CheckBox;
        var check50 = CheckBox50 as CheckBox;

        var check51 = CheckBox51 as CheckBox;
        var check52 = CheckBox52 as CheckBox;
        var check53 = CheckBox53 as CheckBox;
        var check54 = CheckBox54 as CheckBox;
        var check55 = CheckBox55 as CheckBox;
        var check56 = CheckBox56 as CheckBox;
        var check57 = CheckBox57 as CheckBox;
        var check58 = CheckBox58 as CheckBox;
        var check59 = CheckBox59 as CheckBox;
        var check60 = CheckBox60 as CheckBox;

        var check61 = CheckBox61 as CheckBox;
        var check62 = CheckBox62 as CheckBox;
        var check63 = CheckBox63 as CheckBox;
        var check64 = CheckBox64 as CheckBox;
        var check65 = CheckBox65 as CheckBox;
        var check66 = CheckBox66 as CheckBox;
        var check67 = CheckBox67 as CheckBox;
        var check68 = CheckBox68 as CheckBox;
        var check69 = CheckBox69 as CheckBox;
        var check70 = CheckBox70 as CheckBox;

        var check71 = CheckBox71 as CheckBox;
        var check72 = CheckBox72 as CheckBox;
        var check73 = CheckBox73 as CheckBox;
        var check74 = CheckBox74 as CheckBox;
        var check75 = CheckBox75 as CheckBox;
        var check76 = CheckBox76 as CheckBox;
        var check77 = CheckBox77 as CheckBox;
        var check78 = CheckBox78 as CheckBox;
        var check79 = CheckBox79 as CheckBox;
        var check80 = CheckBox80 as CheckBox;

        var check81 = CheckBox81 as CheckBox;
        var check82 = CheckBox82 as CheckBox;
        var check83 = CheckBox83 as CheckBox;
        var check84 = CheckBox84 as CheckBox;
        var check85 = CheckBox85 as CheckBox;
        var check86 = CheckBox86 as CheckBox;
        var check87 = CheckBox87 as CheckBox;
        var check88 = CheckBox88 as CheckBox;
        var check89 = CheckBox89 as CheckBox;
        var check90 = CheckBox90 as CheckBox;

        var check91 = CheckBox91 as CheckBox;
        var check92 = CheckBox92 as CheckBox;
        var check93 = CheckBox93 as CheckBox;
        var check94 = CheckBox94 as CheckBox;
        var check95 = CheckBox95 as CheckBox;
        var check96 = CheckBox96 as CheckBox;
        var check97 = CheckBox97 as CheckBox;
        var check98 = CheckBox98 as CheckBox;
        var check99 = CheckBox99 as CheckBox;
        var check100 = CheckBox100 as CheckBox;

        var check101 = CheckBox101 as CheckBox;
        var check102 = CheckBox102 as CheckBox;
        var check103 = CheckBox103 as CheckBox;
        var check104 = CheckBox104 as CheckBox;
        var check105 = CheckBox105 as CheckBox;


        if (check1.Checked)
        {

            Response.Redirect("FYIFAttendance.aspx");

        }
        else if (check2.Checked)
        {
            Response.Redirect("FYIFAttendance.aspx");
        }
        else if (check3.Checked)
        {
            Response.Redirect("FYIFAttendance.aspx");
        }
        else if (check4.Checked)
        {
            Response.Redirect("FYIFAttendance.aspx");
        }
        else if (check5.Checked)
        {
            Response.Redirect("FYIFAttendance.aspx");
        }
        else if (check6.Checked)
        {
            Response.Redirect("FYIFAttendance.aspx");
        }
        else if (check7.Checked)
        {
            Response.Redirect("FYIFAttendance.aspx");
        }
    }
    protected void SaveStudentAttendance3(object sender, EventArgs e)
    {
        this.SearchCustomers();
    }
    
}