using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS_business.VIEW;
using TCS_business.CONTROLER;
using TCS_business.MODEL;
using System.Windows.Forms;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ApplicationController app = ApplicationController.Instance;
            app.InitializeAndRun();
            app.guiManager.ShowConfigDialog(new GameConfig());
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
                num.Value = 11;            
                //gcd.button1_Click(null, null);
                Assert.AreEqual(11, app.game.GameConfig.TurnTime.Minutes);
                Assert.Fail("poza zakresem", null);
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
