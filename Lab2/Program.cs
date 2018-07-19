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
				numHoursWorked,
				numGrossPay,
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

			// User vars
			String inputBuffer = "";
			String sEmployeeName = "";
			Double numHoursWorked = 0,
					numPayRate = 0;

			// Output program name
			Console.WriteLine("Payroll Calculator");

			

			// Emulate dos shell pause
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}
	}
}
