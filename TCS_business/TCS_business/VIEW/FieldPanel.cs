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
        Field field;
        public FieldPanel(Field field)
        {
            InitializeComponent();
            this.field = field;
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


        private void FieldPanel_Click(object sender, EventArgs e)
        {
            CONTROLER.Game game = CONTROLER.ApplicationController.Instance.game;
            bool ownerOfWholeCountry = false;

            if (field is City)
            {
                ownerOfWholeCountry = true;
                foreach(Field f in (field as City).Country.Fields)
                {
                    if(f.Owner != game.GameState.ActivePlayer)
                    {
                        ownerOfWholeCountry = false;
                        break;
                    }
                }
            }
            
            CONTROLER.ApplicationController.Instance.UpdateFieldInfoPanel(field,ownerOfWholeCountry);
        }

    }
}
