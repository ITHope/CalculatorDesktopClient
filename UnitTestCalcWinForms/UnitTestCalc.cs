using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalcWinForms
{
    [TestClass]
    public class UnitTestCalc
    {
        [DataTestMethod]
        [DataRow(0, 0, 0,'+')]
        [DataRow(4, 5, 9, '+')]
        [DataRow(78, 2, 80, '+')]
        [DataRow(0, 0, 0, '-')]
        [DataRow(4, 5, -1, '-')]
        [DataRow(78, 2, 76, '-')]
        [DataRow(1, 1, 1, '*')]
        [DataRow(4, 5, 20, '*')]
        [DataRow(78, 2, 156, '*')]
        [DataRow(1, 1, 1, '/')]
        [DataRow(20, 5, 4, '/')]
        [DataRow(78, 2, 39, '/')]
        public void TestCalc(int a, int b, int exp, char op)
        {
            int res = CalcWinFormsBtns.Calculator.Calc(a, b, op);
            Assert.AreEqual(exp, res);
        }
    }
}
