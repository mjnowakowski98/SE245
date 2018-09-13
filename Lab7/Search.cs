using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7 {
	public partial class Search : Form {
		public Search() {
			InitializeComponent();
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			PersonV2 tmp = new PersonV2();
			String fName = tbFName.Text;
			String mName = tbMName.Text;
			String lName = tbLName.Text;
			String street1 = tbStreet1.Text;
			String street2 = tbStreet2.Text;
			String city = tbCity.Text;
			String state = tbState.Text;
			String zip = tbZip.Text;
			String phone = tbPhone.Text;
			String cellPhone = tbCellPhone.Text;
			String facebook = tbFacebook.Text;
			DataSet ds = tmp.SearchRecords(fName, mName, lName, street1, street2, city, state,
				zip, phone, cellPhone, facebook);

			dgvOutput.DataSource = ds;
			dgvOutput.DataMember = ds.Tables["Persons"].ToString();

			tbOutput.Text = tmp.Feedback;
		}

		private void dgvOutput_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			Int32 id = Int32.Parse(dgvOutput.Rows[e.RowIndex].Cells[0].Value.ToString());
			Editor editor = new Editor(id);
			editor.ShowDialog();
		}
	}
}
