using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedCodeTesting {
	public class Power {
		public double Base { get; set; }
		public double Exponent { get; set; }

		public double Calculate() {
			double Product = Base;
			if (Exponent == 0 && Base != 0) {
				return 1;
			}
			if (Exponent >= 0) {
				var Counter = 1;
				while (Counter < Exponent) {
					Product *= Base;
					Counter++;
				}
				return Product;
			}
			else {
				var Counter = -1;
				while (Counter > Exponent) {
					Product *= Base;
					Counter--;
				}
				return (1/Product);
			}
		}
	}
}
