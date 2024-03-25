using Data.Models;
using ExSys.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using ExSys.MyModels;
using System.Data;
using ExSys.Forms.Reports;
namespace ExSys
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             Application.Run(new loginForm());

            ExSysContext db = new ExSysContext();

		}
	}
}