using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS_business.CONTROLER;
using TCS_business.MODEL;
using TCS_business.VIEW;
using System.Windows.Forms;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for FormTest
    /// </summary>
    [TestClass]
    public class FormTest
    {
        public FormTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /// <summary>
        /// This method checks whether it's possible to set player time
        /// to incorrect value
        /// </summary>
        [TestMethod]
        public void TestFormPlayerTime()
        {
            ApplicationController app = ApplicationController.Instance;
            app.InitializeAndRun();
            var gcd = new GameConfigDialog();
            Assert.IsNotNull(gcd);
            Assert.IsNotNull(gcd.AcceptButton);
            Control c = gcd.GetNextControl(gcd, true);
            c = gcd.GetNextControl(c, true);
            c = gcd.GetNextControl(c, true);
            Assert.IsNotNull(c);
            NumericUpDown num = (NumericUpDown)c;

            try
            {
                num.Value = GameConfig.maxPlayerTime + 1;
                Assert.Fail("poza zakresem", null);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
