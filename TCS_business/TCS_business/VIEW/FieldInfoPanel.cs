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

        internal void UpdateContent(MODEL.Field field)
        {
            label1.Text = field.Description;

            this.Visible = true;
        }
    }
}
