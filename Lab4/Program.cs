// Matthew Nowakowski
// Lab 4 - Structs/Classes Example
// Created 7/26/18
// Draft completed 7/31/18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4 {
	// Example structure
	// public struct Person {
	// 	public String
	// 		fName,
	// 		mName,
	// 		lName,
	// 		street1,
	// 		street2,
	// 		city,
	// 		state,
	// 		zip,
	// 		phone,
	// 		email;
	// }

	class Program {
		static void Pause() {
			Console.WriteLine(" Press any key to continue . . .");
			Console.ReadKey();
		}

		static void Main(string[] args) {
			Person person = new Person();
			Console.Write("Enter first name: ");
			person.FirstName = Console.ReadLine();
			// person.fName = Console.ReadLine();
			// person.fName += "-Edited";

			Console.Write("Enter middle name: ");
			person.MiddleName = Console.ReadLine();
			// person.mName = Console.ReadLine();

			Console.Write("Enter last name: ");
			person.LastName = Console.ReadLine();
			// person.lName = Console.ReadLine();

			Console.Write("Enter street1: ");
			person.Street1 = Console.ReadLine();
			// person.street1 = Console.ReadLine();

			Console.Write("Enter street2: ");
			person.Street2 = Console.ReadLine();
			// person.street2 = Console.ReadLine();

			Console.Write("Enter city: ");
			person.City = Console.ReadLine();
			// person.city = Console.ReadLine();

			Console.Write("Enter state: ");
			person.State = Console.ReadLine();
			// person.state = Console.ReadLine();

			Console.Write("Enter zip code: ");
			person.Zip = Console.ReadLine();
			// person.zip = Console.ReadLine();

			Console.Write("Enter phone: ");
			person.Phone = Console.ReadLine();
			// person.phone = Console.ReadLine();

			Console.Write("Enter email: ");
			person.Email = Console.ReadLine();
			// person.email = Console.ReadLine();
			person.Output();
			Pause();

			// Example struct input
			// Person person = new Person();
			// person.fName = Console.ReadLine();
			// person.mName = Console.ReadLine();
			// person.lName = Console.ReadLine();
			// person.street1 = Console.ReadLine();
			// person.street2 = Console.ReadLine();
			// person.city = Console.ReadLine();
			// person.state = Console.ReadLine();
			// person.zip = Console.ReadLine();
			// person.phone = Console.ReadLine();
			// person.email = Console.ReadLine();

			// Example struct output
			// Console.WriteLine(person.fName);
			// Console.WriteLine(person.mName);
			// Console.WriteLine(person.lName);
			// Console.WriteLine(person.street1);
			// Console.WriteLine(person.street2);
			// Console.WriteLine(person.city);
			// Console.WriteLine(person.state);
			// Console.WriteLine(person.zip);
			// Console.WriteLine(person.phone);
			// Console.WriteLine(person.email);
		}
	}
}
