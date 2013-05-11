using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS_business.CONTROLER;
namespace TCS_business
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            TCSBusinessApplication app = new TCSBusinessApplication();
            app.Initialize();
            app.Run();
        }
    }
}
