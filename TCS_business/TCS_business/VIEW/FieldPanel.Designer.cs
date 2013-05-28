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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.placeForPawnPB = new System.Windows.Forms.PictureBox();
            this.ownershipPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.placeForPawnPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipPB)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(4, 4);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "label1";
            // 
            // placeForPawnPB
            // 
            this.placeForPawnPB.Location = new System.Drawing.Point(41, 20);
            this.placeForPawnPB.Name = "placeForPawnPB";
            this.placeForPawnPB.Size = new System.Drawing.Size(16, 27);
            this.placeForPawnPB.TabIndex = 1;
            this.placeForPawnPB.TabStop = false;
            // 
            // ownershipPB
            // 
            this.ownershipPB.Location = new System.Drawing.Point(7, 24);
            this.ownershipPB.Name = "ownershipPB";
            this.ownershipPB.Size = new System.Drawing.Size(28, 23);
            this.ownershipPB.TabIndex = 2;
            this.ownershipPB.TabStop = false;
            // 
            // FieldPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ownershipPB);
            this.Controls.Add(this.placeForPawnPB);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "FieldPanel";
            this.Size = new System.Drawing.Size(80, 50);
            ((System.ComponentModel.ISupportInitialize)(this.placeForPawnPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.PictureBox placeForPawnPB;
        private System.Windows.Forms.PictureBox ownershipPB;


    }
}
