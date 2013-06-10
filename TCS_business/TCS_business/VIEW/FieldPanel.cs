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

        public void ChangeDescriptionLabel()
        {
            field.ChangeDescriptionLabel();
            descriptionLabel.Text = field.Description;
        }

        public void Update(Field field)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                if (field is IPurchasable && (field as IPurchasable).Owner != null)
                {
                    this.CreateGraphics().DrawRectangle(
                        new Pen((field as IPurchasable).Owner.Color, 7.0f),
                        this.ClientRectangle);

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
                if (field is City && (field as City).Houses>0)
                    this.houses.Text = (field as City).Houses.ToString();
                else this.houses.Text = "";
            });
        }

        public void ChangeLockLocation()
        {
            this.pictureBox1.Location = new Point(26, 40);
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
            bool ownerofTheField = false;
            if (field is IPurchasable)
                ownerofTheField = ((field as IPurchasable).Owner == game.GameState.ActivePlayer);
            if (field is City)
            {
                ownerOfWholeCountry = true;
                foreach (Field f in (field as City).Country.Fields)
                {
                    if ((f as IPurchasable).Owner != game.GameState.ActivePlayer)
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
