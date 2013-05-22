using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.MODEL;

namespace TCS_business.VIEW
{
    public partial class FieldPanel : UserControl
    {
        public FieldPanel(Field field)
        {
            InitializeComponent();
            descriptionLabel.Text = field.Description;
        }

        public void Update(Field field)
        {

        }


        internal void setPawn(Color color)
        {
            placeForPawnPB.BackColor = color;
        }
    }
}
