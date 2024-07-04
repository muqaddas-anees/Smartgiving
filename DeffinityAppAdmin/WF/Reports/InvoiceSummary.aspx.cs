using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
public partial class Reports_InvoiceSummary : System.Web.UI.Page
{
    ReportDocument rpt;
    int ProjectReference;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProjectReference= Convert.ToInt32(Request.QueryString["Project"].ToString());         
        BindReport();
    }
    private void BindReport()
    {
        //try
        //{
            ProjectReference = Convert.ToInt32(Request.QueryString["Project"].ToString());
            rpt = new ReportDocument();
            //CrystalReportViewer1.Enabled = true;
            //CrystalReportViewer1.EnableParameterPrompt = false;
            //CrystalReportViewer1.EnableDatabaseLogonPrompt = false;

            //Load the selected report file.

            string str = "InvoiceSummary.rpt";
            rpt.Load(Server.MapPath(str));

            //Set the Database Login Information
            string strUser = System.Configuration.ConfigurationManager.AppSettings["user"];
            string strPassword = System.Configuration.ConfigurationManager.AppSettings["password"];
            string strServer = System.Configuration.ConfigurationManager.AppSettings["server"];
            string strDatabase = System.Configuration.ConfigurationManager.AppSettings["database"];

            DataTable dt = new DataTable();
            string strConn = System.Configuration.ConfigurationManager.AppSettings["DBstring"];
            SqlConnection MyCon = new SqlConnection(strConn);
            SqlCommand myCommand = new SqlCommand("DN_rpt_ImvoiceSummary", MyCon);
            myCommand.CommandType = CommandType.StoredProcedure;

            myCommand.Parameters.Add("@ProjectReference", SqlDbType.Int).Value = ProjectReference;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(dt);

            DataTable dt1 = new DataTable();
            SqlDataAdapter adp_sub = new SqlDataAdapter("DN_rpt_ProjectDetails", MyCon);
            adp_sub.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp_sub.SelectCommand.Parameters.Add("@ProjectReference", SqlDbType.Int).Value = ProjectReference;
            adp_sub.Fill(dt1);
            rpt.Subreports[1].SetDatabaseLogon(strUser, strPassword, strServer, strDatabase);
            rpt.Subreports[1].SetDataSource(dt1);

            DataTable dt2 = new DataTable();
            SqlDataAdapter adp_sub1 = new SqlDataAdapter("DN_rpt_InvoiceSumm_sub", MyCon);
            adp_sub1.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp_sub1.SelectCommand.Parameters.Add("@ProjectReference", SqlDbType.Int).Value = ProjectReference;
            adp_sub1.Fill(dt2);
            rpt.Subreports[0].SetDatabaseLogon(strUser, strPassword, strServer, strDatabase);
            rpt.Subreports[0].SetDataSource(dt2);

            //Set the Crytal Report Viewer control's source to the report document.
            rpt.SetDatabaseLogon(strUser, strPassword, strServer, strDatabase);
            rpt.SetDataSource(dt);

            Response.Clear();
            rpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Project Invoice Report");
            Response.End();

            //Response.Write(rpt.DataSourceConnections.Count.ToString());
            //CrystalReportViewer1.ReportSource = rpt;
            //CrystalReportViewer1.Visible = true;
        //}
        //catch (Exception ex)
        //{


        //    rpt.Close();
        //    rpt.Dispose();
        //    rpt = null;
        //    CrystalReportViewer1.Dispose();
        //    CrystalReportSource1.Dispose();
        //    CrystalReportViewer1 = null;
        //}
        //finally
        //{ 
        
        
        //}

    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        if (rpt != null)
        {
            rpt.Close();
            rpt.Dispose();
           
            rpt = null;
            

        }
    }
}
