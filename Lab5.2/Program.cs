// Matthew Nowakowski
// Lab 5 - Person Class Validation
// Created: 7/31/18
// Draft completed: 8/22/18

using System;
using System.Globalization;
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

			Customer person = new Customer();
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

			Console.Write("Enter customer since date (mm/dd/yyyy): ");
			DateTime dtBuffer;
			if (DateTime.TryParse(Console.ReadLine(), out dtBuffer))
				person.CustomerSince = dtBuffer;
			else person.CustomerSince = DateTime.Now.AddDays(1);

			Console.Write("Enter number of purchases: ");
			Int32 numBuffer;
			if (Int32.TryParse(Console.ReadLine(), out numBuffer))
				person.TotalPurchases = numBuffer;
			else person.TotalPurchases = -1;

			Console.Write("Is rewards card member (Y/N): ");
			char c = Console.ReadKey().KeyChar;
			if (c == 'Y' || c == 'y') person.DiscountMember = true;
			else person.DiscountMember = false;

			if(person.DiscountMember) {
				Console.Write("\nEnter number of rewards earned: ");
				if (Int32.TryParse(Console.ReadLine(), out numBuffer))
					person.RewardsEarned = numBuffer;
				else person.RewardsEarned = -1;
			}

			Console.WriteLine("\n");
			if (person.Feedback != "")
				Console.WriteLine(person.Feedback);
			else person.Output();

			Util.Pause();
		}
	}
}
