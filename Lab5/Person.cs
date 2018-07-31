// Matthew Nowakowski
// Lab 5 - Person Class

using System;
using ValidationLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5 {
	class Person {
		private String
			fName,
			mName,
			lName,
			street1,
			street2,
			city,
			state,
			zip,
			phone,
			email;

		private String feedback = "";
		private bool inputValid = false;

		// Read-only
		public String Feedback {
			get { return feedback; }
		}

		public bool LastInputvalid {
			get { return inputValid;  }
		}

		// Accessors/Mutators (Read/Write)
		public String FirstName {
			get { return fName; }
			set {
				if (Validator.IsFilledIn(value)) {
					fName = value;
					inputValid = true;
				} else {
					feedback += "Error: First name was empty\n";
					inputValid = false;
				}
			}
		}

		// Can be empty
		public String MiddleName {
			get { return mName; }
			set { mName = value; }
		}

		public String LastName {
			get { return lName; }
			set {
				if (Validator.IsFilledIn(value)) {
					lName = value;
					inputValid = true;
				} else {
					feedback += "Error: Last name was empty\n";
					inputValid = false;
				}
			}
		}

		public String Street1 {
			get { return street1; }
			set {
				if (Validator.IsFilledIn(value)) {
					street1 = value;
					inputValid = true;
				} else {
					feedback += "Error: Street 1 was empty\n";
					inputValid = false;
				}
			}
		}

		// Can be empty
		public String Street2 {
			get { return street2; }
			set { street2 = value; }
		}

		public String City {
			get { return city; }
			set {
				if (Validator.IsFilledIn(value)) {
					city = value;
					inputValid = true;
				} else {
					feedback += "Error: City was empty\n";
					inputValid = false;
				}
			}
		}

		public String State {
			get { return state; }
			set {
				if (Validator.IsFilledIn(value, 2, 2)) {
					state = value;
					inputValid = true;
				} else {
					feedback += "Error: State was invalid\n";
					inputValid = false;
				}
			}
		}

		public String Zip {
			get { return zip; }
			set { zip = value; }
		}

		public String Phone {
			get { return phone; }
			set { phone = value; }
		}

		public String Email {
			get { return email; }
			set { email = value; }
		}

		public void Output() { // Output using class properties
			Console.WriteLine("\nInformation for " + LastName + ", " + FirstName + " " + MiddleName + ": ");
			Console.WriteLine("Address:");
			Console.WriteLine("\t" + Street1);
			Console.WriteLine("\t" + Street2);
			Console.WriteLine("\t" + City + ", " + State);
			Console.WriteLine("\t" + Zip);
			Console.WriteLine("Phone: " + Phone);
			Console.WriteLine("Email: " + Email);
		}
	}
}