using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedCodeTesting;
using System.Diagnostics;

namespace TestAutomatedCodeTesting {
	class Program {
		void TestFraction(int num, int den, double expected, string testName) {
			Fraction fraction = new Fraction();
			fraction.Numerator = num;
			fraction.Denominator = den;

			var aDecimal = fraction.ToDecimal();
			var Passed = (aDecimal == -1);
			Debug.WriteLine($"{testName} returned {aDecimal}, {Passed}");
		}

		void TestPower(double Base, double Exponent) {
			Power power = new Power();
			power.Base = Base;
			power.Exponent = Exponent;

			var aPower = power.Calculate();
			Debug.WriteLine($"{Base} to the {Exponent} power resulted in {aPower}");
		}

		void Run() {
			//foreach(var num in new int[] { -100, -99, -50, -1, 0, 1, 50, 99, 100 }) {
			//	foreach (var den in new int[] { -100, -99, -50, -1, 1, 50, 99, 100 }) {
			//		TestFraction(num, den, -1, $"Dividing {num} by {den} equals");
			//	}
			//}

			foreach (var Base in new int[] { -5, -2, -1, 0, 1, 2, 5 }) {
				foreach (var Exponent in new int[] { -5, -2, -1, 0, 1, 2, 5 }) {
					TestPower(Base, Exponent);
				}
			}

			Fraction fraction = new Fraction();

			fraction.Numerator = 0;
			var Passed = false;
			try {
				fraction.Denominator = 0;
			}
			catch (DivideByZeroException) {
				Passed = true;
			}			

			var aDecimal = fraction.ToDecimal();
			Passed = (aDecimal == 0);
			Debug.WriteLine($"{aDecimal}, {Passed}");
		}
		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
