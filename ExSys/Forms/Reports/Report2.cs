////
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExSys.Forms.Reports
{
    public partial class Report2 : Form
    {
        ReportViewer reportViewer2 = new ReportViewer();

        public Report2(string reportName, int ID1, int ID2)
        {
            InitializeComponent();

            reportViewer2.Dock = DockStyle.Fill;
            reportViewer2.BackColor = System.Drawing.Color.Gray;

            Controls.Add(reportViewer2);

            // Set the processing mode for the ReportViewer to Remote  
            reportViewer2.ProcessingMode = ProcessingMode.Remote;

            ServerReport serverReport = reportViewer2.ServerReport;

            // Get a reference to the default credentials  
            System.Net.ICredentials credentials =
                System.Net.CredentialCache.DefaultCredentials;

            // Get a reference to the report server credentials  
            ReportServerCredentials rsCredentials =
                serverReport.ReportServerCredentials;

            // Set the credentials for the server report  
            rsCredentials.NetworkCredentials = credentials;

            // Set the report server URL and report path  
            serverReport.ReportServerUrl =
                new Uri("http://al-qamary/ReportServer");
            serverReport.ReportPath = $"/{reportName}";
            //"/AdventureWorks Sample Reports/Sales Order Detail";

            // Create the sales order number report parameter  
            //ReportParameter salesOrderNumber = new ReportParameter();
            //salesOrderNumber.Name = "SalesOrderNumber";
            //salesOrderNumber.Values.Add("SO43661");

            // Set the report parameters for the report  
            //reportViewer2.ServerReport.SetParameters(
            //    new ReportParameter[] { salesOrderNumber });

            // Refresh the report  
            reportViewer2.RefreshReport();
            InitializeComponent();

            reportViewer2.Dock = DockStyle.Fill;
            reportViewer2.BackColor = System.Drawing.Color.White;

            Controls.Add(reportViewer2);

            // Set the processing mode for the ReportViewer to Remote  
            reportViewer2.ProcessingMode = ProcessingMode.Remote;

            ServerReport serverReport1 = reportViewer2.ServerReport;

            // Get a reference to the default credentials  
            System.Net.ICredentials credentials1 =
                System.Net.CredentialCache.DefaultCredentials;

            // Get a reference to the report server credentials  
            ReportServerCredentials rsCredentials1 =
                serverReport1.ReportServerCredentials;

            // Set the credentials for the server report  
            rsCredentials1.NetworkCredentials = credentials1;

            // Set the report server URL and report path  
            serverReport1.ReportServerUrl =
                new Uri("http://al-qamary/ReportServer");
            serverReport1.ReportPath = $"/{reportName}";
            //"/AdventureWorks Sample Reports/Sales Order Detail";

            // Create report parameter  
            ReportParameter Exam_ID = new ReportParameter();
            Exam_ID.Name = "ID1"; // Match the parameter name with the one in the stored procedure
            Exam_ID.Values.Add(ID1.ToString()); // Access the value of id using id.Value
                                                       // Set the report parameters for the report  
            // Create report parameter
            ReportParameter Student_ID = new ReportParameter();
            Student_ID.Name = "ID2"; 
            Student_ID.Values.Add(ID2.ToString());
            reportViewer2.ServerReport.SetParameters(
                new ReportParameter[] { Exam_ID, Student_ID });
                

            // Refresh the report  
            reportViewer2.RefreshReport();
        }
        private void Report2_Load(object sender, EventArgs e)
        {
        }

    }
}
