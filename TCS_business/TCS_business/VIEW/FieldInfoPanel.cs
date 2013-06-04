using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCS_business.VIEW
{
    public partial class FieldInfoPanel : UserControl
    {
        public FieldInfoPanel()
        {
            InitializeComponent();
        }

        internal void UpdateContent(MODEL.Field field,bool shouldBuyButtonBeSeen)
        {
            label1.Text = field.Description;
            if (shouldBuyButtonBeSeen)
                this.button1.Show();
            else
                this.button1.Hide();
            this.Visible = true;
        }
    }
}
