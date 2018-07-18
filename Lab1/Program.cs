// Matthew Nowakowski
// Lab1 - Payroll Calculaltor
// Created 7/18/18
// Draft completed 7/18/18

// Assumes single filing status using static tax brackets on pay/year
// Cutoff values found at: https://taxfoundation.org/2018-tax-brackets/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 {
	class Program {
		static void Main(string[] args) {
			// Constants
			const int kNumWeeksPerYear = 52;

			double[] kTaxCutoffs = { // Cutoff income for tax brackets
				9525, 38700, 82500, 157500, 200000, 500000
			};

			double[] kTaxPercents = { // Percentages for tax brackets
				.10, .12, .22, .24, .32, .35, .37
			};

			// User vars
			String inputBuffer = "";
			String sEmployeeName = "";
			double	numHoursWorked = 0,
					numPayRate = 0;

			// Output program name
			Console.WriteLine("Payroll Calculator");

			// Get employee name
			do {
				Console.Write("Enter employee name: ");
				sEmployeeName = Console.ReadLine();
			} while (sEmployeeName == "");

			// Get hourly rate
			inputBuffer = "";
			do {
				Console.Write("Enter pay rate: ");
				inputBuffer = Console.ReadLine();
			}
			while (!double.TryParse(inputBuffer, out numPayRate));

			// Get hours worked
			inputBuffer = "";
			do {
				Console.Write("Enter hours worked: ");
				inputBuffer = Console.ReadLine();
			}
			while (!double.TryParse(inputBuffer, out numHoursWorked));

			// Tax variables
			double	numNetPay = 0,
					numGrossPay = numHoursWorked * numPayRate,
					numGrossPayPerYear = numGrossPay * kNumWeeksPerYear;

			// Set tax percentage
			ushort taxNdx = 0;
			while(numGrossPayPerYear > kTaxCutoffs[taxNdx]) { taxNdx++; }

			numNetPay = numGrossPay - (numGrossPay * kTaxPercents[taxNdx]); // Calculate net pay

			// Output values
			Console.WriteLine("Paycheck info for employee: " + sEmployeeName);
			Console.WriteLine("Gross pay: " + numGrossPay);
			Console.WriteLine("Estimated gross/year: " + numGrossPayPerYear);
			Console.WriteLine("Net pay this week: " + numNetPay);

			// Emulate dos shell pause
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}
	}
}
