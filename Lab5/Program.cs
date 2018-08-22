// Matthew Nowakowski
// Lab 5 - Person Class Validation
// Created: 7/31/18
// Draft completed: 8/22/18

using System;
using Utils;

using ValidationLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Person Class Validation Example");

			PersonV2 person = new PersonV2();
			Console.Write("Enter first name: ");
			person.FirstName = Console.ReadLine();

			Console.Write("Enter middle name: ");
			person.MiddleName = Console.ReadLine();

			Console.Write("Enter last name: ");
			person.LastName = Console.ReadLine();

			Console.Write("Enter address line 1: ");
			person.Street1 = Console.ReadLine();

			Console.Write("Enter address line 2: ");
			person.Street2 = Console.ReadLine();

			Console.Write("Enter city: ");
			person.City = Console.ReadLine();

			Console.Write("Enter state (XX):" );
			person.State = Console.ReadLine();

			Console.Write("Enter zip code (nnnnn) or (nnnnn-nnnn): ");
			person.Zip = Console.ReadLine();

			Console.Write("Enter phone number ((nnn)nnn-nnnn): ");
			person.Phone = Console.ReadLine();

			Console.Write("Enter email: ");
			person.Email = Console.ReadLine();

			Console.Write("Enter cell phone: ");
			person.CellPhone = Console.ReadLine();

			Console.Write("Enter FaceBook url: ");
			person.FaceBook = Console.ReadLine();

			Console.WriteLine("\n");
			if (person.Feedback != "")
				Console.WriteLine(person.Feedback);
			else person.Output();

			Util.Pause();
		}
	}
}
