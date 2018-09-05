using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6Console {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void btnSubmit_Click(object sender, EventArgs e) {
			PersonV2 tmp = new PersonV2();
			tmp.FirstName = tbFName.Text;
			tmp.MiddleName = tbMName.Text;
			tmp.LastName = tbLName.Text;
			tmp.Street1 = tbStreet1.Text;
			tmp.Street2 = tbStreet2.Text;
			tmp.City = tbCity.Text;
			tmp.State = tbState.Text;
			tmp.Zip = tbZip.Text;
			tmp.Phone = tbPhone.Text;
			tmp.CellPhone = tbCellPhone.Text;
			tmp.FaceBook = tbFaceBook.Text;

			if (!tmp.InputValid) {
				tbOutput.Text = tmp.Feedback;
				tbOutput.Text += "Invalid form input detected";
				return;
			}

			tmp.AddRecord();
			tbOutput.Text = tmp.Feedback;
		}
	}
}
