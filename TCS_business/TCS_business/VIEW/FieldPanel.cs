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
        private Field field;
        private PictureBox[] pawns;

        public FieldPanel(Field field)
        {
            InitializeComponent();
            pawns = new PictureBox[4] { pawn1, pawn2, pawn3, pawn4 };
            this.field = field;
            descriptionLabel.Text = field.Description;
            if (field is City)
            {
                BackColor = (field as City).Country.Color;

            }
            if (field is IPurchasable)
            {
                if ((field as IPurchasable).Pledged == true)
                {
                    this.pictureBox1.Show();
                }
                else
                {
                    this.pictureBox1.Hide();
                }
            }
            else
            {
                this.pictureBox1.Hide();
            }
        }

        public void Update(Field field)
        {
            if (field.Owner != null)
            {
                this.CreateGraphics().DrawRectangle(new Pen(field.Owner.Color, 7.0f), this.ClientRectangle);
            }
        }

        internal void removePawns()
        {
            foreach (PictureBox pawn in pawns) 
                pawn.BackColor = System.Drawing.Color.Transparent;
        }

        internal void setPawn(Color color, int i) { pawns[i].BackColor = color; }

        private void FieldPanel_Click(object sender, EventArgs e)
        {
            CONTROLER.Game game = CONTROLER.ApplicationController.Instance.Game;
            bool ownerOfWholeCountry = false;
            bool ownerofTheField = (field.Owner == game.GameState.ActivePlayer);
            if (field is City)
            {
                ownerOfWholeCountry = true;
                foreach (Field f in (field as City).Country.Fields)
                {
                    if (f.Owner != game.GameState.ActivePlayer)
                    {
                        ownerOfWholeCountry = false;
                        break;
                    }
                }
            }

            CONTROLER.ApplicationController.Instance.UpdateFieldInfoPanel(field, ownerOfWholeCountry, ownerofTheField);
        }

    }
}
