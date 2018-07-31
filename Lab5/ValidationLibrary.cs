// Matthew Nowakowski
// Modified version of ValidationLibrary from example code
// Last updated 7/31/18

using System;

namespace ValidationLibrary {
	class Validator {
		public static bool IsFilledIn(String strIn) {
			if(strIn.Length > 0) return true;
			else return false;
		}
		
		public static bool IsFilledIn(String strIn, int minLegnth) {
			if(strIn.Length >= minLegnth) return true;
			else return false;
		}

		public static bool IsFilledIn(String strIn, int minLength, int maxLength) {
			if (strIn.Length >= minLength && strIn.Length <= maxLength) return true;
			else return false;
		}
		
		public static bool IsFutureDate(DateTime dtIn) {
			if(dtIn <= DateTime.Now) return true;
			else return false;
		}
		
		public static bool IsValidEmail(String strIn) {
			bool result = true;
			
			int at1 = strIn.IndexOf('@');
			int at2 = strIn.IndexOf('@', at1 + 1);
			int dot = strIn.LastIndexOf('.');
			
			if(at1 < 2) result = false;
			else if (dot + 2 > strIn.Length) result = false;
			return result;
		}

		public static bool IsValidZip(String strIn) {
			bool result = true;

			int hyphen = strIn.IndexOf('-');
			if(hyphen == -1) {
				
			}

			return result;
		}
		
		public static bool IsMinAmount(int numIn, int min) {
			if(numIn >= min) return true;
			else return false;
		}
		
		public static bool IsMinAmount(double numIn, double min) {
			if(numIn >= min) return true;
			else return false;
		}
	}
}