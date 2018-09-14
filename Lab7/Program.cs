// Matthew Nowakowski
// Lab 8 - Update/Delete records from database
// Based from Lab 7
// Started 9/14/18 4:22 AM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7 {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Mainform());
		}
	}
}
