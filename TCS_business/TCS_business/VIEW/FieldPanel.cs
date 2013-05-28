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
        public FieldPanel(Field field, int i)
        {
            InitializeComponent();
            descriptionLabel.Text = field.Description;
            BackColor = Color.White;
        }

        public void Update(Field field)
        {
            if (field.Owner != null)
            {
                this.ownershipPB.BackColor = field.Owner.Color;
            }
        }


        internal void setPawn(Color color)
        {
            placeForPawnPB.BackColor = color;
        }
    }
}
