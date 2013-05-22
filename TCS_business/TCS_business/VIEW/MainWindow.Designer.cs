namespace TCS_business.VIEW
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.powerHouseButton = new System.Windows.Forms.Button();
            this.pledgeButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playersListPanel = new System.Windows.Forms.Panel();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.boardPanel1 = new TCS_business.VIEW.BoardPanel();
            this.menuStrip1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.gameSettingsToolStripMenuItem,
            this.registerNewPlayerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // gameSettingsToolStripMenuItem
            // 
            this.gameSettingsToolStripMenuItem.Name = "gameSettingsToolStripMenuItem";
            this.gameSettingsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.gameSettingsToolStripMenuItem.Text = "Game settings";
            this.gameSettingsToolStripMenuItem.Click += new System.EventHandler(this.gameSettingsToolStripMenuItem_Click);
            // 
            // registerNewPlayerToolStripMenuItem
            // 
            this.registerNewPlayerToolStripMenuItem.Name = "registerNewPlayerToolStripMenuItem";
            this.registerNewPlayerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.registerNewPlayerToolStripMenuItem.Text = "Register new player";
            this.registerNewPlayerToolStripMenuItem.Click += new System.EventHandler(this.registerNewPlayerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.powerHouseButton);
            this.panel7.Controls.Add(this.pledgeButton);
            this.panel7.Controls.Add(this.buyButton);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(728, 453);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 84);
            this.panel7.TabIndex = 6;
            // 
            // powerHouseButton
            // 
            this.powerHouseButton.Location = new System.Drawing.Point(133, 3);
            this.powerHouseButton.Name = "powerHouseButton";
            this.powerHouseButton.Size = new System.Drawing.Size(59, 39);
            this.powerHouseButton.TabIndex = 3;
            this.powerHouseButton.Text = "Postaw domek";
            this.powerHouseButton.UseVisualStyleBackColor = true;
            // 
            // pledgeButton
            // 
            this.pledgeButton.Location = new System.Drawing.Point(68, 3);
            this.pledgeButton.Name = "pledgeButton";
            this.pledgeButton.Size = new System.Drawing.Size(59, 39);
            this.pledgeButton.TabIndex = 2;
            this.pledgeButton.Text = "Zastaw";
            this.pledgeButton.UseVisualStyleBackColor = true;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(3, 3);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(59, 39);
            this.buyButton.TabIndex = 1;
            this.buyButton.Text = "Kupuj";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "End turn ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dice2
            // 
            this.dice2.Location = new System.Drawing.Point(880, 67);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(45, 45);
            this.dice2.TabIndex = 7;
            this.dice2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(858, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "animacja kostki ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(728, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(94, 47);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "komunikaty";
            // 
            // playersListPanel
            // 
            this.playersListPanel.Location = new System.Drawing.Point(728, 118);
            this.playersListPanel.Name = "playersListPanel";
            this.playersListPanel.Size = new System.Drawing.Size(201, 325);
            this.playersListPanel.TabIndex = 11;
            // 
            // dice1
            // 
            this.dice1.Location = new System.Drawing.Point(829, 67);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(45, 45);
            this.dice1.TabIndex = 12;
            this.dice1.TabStop = false;
            // 
            // boardPanel1
            // 
            this.boardPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boardPanel1.Location = new System.Drawing.Point(12, 27);
            this.boardPanel1.Name = "boardPanel1";
            this.boardPanel1.Size = new System.Drawing.Size(688, 583);
            this.boardPanel1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.boardPanel1);
            this.Controls.Add(this.playersListPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerNewPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel playersListPanel;
        private BoardPanel boardPanel1;
        private System.Windows.Forms.Button powerHouseButton;
        private System.Windows.Forms.Button pledgeButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.PictureBox dice1;

    }
}