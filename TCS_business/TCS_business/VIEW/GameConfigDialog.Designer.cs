namespace TCS_business.VIEW
{
    partial class GameConfigDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerTime = new System.Windows.Forms.NumericUpDown();
            this.playersNumber = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.playerTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cash)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time for a player (minutes)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of players";
            // 
            // playerTime
            // 
            this.playerTime.Location = new System.Drawing.Point(12, 32);
            this.playerTime.Name = "playerTime";
            this.playerTime.Size = new System.Drawing.Size(52, 20);
            this.playerTime.TabIndex = 2;
            // 
            // playersNumber
            // 
            this.playersNumber.Location = new System.Drawing.Point(12, 90);
            this.playersNumber.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.playersNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.playersNumber.Name = "playersNumber";
            this.playersNumber.Size = new System.Drawing.Size(120, 20);
            this.playersNumber.TabIndex = 6;
            this.playersNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 182);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(123, 182);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "The initial capital";
            // 
            // cash
            // 
            this.cash.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cash.Location = new System.Drawing.Point(12, 145);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(120, 20);
            this.cash.TabIndex = 10;
            // 
            // GameConfigDialog
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(217, 217);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.playersNumber);
            this.Controls.Add(this.playerTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GameConfigDialog";
            this.Text = "Game settings";
            ((System.ComponentModel.ISupportInitialize)(this.playerTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown playerTime;
        private System.Windows.Forms.NumericUpDown playersNumber;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cash;
    }
}