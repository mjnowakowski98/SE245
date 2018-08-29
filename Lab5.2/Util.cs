// Matthew Nowakowski
// Utilities for common functions
// Last updated: 8/22/18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils {
	class Util {
		public static void RemoveWhiteSpace(ref String strIn) {
			while (strIn.IndexOf(' ') != -1)
				strIn = strIn.Remove(strIn.IndexOf(' '), 1);
		}

		public static void RemoveCharacter(ref String strIn, char c) {
			while (strIn.IndexOf(c) != -1)
				strIn = strIn.Remove(strIn.IndexOf(c), 1);
		}

		public static void RemoveCharacter(ref String strIn, char[] c) {
			for(int i = 0; i < c.Length; i++) {
				while (strIn.IndexOf(c[i]) != -1)
					strIn = strIn.Remove(strIn.IndexOf(c[i]), 1);
			}
		}

		public static void Pause() {
			Console.WriteLine("\nPress any key to continue . . .");
			Console.ReadKey();
		}
	}
}
