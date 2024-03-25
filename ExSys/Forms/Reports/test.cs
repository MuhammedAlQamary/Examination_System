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
    public partial class test : Form
    {
        ReportViewer reportViewer2 = new ReportViewer();
        public test()
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
            reportViewer2.RefreshReport();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
