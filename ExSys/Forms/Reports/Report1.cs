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
    public partial class Report1 : Form
    {
        ReportViewer reportViewer1 = new ReportViewer();

        public Report1(string reportName, int? id)
        {
            InitializeComponent();

            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.BackColor = System.Drawing.Color.Gray;

            Controls.Add(reportViewer1);

            // Set the processing mode for the ReportViewer to Remote  
            reportViewer1.ProcessingMode = ProcessingMode.Remote;

            ServerReport serverReport = reportViewer1.ServerReport;

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
            serverReport.ReportPath = "/test";
            //"/AdventureWorks Sample Reports/Sales Order Detail";

            // Create the sales order number report parameter  
            //ReportParameter salesOrderNumber = new ReportParameter();
            //salesOrderNumber.Name = "SalesOrderNumber";
            //salesOrderNumber.Values.Add("SO43661");

            // Set the report parameters for the report  
            //reportViewer1.ServerReport.SetParameters(
            //    new ReportParameter[] { salesOrderNumber });

            // Refresh the report  
            reportViewer1.RefreshReport();
            InitializeComponent();

            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.BackColor = System.Drawing.Color.White;

            Controls.Add(reportViewer1);

            // Set the processing mode for the ReportViewer to Remote  
            reportViewer1.ProcessingMode = ProcessingMode.Remote;

            ServerReport serverReport1 = reportViewer1.ServerReport;

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

            if (id.HasValue) // Check if id has a value
            {
                // Create report parameter  
                ReportParameter ID = new ReportParameter();
                ID.Name = "ID"; // Match the parameter name with the one in the stored procedure
                ID.Values.Add(id.Value.ToString()); // Access the value of id using id.Value
                                                           // Set the report parameters for the report  
                reportViewer1.ServerReport.SetParameters(new ReportParameter[] { ID });
            }


            // Refresh the report  
            reportViewer1.RefreshReport();
        }
        private void Report1_Load(object sender, EventArgs e)
        {
        }

    }
}
