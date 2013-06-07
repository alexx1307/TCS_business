using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.MODEL;
using TCS_business.CONTROLER;
namespace TCS_business.VIEW
{
    /// <summary>
    /// <author> Anita Ciosek </author>
    /// Shows the form where player can enter his name and adds him to list of players.
    /// </summary>
    public partial class AddPlayerDialog : Form
    {
        object[] AvailableColors = {Color.Blue, Color.Green, Color.Red, Color.Yellow, Color.Pink, Color.Black, Color.White, Color.Plum, Color.Orange};

        public AddPlayerDialog()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(AvailableColors);
            comboBox1.SelectedIndex = 0;
            for (int i = 0; i < MainWindow.OccupiedColors.Count(); ++i)
            {
                if (MainWindow.OccupiedColors[i] != null)
                {
                    comboBox1.Items.Remove((object)MainWindow.OccupiedColors[i]);
                }
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                String s = textBox1.Text;
                this.Close();
                this.DialogResult = DialogResult.OK;
                MainWindow.SetColor((Color)comboBox1.SelectedItem);
                ApplicationController.Instance.RegisterNewPlayer(s, (Color)comboBox1.SelectedItem);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
