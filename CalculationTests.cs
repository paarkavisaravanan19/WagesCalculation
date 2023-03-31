using Microsoft.VisualStudio.TestTools.UnitTesting;
using WagesCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagesCalculation.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void CalculateWageTest()
        {
            Calculation calculation = new Calculation();
            calculation.CalculateWage(new double[] { 9, 17, 30, 1.5 });
            double actual = calculation.wage;
            Assert.AreEqual(240, actual);
            	
        }
    }
}