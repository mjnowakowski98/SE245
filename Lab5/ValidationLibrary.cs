// Matthew Nowakowski
// Modified version of ValidationLibrary from example code
// Last updated 8/14/18

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
			int numTmp;
			Util.RemoveWhiteSpace(ref strIn);

			int hyphen = strIn.IndexOf('-');
			if (hyphen != -1) {
				String zip1 = strIn.Substring(0, hyphen);
				String zip2 = strIn.Substring(hyphen + 1);

				if (zip1.Length != 5 || zip2.Length != 4) result = false;
				else if (!Int32.TryParse(zip1, out numTmp) || !Int32.TryParse(zip2, out numTmp)) result = false;
			} else if (strIn.Length != 5 || !Int32.TryParse(strIn, out numTmp)) result = false;

			return result;
		}

		public static bool IsValidPhone(String strIn) {
			bool result = true;
			int numTmp;
			Util.RemoveWhiteSpace(ref strIn);

			int areaCodeDelimiter1 = strIn.IndexOf('(');
			int areaCodeDelimiter2 = strIn.IndexOf(')');
			int hyphen = strIn.IndexOf('-');

			String areaCode = strIn.Substring(areaCodeDelimiter1 + 1, areaCodeDelimiter2 - 1);
			String numPart1 = strIn.Substring(areaCodeDelimiter2 + 1, (hyphen - 1) - areaCodeDelimiter2);
			String numPart2 = strIn.Substring(hyphen + 1);

			if (areaCode.Length != 3 || numPart1.Length != 3 || numPart2.Length != 4)
				result = false;
			else if (!Int32.TryParse(areaCode, out numTmp)
				|| !Int32.TryParse(numPart1, out numTmp)
				|| !Int32.TryParse(numPart2, out numTmp)) result = false;

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