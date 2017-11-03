using System;
using NUnit.Framework;

namespace NUnitTestCalcWinForms
{
    [TestFixture]
    public class UnitTestCalc
    {
        
        [TestCase(0, 0, 0, '+')]
        [TestCase(4, 5, 9, '+')]
        [TestCase(78, 2, 80, '+')]
        [TestCase(0, 0, 0, '-')]
        [TestCase(4, 5, -1, '-')]
        [TestCase(78, 2, 76, '-')]
        [TestCase(1, 1, 1, '*')]
        [TestCase(4, 5, 20, '*')]
        [TestCase(78, 2, 156, '*')]
        [TestCase(1, 1, 1, '/')]
        [TestCase(20, 5, 4, '/')]
        [TestCase(78, 2, 39, '/')]
        public void TestCalc(int a, int b, int exp, char op)
        {
            int res = CalcWinFormsBtns.Calculator.Calc(a, b, op);
            Assert.AreEqual(exp, res);
        }
    }
}