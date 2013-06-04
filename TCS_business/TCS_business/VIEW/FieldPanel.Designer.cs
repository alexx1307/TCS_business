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
            ((System.ComponentModel.ISupportInitialize)(this.placeForPawnPB)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLabel.Location = new System.Drawing.Point(4, 5);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(34, 16);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "label1";
            // 
            // placeForPawnPB
            // 
            this.placeForPawnPB.Location = new System.Drawing.Point(7, 24);
            this.placeForPawnPB.Name = "placeForPawnPB";
            this.placeForPawnPB.Size = new System.Drawing.Size(16, 18);
            this.placeForPawnPB.TabIndex = 1;
            this.placeForPawnPB.TabStop = false;
            // 
            // FieldPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.placeForPawnPB);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "FieldPanel";
            this.Size = new System.Drawing.Size(80, 55);
            ((System.ComponentModel.ISupportInitialize)(this.placeForPawnPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.PictureBox placeForPawnPB;


    }
}
