using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCS_business.VIEW
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            richTextBox1.Text = "Witaj w grze TCS Business. \r\n\r\nAby rozpocząć nowę " +
                "grę dodaj odpowiednią ilość graczy. Gra nie może wystartować, jeśli " +
                "wszyscy gracze jeszcze nie dołączyli. \r\n\r\nPrzed wystartowaniem gry " +
                "możesz dostosować ustawienia - w trakcie nie będzie już to możliwe." +
                "\r\n\r\nNazwa gracza musi składać się z co najmniej jednego znaku i nie " +
                "nie może składać się z samych białych znaków. \r\n\r\nZasady zbliżone do tych " +
                "z Monopoly :)";
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
