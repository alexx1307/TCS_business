﻿using System;
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
            if (field is City)
            {
                BackColor = (field as City).Country.Color;

            }
        }

        public void Update(Field field)
        {
            if (field.Owner != null)
            {
                this.CreateGraphics().DrawRectangle(new Pen(field.Owner.Color,7.0f), this.ClientRectangle);
            }
        }

        internal void setPawn(Color color)
        {
            placeForPawnPB.BackColor = color;

        }

    }
}
