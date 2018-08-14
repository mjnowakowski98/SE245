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

		public static void Pause() {
			Console.Write("\nPress any key to continue . . .");
			Console.ReadKey();
		}
	}
}
