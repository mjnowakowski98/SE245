using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7 {
	public partial class Editor : Form {
		private bool updateMode;
		private PersonV2 tmp = new PersonV2();

		public Editor() {
			InitializeComponent();
			btnDelete.Enabled = false;
			updateMode = false;
		}

		public Editor(int id) {
			InitializeComponent();
			btnSubmit.Text = "Update";
			updateMode = true;

			SqlDataReader dr = tmp.GetRecord(id);
			while (dr.Read()) {
				lblId.Text = dr["ID"].ToString();
				tbFName.Text = dr["FName"].ToString();
				tbMName.Text = dr["MName"].ToString();
				tbLName.Text = dr["LName"].ToString();
				tbStreet1.Text = dr["Street1"].ToString();
				tbStreet2.Text = dr["Street2"].ToString();
				tbCity.Text = dr["City"].ToString();
				tbState.Text = dr["State"].ToString();
				tbZip.Text = dr["Zip"].ToString();
				tbPhone.Text = dr["Phone"].ToString();
				tbCellPhone.Text = dr["CellPhone"].ToString();
				tbFaceBook.Text = dr["Facebook"].ToString();
			}

			dr.Close();
		}

		private void btnSubmit_Click(object sender, EventArgs e) {
			if(updateMode) {
				// Do nothing until lab 8
			} else {
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

				tmp.AddRecord();
				tbOutput.Text = tmp.Feedback;
			}
		}
	}
}
