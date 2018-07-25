// Matthew Nowakowski
// Lab 3 - Even Fancier Payroll Calculator
// Now with methods
// Created 7/25/18
// Draft completed 7/25/18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
	class Program {
		// Constants
		const int kNumWeeksPerYear = 52;
		static Double[] kTaxCutoffs = { // Cutoff income for tax brackets
				9525, 38700, 82500, 157500, 200000, 500000
			};
		static Double[] kTaxPercents = { // Percentages for tax brackets
				.10, .12, .22, .24, .32, .35, .37
			};

		// Small struct to store info per employee
		public struct EmployeeInfo {
			// User input
			public String sEmployeeName;
			public Double
				numHourlyRate,
				numHoursWorked;

			// Calculated
			public Double
				numGrossPay,
				numGrossPerYear,
				numNetPay,
				numTaxesDeducted;
		}

		// Determine tax bracket based on estimated gross/year
		static ushort GetTaxBracket(Double grossPerYear) {
			ushort taxNdx = 0;
			while (grossPerYear > kTaxCutoffs[taxNdx]) taxNdx++;
			return taxNdx;
		}

		// Output information
		static void Output(ref List<EmployeeInfo> employees) {
			foreach (EmployeeInfo obj in employees) {
				Console.WriteLine("\n"); // 2 newlines
				Console.WriteLine("Payroll information for employee: " + obj.sEmployeeName);
				Console.WriteLine("Hourly rate:                      " + obj.numHourlyRate);
				Console.WriteLine("Hours worked:                     " + obj.numHoursWorked);
				Console.WriteLine("Gross pay:                        " + obj.numGrossPay);
				Console.WriteLine("Estimated yearly gross pay:       " + obj.numGrossPerYear);
				Console.WriteLine("Taxes deducted:                   " + obj.numTaxesDeducted);
				Console.WriteLine("Net pay this week:                " + obj.numNetPay);
			}
		}

		static void Pause() { // Emulate DOS shell pause
			Console.WriteLine(" Press any key to continue . . . ");
			Console.ReadKey();
		}

		static void Main(string[] args) {
			Console.WriteLine("Payroll Calculator"); // Output program name

			List<EmployeeInfo> employees = new List<EmployeeInfo>(); // Hold information on all employees

			// Main application loop
			while (true) {
				EmployeeInfo tmp = new EmployeeInfo(); // Builder struct

				Console.Write("\n");

				// Get employee name
				do {
					Console.Write("Enter employee name (type 'done' to stop): ");
					tmp.sEmployeeName = Console.ReadLine();
				} while (tmp.sEmployeeName == "");
				if (tmp.sEmployeeName == "done") break; // Stop entering names if done

				String inputBuffer = ""; // Buffer to hold input to number
				do { // Input hourly rate
					Console.Write("Enter hourly pay rate: ");
					inputBuffer = Console.ReadLine();
				} while (!Double.TryParse(inputBuffer, out tmp.numHourlyRate));

				inputBuffer = ""; // Clear buffer
				do { // Input hours worked
					Console.Write("Enter hours worked: ");
					inputBuffer = Console.ReadLine();
				} while (!Double.TryParse(inputBuffer, out tmp.numHoursWorked));

				// Calculate gross pay per week & estimate per year
				tmp.numGrossPay = tmp.numHourlyRate * tmp.numHoursWorked;
				tmp.numGrossPerYear = tmp.numGrossPay * kNumWeeksPerYear;

				// Set tax percentage
				ushort taxNdx = GetTaxBracket(tmp.numGrossPerYear);
				tmp.numNetPay = tmp.numGrossPay - (tmp.numGrossPay * kTaxPercents[taxNdx]); // Calculate net pay
				tmp.numTaxesDeducted = tmp.numGrossPay * kTaxPercents[taxNdx]; // Calculate deducted taxes

				employees.Add(tmp); // Copy builder to new ndx of employee list
			}

			Output(ref employees); // Output results
			Pause(); // Let them read
		}
	}
}
