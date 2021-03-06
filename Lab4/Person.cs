﻿// Matthew Nowakowski
// Lab 4 - Person Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4 {
	class Person {
		// Example public variables
		// public String
		// 	fName,
		// 	mName,
		// 	lName,
		// 	street1,
		// 	street2,
		// 	city,
		// 	state,
		// 	zip,
		// 	phone,
		// 	email;

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

		// Accessors/Mutators
		// (Not validating untill Lab5)
		public String FirstName {
			get { return fName; }
			set { fName = value; }
		}

		public String MiddleName {
			get { return mName; }
			set { mName = value; }
		}

		public String LastName {
			get { return lName; }
			set { lName = value;  }
		}

		public String Street1 {
			get { return street1; }
			set { street1 = value; }
		}

		public String Street2 {
			get { return street2; }
			set { street2 = value; }
		}

		public String City {
			get { return city; }
			set { city = value; }
		}

		public String State {
			get { return state; }
			set { state = value; }
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

			// Example output using public vars
			// Console.WriteLine(fName);
			// Console.WriteLine(mName);
			// Console.WriteLine(lName);
			// Console.WriteLine(street1);
			// Console.WriteLine(street2);
			// Console.WriteLine(city);
			// Console.WriteLine(state);
			// Console.WriteLine(zip);
			// Console.WriteLine(phone);
			// Console.WriteLine(email);
		}
	}
}