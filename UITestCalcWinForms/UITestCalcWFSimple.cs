using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace UITestCalcWinForms
{
    [TestClass]
    public class UITestCalcWFSimple
    {

        public static Application application;

        [TestCleanup]
        public void ClassTearDown()
        {
            application.Close();
        }

        [TestInitialize]
        public void SetUp()
        {
            application = Application.Launch("E:\\CSharpDev\\Projects\\Calculator\\CalculatorWindowsForms\\CalculatorWindowsForms\\bin\\Debug\\CalculatorWindowsForms.exe");
            Assert.IsNotNull(application);
        }

        [TestMethod]
        public void TestMethodPLus()
        {
            GetTextBox("tbA").SetValue(2);
            GetTextBox("tbOp").SetValue('+');
            GetTextBox("tbB").SetValue(2);
            GetButton("btnCalc").Click();
            var res = GetTextBox("tbRes").Text.ToString();
            Assert.AreEqual("4", res);
        }

        [TestMethod]
        public void TestMethodMinus()
        {
            GetTextBox("tbA").SetValue("10");
            GetTextBox("tbOp").SetValue("-");
            GetTextBox("tbB").SetValue("5");
            GetButton("btnCalc").Click();
            string res = GetTextBox("tbRes").Text.ToString();
            Assert.AreEqual("5", res);
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            GetTextBox("tbA").SetValue("20");
            GetTextBox("tbOp").SetValue("/");
            GetTextBox("tbB").SetValue("2");
            GetButton("btnCalc").Click();
            var res = GetTextBox("tbRes").Text.ToString();
            Assert.AreEqual("10", res);
        }
        [TestMethod]
        public void TestMethodMult()
        {
            GetTextBox("tbA").SetValue("5");
            GetTextBox("tbOp").SetValue("*");
            GetTextBox("tbB").SetValue("2");
            GetButton("btnCalc").Click();
            var res = GetTextBox("tbRes").Text.ToString();
            Assert.AreEqual("10", res);

        }



        public Button GetButton(string nameWindow)
        {
            for (var i = 0; i < 100; i++)
            {
                var button = GetWindow().Get<Button>(SearchCriteria.ByAutomationId(nameWindow));
                if (button != null) return button;
            }

            return null;
        }

        public TextBox GetTextBox(string nameWindow)
        {
            for (var i = 0; i < 100; i++)
            {
                var textBox = GetWindow().Get<TextBox>(SearchCriteria.ByAutomationId(nameWindow));
                if (textBox != null) return textBox;
            }

            return null;
        }


        public Window GetWindow()
        {
            return application.GetWindow("Form1");
        }
    }
}
