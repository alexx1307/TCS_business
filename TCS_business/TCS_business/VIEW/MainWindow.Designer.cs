﻿namespace TCS_business.VIEW
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
            this.Buy = new System.Windows.Forms.Button();
            this.TurnEnd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playersListPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.fieldInfoPanel = new TCS_business.VIEW.FieldInfoPanel();
            this.boardPanel1 = new TCS_business.VIEW.BoardPanel();
            this.fieldInfoPanel1 = new TCS_business.VIEW.FieldInfoPanel();
            this.menuStrip1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
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
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Buy);
            this.panel7.Controls.Add(this.TurnEnd);
            this.panel7.Location = new System.Drawing.Point(710, 95);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 35);
            this.panel7.TabIndex = 6;
            // 
            // Buy
            // 
            this.Buy.Enabled = false;
            this.Buy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Buy.Location = new System.Drawing.Point(3, 3);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(92, 23);
            this.Buy.TabIndex = 1;
            this.Buy.Text = "Buy field";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // TurnEnd
            // 
            this.TurnEnd.Enabled = false;
            this.TurnEnd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TurnEnd.Location = new System.Drawing.Point(101, 3);
            this.TurnEnd.Name = "TurnEnd";
            this.TurnEnd.Size = new System.Drawing.Size(93, 23);
            this.TurnEnd.TabIndex = 0;
            this.TurnEnd.Text = "End turn ";
            this.TurnEnd.UseVisualStyleBackColor = true;
            this.TurnEnd.Click += new System.EventHandler(this.TurnEnd_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(710, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(94, 47);
            this.textBox1.TabIndex = 9;
            // 
            // playersListPanel
            // 
            this.playersListPanel.Location = new System.Drawing.Point(710, 136);
            this.playersListPanel.Name = "playersListPanel";
            this.playersListPanel.Size = new System.Drawing.Size(201, 307);
            this.playersListPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(200, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Chance";
            this.label2.Visible = false;
            // 
            // dice1
            // 
            this.dice1.Location = new System.Drawing.Point(811, 44);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(45, 45);
            this.dice1.TabIndex = 12;
            this.dice1.TabStop = false;
            // 
            // dice2
            // 
            this.dice2.Location = new System.Drawing.Point(862, 44);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(45, 45);
            this.dice2.TabIndex = 7;
            this.dice2.TabStop = false;
            // 
            // fieldInfoPanel
            // 
            this.fieldInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fieldInfoPanel.Location = new System.Drawing.Point(710, 449);
            this.fieldInfoPanel.Name = "fieldInfoPanel";
            this.fieldInfoPanel.Size = new System.Drawing.Size(201, 240);
            this.fieldInfoPanel.TabIndex = 15;
            // 
            // boardPanel1
            // 
            this.boardPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.boardPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boardPanel1.Location = new System.Drawing.Point(12, 27);
            this.boardPanel1.Name = "boardPanel1";
            this.boardPanel1.Size = new System.Drawing.Size(673, 701);
            this.boardPanel1.TabIndex = 0;
            // 
            // fieldInfoPanel1
            // 
            this.fieldInfoPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fieldInfoPanel1.Location = new System.Drawing.Point(710, 538);
            this.fieldInfoPanel1.Name = "fieldInfoPanel1";
            this.fieldInfoPanel1.Size = new System.Drawing.Size(146, 146);
            this.fieldInfoPanel1.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(930, 748);
            this.Controls.Add(this.fieldInfoPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.boardPanel1);
            this.Controls.Add(this.playersListPanel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TurnEnd;
        private System.Windows.Forms.Panel playersListPanel;
        private BoardPanel boardPanel1;
        private System.Windows.Forms.PictureBox dice1;
        private FieldInfoPanel fieldInfoPanel1;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FieldInfoPanel fieldInfoPanel;

    }
}