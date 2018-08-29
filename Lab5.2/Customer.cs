using System;
using ValidationLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5 {
	class Customer : Person {
		public Customer() {
			customerSince = new DateTime();
			totalPurchases = 0.0;
			discountMember = false;
			rewardsEarned = 0;
		}

		private DateTime customerSince;
		private Double totalPurchases;
		private bool discountMember;
		private Int32 rewardsEarned;

		// Public methods
		public new void Output() { // Output using class properties
			Console.WriteLine("\nInformation for " + LastName + ", " + FirstName + " " + MiddleName + ": ");
			Console.WriteLine("Address:");
			Console.WriteLine("\t" + Street1);
			Console.WriteLine("\t" + Street2);
			Console.WriteLine("\t" + City + ", " + State);
			Console.WriteLine("\t" + Zip);
			Console.WriteLine("Phone: " + Phone);
			Console.WriteLine("Email: " + Email);
			Console.WriteLine("Customer Since:" + CustomerSince.ToString("MM/dd/yyyy"));
			Console.WriteLine("Total Purchases: " + TotalPurchases);
			if (DiscountMember) {
				Console.WriteLine("Is a discount member");
				Console.WriteLine("Rewards earned: " + RewardsEarned);
			} else Console.WriteLine("Not a discount member");
		}

		public DateTime CustomerSince {
			get { return customerSince; }
			set {
				if (!Validator.IsFutureDate(value)) {
					customerSince = value;
					inputValid = true;
				} else {
					inputValid = false;
					feedback += "Error: Customer since date is invalid or in the future\n";
				}
			}
		}

		public Double TotalPurchases {
			get { return totalPurchases; }
			set {
				if (value >= 0) {
					totalPurchases = value;
					inputValid = true;
				} else {
					inputValid = false;
					feedback += "Error: Total purchases is invalid or less than zero\n";
				}
			}
		}

		public bool DiscountMember {
			get { return discountMember; }
			set { discountMember = value; }
		}

		public Int32 RewardsEarned {
			get { return rewardsEarned; }
			set {
				if(value >= 0) {
					rewardsEarned = value;
					inputValid = true;
				} else {
					inputValid = false;
					feedback += "Error: Rewards earned is invalid or less than zero\n";
				}
			}
		}
	}
}
