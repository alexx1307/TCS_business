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
            switch (i)
            {
                case 1:
                case 3:
                    BackColor = Color.LavenderBlush;
                    break;
                case 6:
                case 7:
                case 9:
                    BackColor = Color.LightSkyBlue;
                    break;
                case 11:
                case 13:
                case 14:
                    BackColor = Color.LightGreen;
                    break;
                case 16:
                case 18:
                case 19:
                    BackColor = Color.LightPink;
                    break;
                case 21:
                case 23:
                case 24:
                    BackColor = Color.PaleGoldenrod;
                    break;
                case 26:
                case 27:
                case 29:
                    BackColor = Color.PaleTurquoise;
                    break;
                case 31:
                case 32:
                case 34:
                    BackColor = Color.SandyBrown;
                    break;
                case 37:
                case 39:
                    BackColor = Color.Gray;
                    break;
                default:
                    BackColor = Color.White;
                    break;
            }

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
