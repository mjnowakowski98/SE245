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
	public partial class Mainform : Form {
		public Mainform() {
			InitializeComponent();
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			Search tmp = new Lab7.Search();
			tmp.Show();
		}
	}
}
