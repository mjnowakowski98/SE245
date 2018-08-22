// Matthew Nowakowski
// Lab 5 - PersonV2 Class

using System;
using ValidationLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5 {
	class PersonV2 : Person {
		public PersonV2() {
			cellPhone = "";
			facebook = "";
		}

		private String
			cellPhone,
			facebook;

		public String CellPhone {
			get { return cellPhone; }
			set {
				if(Validator.IsValidPhone(value)) {
					cellPhone = value;
					inputValid = true;
				} else {
					feedback += "Error: Cell phone is not formatted correctly\n";
					inputValid = false;
				}
			}
		}

		public String FaceBook {
			get { return facebook; }
			set {
				if(Validator.IsValidURL(value)) {
					facebook = value;
					inputValid = true;
				} else {
					feedback += "Error: FaceBook url is invalid\n";
					inputValid = false;
				}
			}
		}
	}
}
