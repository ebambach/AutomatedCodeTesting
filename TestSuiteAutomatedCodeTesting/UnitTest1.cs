using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedCodeTesting;

namespace TestSuiteAutomatedCodeTesting {
	[TestClass]
	public class UnitTest1 {
		//[TestMethod]
		//public void TestNum100Den100Exp1() {
		//	Fraction fraction = new Fraction();
		//	fraction.Numerator = 100;
		//	fraction.Denominator = 100;
		//	var result = fraction.ToDecimal();
		//	Assert.AreEqual(1, result, $"{fraction.Numerator} / {fraction.Denominator} resulted in {result}");

		//	fraction.Numerator = 99;
		//	fraction.Denominator = 99;
		//	result = fraction.ToDecimal();
		//	Assert.AreEqual(1, result, $"{fraction.Numerator} / {fraction.Denominator} resulted in {result}");
		//}
		//[TestMethod]
		//[ExpectedException(typeof(DivideByZeroException))]
		//public void TestForZeroDenominator() {
		//	Fraction fraction = new Fraction();
		//	fraction.Numerator = 0;
		//	fraction.Denominator = 0;
		//	//var result = fraction.ToDecimal();
		//	//Assert.AreEqual(0, result, $"{fraction.Numerator} / {fraction.Denominator} resulted in {result}");
		//}
		
		//The first two [TestMethod]s were written so that the
		//first should succeed, and the second should fail.
		//The [TestMethod]s that follow test specific
		//circumstances.
		[TestMethod]
		public void TestPowerShouldPass() {
			Power power = new Power();
			power.Base = 2;
			power.Exponent = 3;
			var result = power.Calculate();
			Assert.AreEqual(8, result, $"{power.Base} multiplied to the {power.Exponent} power resulted in {result}");
		}
		[TestMethod]
		public void TestPowerShouldFail() {
			Power power = new Power();
			power.Base = 2;
			power.Exponent = 3;
			var result = power.Calculate();
			Assert.AreEqual(4, result, $"{power.Base} multiplied to the {power.Exponent} power resulted in {result}");
		}
		//What happens when 0 is the Base? 0 should be returned.
		[TestMethod]
		public void TestPowerBase0() {
			Power power = new Power();
			power.Base = 0.0;
			power.Exponent = 3.0;
			var result = power.Calculate();
			Assert.AreEqual(0, result, $"{power.Base} multiplied to the {power.Exponent} power resulted in {result}");
		}
		//What happenes when 0 is the Exponent? 1 should be returned.
		[TestMethod]
		public void TestPowerExp0() {
			Power power = new Power();
			power.Base = 2.0;
			power.Exponent = 0.0;
			var result = power.Calculate();
			Assert.AreEqual(1, result, $"{power.Base} multiplied to the {power.Exponent} power resulted in {result}");
		}
		//What happens when the Exponent is negative? A double should be
		//returned that equivalent to (1/(Base^Exponent))
		[TestMethod]
		public void TestPowerNegativeExp() {
			Power power = new Power();
			power.Base = 2;
			power.Exponent = -2;
			var result = power.Calculate();
			Assert.AreEqual(0.25, result, $"{power.Base} multiplied to the {power.Exponent} power resulted in {result}");
		}
		//To be on the safe side, let's see what happens when the Base
		//is negative.  It shouldn't result in a fail, but we want to test
		//anyway.
		[TestMethod]
		public void TestPowerNegativeBase() {
			Power power = new Power();
			power.Base = -2;
			power.Exponent = 3;
			var result = power.Calculate();
			Assert.AreEqual(-8, result, $"{power.Base} multiplied to the {power.Exponent} power resulted in {result}");
		}
	}
}
