namespace TCS_business.VIEW
{
    partial class FieldPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityBackgroundPB = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.countryColorPB = new System.Windows.Forms.PictureBox();
            this.playerOwningColor = new System.Windows.Forms.PictureBox();
            this.pawnPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cityBackgroundPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryColorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOwningColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawnPB)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBackgroundPB
            // 
            this.cityBackgroundPB.BackColor = System.Drawing.Color.Transparent;
            this.cityBackgroundPB.Location = new System.Drawing.Point(3, 22);
            this.cityBackgroundPB.Name = "cityBackgroundPB";
            this.cityBackgroundPB.Size = new System.Drawing.Size(74, 55);
            this.cityBackgroundPB.TabIndex = 1;
            this.cityBackgroundPB.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 6);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "label1";
            // 
            // countryColorPB
            // 
            this.countryColorPB.BackColor = System.Drawing.Color.Transparent;
            this.countryColorPB.Location = new System.Drawing.Point(3, 6);
            this.countryColorPB.Name = "countryColorPB";
            this.countryColorPB.Size = new System.Drawing.Size(74, 13);
            this.countryColorPB.TabIndex = 3;
            this.countryColorPB.TabStop = false;
            // 
            // playerOwningColor
            // 
            this.playerOwningColor.BackColor = System.Drawing.Color.Transparent;
            this.playerOwningColor.Location = new System.Drawing.Point(3, 3);
            this.playerOwningColor.Name = "playerOwningColor";
            this.playerOwningColor.Size = new System.Drawing.Size(77, 73);
            this.playerOwningColor.TabIndex = 4;
            this.playerOwningColor.TabStop = false;
            // 
            // pawnPB
            // 
            this.pawnPB.BackColor = System.Drawing.Color.Transparent;
            this.pawnPB.Location = new System.Drawing.Point(28, 22);
            this.pawnPB.Name = "pawnPB";
            this.pawnPB.Size = new System.Drawing.Size(26, 40);
            this.pawnPB.TabIndex = 5;
            this.pawnPB.TabStop = false;
            // 
            // FieldPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pawnPB);
            this.Controls.Add(this.playerOwningColor);
            this.Controls.Add(this.countryColorPB);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.cityBackgroundPB);
            this.Name = "FieldPanel";
            this.Size = new System.Drawing.Size(78, 78);
            ((System.ComponentModel.ISupportInitialize)(this.cityBackgroundPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryColorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOwningColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawnPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cityBackgroundPB;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.PictureBox countryColorPB;
        private System.Windows.Forms.PictureBox playerOwningColor;
        private System.Windows.Forms.PictureBox pawnPB;

    }
}
