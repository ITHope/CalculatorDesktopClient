using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace UITestCalcWinForms
{
    [TestClass]
    public class UITestCalcWFBtns
    {
        public static Application application;

        [TestCleanup]
        public void TestTearDown()
        {
            application.Close();
        }

        [TestInitialize]
        public void SetUp()
        {
            application = Application.Launch("E:\\CSharpDev\\Projects\\Calculator\\CalculatorWindowsForms\\CalcWinFormsBtns\\bin\\Debug\\CalcWinFormsBtns.exe");
            Assert.IsNotNull(application);
        }


        [DataTestMethod]
        [DataRow("btn0", "0")]
        [DataRow("btn1", "1")]
        [DataRow("btn2", "2")]
        [DataRow("btn3", "3")]
        [DataRow("btn4", "4")]
        [DataRow("btn5", "5")]
        [DataRow("btn6", "6")]
        [DataRow("btn7", "7")]
        [DataRow("btn8", "8")]
        [DataRow("btn9", "9")]
        [DataRow("btnPlus", "+")]
        [DataRow("btnMinus", "-")]
        [DataRow("btnDiv", "/")]
        [DataRow("btnMult", "*")]
        [DataRow("btnRes", "=")]
        public void TestGetAllElem(string id, string exp)
        {
            application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId(id));
            string res = application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId(id)).Text.ToString();
            Assert.AreEqual(exp, res);
        }

        [DataTestMethod]
        [DataRow("btn0", "0")]
        [DataRow("btn1", "1")]
        [DataRow("btn2", "2")]
        [DataRow("btn3", "3")]
        [DataRow("btn4", "4")]
        [DataRow("btn5", "5")]
        [DataRow("btn6", "6")]
        [DataRow("btn7", "7")]
        [DataRow("btn8", "8")]
        [DataRow("btn9", "9")]
        [DataRow("btnPlus", "+")]
        [DataRow("btnMinus", "-")]
        [DataRow("btnDiv", "/")]
        [DataRow("btnMult", "*")]
        [DataRow("btnRes", "")]
        public void TestUseAllElem(string id, string exp)
        {
            application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId(id)).Click();
            string res = application.GetWindow("Calculator").Get<TextBox>(SearchCriteria.ByAutomationId("tbCalc")).Text.ToString();
            Assert.AreEqual(exp, res);
        }


        [DataTestMethod]
        [DataRow(new string[] { "btn1", "btn2", "btn3" }, "123")]
        [DataRow(new string[] { "btn4", "btn5", "btn6" }, "456")]
        [DataRow(new string[] { "btn7", "btn8" }, "78")]
        [DataRow(new string[] { "btn9", "btn0" }, "90")]
        public void TestComplexUseElem(string[] id, string exp)
        {
            foreach (string str in id)
            {
                application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId(str)).Click();
            }

            string res = application.GetWindow("Calculator").Get<TextBox>(SearchCriteria.ByAutomationId("tbCalc")).Text.ToString();
            Assert.AreEqual(exp, res);
        }

        [DataTestMethod]
        [DataRow(new string[] { "btn1", "btnPlus", "btn3" }, "4")]
        [DataRow(new string[] { "btn4", "btnPlus", "btn6" }, "10")]
        [DataRow(new string[] { "btn7", "btn8", "btnPlus", "btn2" }, "80")]
        [DataRow(new string[] { "btn9", "btn0", "btnPlus", "btn3" }, "93")]
        public void TestRealJobPlus(string[] id, string exp)
        {
            foreach (string str in id)
            {
                application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId(str)).Click();
            }
            application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId("btnRes")).Click();
            string res = application.GetWindow("Calculator").Get<TextBox>(SearchCriteria.ByAutomationId("tbCalc")).Text.ToString();
            Assert.AreEqual(exp, res);
        }

        [DataTestMethod]
        [DataRow(new string[] { "btn1", "btnMinus", "btn3" }, "-2")]
        [DataRow(new string[] { "btn4", "btnMinus", "btn6" }, "-2")]
        [DataRow(new string[] { "btn7", "btn8", "btnMinus", "btn2" }, "76")]
        [DataRow(new string[] { "btn9", "btn0", "btnMinus", "btn3" }, "87")]
        public void TestRealJobMinus(string[] id, string exp)
        {
            foreach (string str in id)
            {
                application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId(str)).Click();
            }
            application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId("btnRes")).Click();
            string res = application.GetWindow("Calculator").Get<TextBox>(SearchCriteria.ByAutomationId("tbCalc")).Text.ToString();
            Assert.AreEqual(exp, res);
        }

        [DataTestMethod]
        [DataRow(new string[] { "btn1", "btnMult", "btn3" }, "3")]
        [DataRow(new string[] { "btn4", "btnMult", "btn6" }, "24")]
        [DataRow(new string[] { "btn7", "btn8", "btnMult", "btn2" }, "156")]
        [DataRow(new string[] { "btn9", "btn0", "btnMult", "btn3" }, "270")]
        public void TestRealJobMult(string[] id, string exp)
        {
            foreach (string str in id)
            {
                application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId(str)).Click();
            }
            application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId("btnRes")).Click();
            string res = application.GetWindow("Calculator").Get<TextBox>(SearchCriteria.ByAutomationId("tbCalc")).Text.ToString();
            Assert.AreEqual(exp, res);
        }

        [DataTestMethod]
        [DataRow(new string[] { "btn3", "btnDiv", "btn1" }, "3")]
        [DataRow(new string[] { "btn6", "btnDiv", "btn6" }, "1")]
        [DataRow(new string[] { "btn7", "btn8", "btnDiv", "btn2" }, "39")]
        [DataRow(new string[] { "btn9", "btn0", "btnDiv", "btn3" }, "30")]
        public void TestRealJobDiv(string[] id, string exp)
        {
            foreach (string str in id)
            {
                application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId(str)).Click();
            }
            application.GetWindow("Calculator").Get<Button>(SearchCriteria.ByAutomationId("btnRes")).Click();
            string res = application.GetWindow("Calculator").Get<TextBox>(SearchCriteria.ByAutomationId("tbCalc")).Text.ToString();
            Assert.AreEqual(exp, res);
        }
    }
}
