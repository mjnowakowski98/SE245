// Matthew Nowakowski
// Lab 5 - PersonV2 Class

using System;
using ValidationLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Console {
	class PersonV2 : Person {
		public PersonV2() {
			cellPhone = "";
			facebook = "";
		}

		private String
			cellPhone,
			facebook;

		// Public methods
		public new void Output() { // Output using class properties
			Console.WriteLine("\nInformation for " + LastName + ", " + FirstName + " " + MiddleName + ": ");
			Console.WriteLine("Address:");
			Console.WriteLine("\t" + Street1);
			Console.WriteLine("\t" + Street2);
			Console.WriteLine("\t" + City + ", " + State);
			Console.WriteLine("\t" + Zip);
			Console.WriteLine("Phone: " + Phone);
			Console.WriteLine("Cell Phone: " + CellPhone);
			Console.WriteLine("Email: " + Email);
			Console.WriteLine("Facebook URL: " + FaceBook);
		}

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
