// Matthew Nowakowski
// Modified version of ValidationLibrary from example code
// Last updated: 8/22/18

using System;
using Utils;

namespace ValidationLibrary {
	class Validator {
		public static bool IsFilledIn(String strIn) {
			bool result = false;
			if(strIn.Length > 0) result = true;
			return result;
		}
		
		public static bool IsFilledIn(String strIn, int minLegnth) {
			bool result = false;
			if(strIn.Length >= minLegnth) result = true;
			return result;
		}

		public static bool IsFilledIn(String strIn, int minLength, int maxLength) {
			bool result = false;
			if (strIn.Length >= minLength && strIn.Length <= maxLength) result = true;
			return result;
		}
		
		public static bool IsFutureDate(DateTime dtIn) {
			bool result = false;
			if(dtIn <= DateTime.Now) result = true;
			return result;
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

			char[] toRemove = { '-', ' ' };
			Util.RemoveCharacter(ref strIn, toRemove);

			Int32 tmp;
			if (!Int32.TryParse(strIn, out tmp)) result = false;
			if(strIn.Length != 5)
				if (strIn.Length != 9) result = false;

			return result;
		}

		public static bool IsValidPhone(String strIn) {
			bool result = true;

			char[] toRemove = { '(', ')', '-', ' ' };
			Util.RemoveCharacter(ref strIn, toRemove);

			Int64 tmp;
			if (!Int64.TryParse(strIn, out tmp) || strIn.Length != 10)
				result = false;

			return result;
		}

		public static bool IsValidURL(String strIn) {
			bool result = true;
			if (!Uri.IsWellFormedUriString(strIn, UriKind.Absolute))
				result = false;
			return result;
		}
		
		public static bool IsMinAmount(int numIn, int min) {
			bool result = false;
			if(numIn >= min) result =  true;
			return result;
		}
		
		public static bool IsMinAmount(double numIn, double min) {
			bool result = false;
			if(numIn >= min) result =  true;
			return result;
		}
	}
}