using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
	class Program {
		struct EmployeeInfo {
			String sEmployeeName;
			Double numHourlyRate,
				numHoursWorked;
				
			Double numGrossPay,
				numGrossPerYear,
				numNetPay;
		}

		static void Main(string[] args) {
			// Constants
			const int kNumWeeksPerYear = 52;

			Int32[] kTaxCutoffs = { // Cutoff income for tax brackets
				9525, 38700, 82500, 157500, 200000, 500000
			};

			Double[] kTaxPercents = { // Percentages for tax brackets
				.10, .12, .22, .24, .32, .35, .37
			};

			// Output program name
			Console.WriteLine("Payroll Calculator");

			List<EmployeeInfo> employees = new List<EmployeeInfo>();

			// Main application loop
			while (true) {
				// Get employee name
				String tmpName = "";
				do {
					Console.Write("Enter employee name (type 'done' to stop): ");
					tmpName = Console.ReadLine();
				} while (tmpName == "");
				if (tmpName == "done") break; // Stop entering names if done

				String inputBuffer = "";
				Double tmpHourlyRate = 0;
				do {
					Console.Write("Enter hourly pay rate: ");
					inputBuffer = Console.ReadLine();
				} while (!Double.TryParse(inputBuffer, out tmpHourlyRate));

				inputBuffer = "";
				Double tmpHours = 0;
				do {
					Console.Write("Enter hours worked: ");
					inputBuffer = Console.ReadLine();
				} while (!Double.TryParse(inputBuffer, out tmpHours));

				

				employees.Add(new EmployeeInfo(tmpName, tmpHourlyRate, tmpHours));
			}



			// Emulate dos shell pause
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}
	}
}
