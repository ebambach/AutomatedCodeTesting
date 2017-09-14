using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedCodeTesting;
using System.Diagnostics;

namespace TestAutomatedCodeTesting {
	class Program {
		void Test(int num, int den, double expected, string testName) {
			Fraction fraction = new Fraction();
			fraction.Numerator = num;
			fraction.Denominator = den;

			var aDecimal = fraction.ToDecimal();
			var Passed = (aDecimal == -1);
			Debug.WriteLine($"{testName} returned {aDecimal}, {Passed}");
		}

		void Run() {
			foreach(var num in new int[] { -100, -99, -50, -1, 0, 1, 50, 99, 100 }) {
				foreach (var den in new int[] { -100, -99, -50, -1, 1, 50, 99, 100 }) {
					Test(num, den, -1, $"Dividing {num} by {den} equals");
				}
			}
			
			//Test(-100, 100, -1, "Dividing 100 by -100 should be -1");
			//Test(99, -99, -1, "Dividing 99 by -99 should be -1");
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
