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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pawn1 = new System.Windows.Forms.PictureBox();
            this.pawn2 = new System.Windows.Forms.PictureBox();
            this.pawn3 = new System.Windows.Forms.PictureBox();
            this.pawn4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn4)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLabel.Location = new System.Drawing.Point(4, 5);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCS_business.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(42, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pawn1
            // 
            this.pawn1.Location = new System.Drawing.Point(5, 24);
            this.pawn1.Name = "pawn1";
            this.pawn1.Size = new System.Drawing.Size(7, 18);
            this.pawn1.TabIndex = 1;
            this.pawn1.TabStop = false;
            // 
            // pawn2
            // 
            this.pawn2.Location = new System.Drawing.Point(13, 24);
            this.pawn2.Name = "pawn2";
            this.pawn2.Size = new System.Drawing.Size(7, 18);
            this.pawn2.TabIndex = 3;
            this.pawn2.TabStop = false;
            // 
            // pawn3
            // 
            this.pawn3.Location = new System.Drawing.Point(21, 24);
            this.pawn3.Name = "pawn3";
            this.pawn3.Size = new System.Drawing.Size(7, 18);
            this.pawn3.TabIndex = 4;
            this.pawn3.TabStop = false;
            // 
            // pawn4
            // 
            this.pawn4.Location = new System.Drawing.Point(29, 24);
            this.pawn4.Name = "pawn4";
            this.pawn4.Size = new System.Drawing.Size(7, 18);
            this.pawn4.TabIndex = 5;
            this.pawn4.TabStop = false;
            // 
            // FieldPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pawn4);
            this.Controls.Add(this.pawn3);
            this.Controls.Add(this.pawn2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pawn1);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "FieldPanel";
            this.Size = new System.Drawing.Size(80, 55);
            this.Click += new System.EventHandler(this.FieldPanel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.PictureBox pawn1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pawn2;
        public System.Windows.Forms.PictureBox pawn3;
        public System.Windows.Forms.PictureBox pawn4;


    }
}
