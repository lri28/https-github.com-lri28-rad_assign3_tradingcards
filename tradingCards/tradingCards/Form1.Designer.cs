using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace tradingCards
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            PanelPlayerCard = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            lblPassAccuracy = new Label();
            lblPlayerName = new Label();
            lblMatchesPlayed = new Label();
            label2 = new Label();
            lblAssists = new Label();
            lblPlayerTeam = new Label();
            lblGoals = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            picBoxPlayerImage = new PictureBox();
            lblSearchPlayer = new Label();
            txtBoxSearchPlayer = new TextBox();
            lblTitle = new Label();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            cmboBoxViewPlayers = new ComboBox();
            PanelPlayerCard.SuspendLayout();
            panel1.SuspendLayout();
            ((ISupportInitialize)picBoxPlayerImage).BeginInit();
            SuspendLayout();
            // 
            // PanelPlayerCard
            // 
            PanelPlayerCard.BackColor = Color.Transparent;
            PanelPlayerCard.Controls.Add(panel1);
            PanelPlayerCard.Controls.Add(picBoxPlayerImage);
            PanelPlayerCard.Location = new Point(619, 124);
            PanelPlayerCard.Name = "PanelPlayerCard";
            PanelPlayerCard.Size = new Size(870, 604);
            PanelPlayerCard.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblPassAccuracy);
            panel1.Controls.Add(lblPlayerName);
            panel1.Controls.Add(lblMatchesPlayed);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblAssists);
            panel1.Controls.Add(lblPlayerTeam);
            panel1.Controls.Add(lblGoals);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(449, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 353);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 1;
            label1.Text = "Player Name:  ";
            // 
            // lblPassAccuracy
            // 
            lblPassAccuracy.AutoSize = true;
            lblPassAccuracy.Font = new Font("Segoe UI", 10F);
            lblPassAccuracy.ForeColor = Color.FromArgb(64, 64, 64);
            lblPassAccuracy.Location = new Point(193, 300);
            lblPassAccuracy.Name = "lblPassAccuracy";
            lblPassAccuracy.Size = new Size(0, 28);
            lblPassAccuracy.TabIndex = 12;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerName.ForeColor = Color.FromArgb(64, 64, 64);
            lblPlayerName.Location = new Point(193, 25);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(0, 32);
            lblPlayerName.TabIndex = 7;
            // 
            // lblMatchesPlayed
            // 
            lblMatchesPlayed.AutoSize = true;
            lblMatchesPlayed.Font = new Font("Segoe UI", 10F);
            lblMatchesPlayed.ForeColor = Color.FromArgb(64, 64, 64);
            lblMatchesPlayed.Location = new Point(193, 245);
            lblMatchesPlayed.Name = "lblMatchesPlayed";
            lblMatchesPlayed.Size = new Size(0, 28);
            lblMatchesPlayed.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(14, 80);
            label2.Name = "label2";
            label2.Size = new Size(145, 30);
            label2.TabIndex = 2;
            label2.Text = "Player Team:";
            // 
            // lblAssists
            // 
            lblAssists.AutoSize = true;
            lblAssists.Font = new Font("Segoe UI", 10F);
            lblAssists.ForeColor = Color.FromArgb(64, 64, 64);
            lblAssists.Location = new Point(193, 190);
            lblAssists.Name = "lblAssists";
            lblAssists.Size = new Size(0, 28);
            lblAssists.TabIndex = 10;
            // 
            // lblPlayerTeam
            // 
            lblPlayerTeam.AutoSize = true;
            lblPlayerTeam.Font = new Font("Segoe UI", 10F);
            lblPlayerTeam.ForeColor = Color.FromArgb(64, 64, 64);
            lblPlayerTeam.Location = new Point(193, 80);
            lblPlayerTeam.Name = "lblPlayerTeam";
            lblPlayerTeam.Size = new Size(0, 28);
            lblPlayerTeam.TabIndex = 8;
            // 
            // lblGoals
            // 
            lblGoals.AutoSize = true;
            lblGoals.Font = new Font("Segoe UI", 10F);
            lblGoals.ForeColor = Color.FromArgb(64, 64, 64);
            lblGoals.Location = new Point(193, 135);
            lblGoals.Name = "lblGoals";
            lblGoals.Size = new Size(0, 28);
            lblGoals.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(14, 135);
            label3.Name = "label3";
            label3.Size = new Size(88, 30);
            label3.TabIndex = 3;
            label3.Text = "Goals:  ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(14, 300);
            label6.Name = "label6";
            label6.Size = new Size(176, 30);
            label6.TabIndex = 6;
            label6.Text = "Pass Accuracy:  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(14, 190);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 4;
            label4.Text = "Assists:  ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(14, 245);
            label5.Name = "label5";
            label5.Size = new Size(189, 30);
            label5.TabIndex = 5;
            label5.Text = "Matches Played: ";
            // 
            // picBoxPlayerImage
            // 
            picBoxPlayerImage.Location = new Point(27, 23);
            picBoxPlayerImage.Name = "picBoxPlayerImage";
            picBoxPlayerImage.Size = new Size(377, 527);
            picBoxPlayerImage.TabIndex = 0;
            picBoxPlayerImage.TabStop = false;
            // 
            // lblSearchPlayer
            // 
            lblSearchPlayer.AutoSize = true;
            lblSearchPlayer.BackColor = Color.Transparent;
            lblSearchPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchPlayer.ForeColor = Color.MidnightBlue;
            lblSearchPlayer.Location = new Point(64, 777);
            lblSearchPlayer.Name = "lblSearchPlayer";
            lblSearchPlayer.Size = new Size(175, 32);
            lblSearchPlayer.TabIndex = 4;
            lblSearchPlayer.Text = "Search Player:";
            // 
            // txtBoxSearchPlayer
            // 
            txtBoxSearchPlayer.Font = new Font("Segoe UI", 11F);
            txtBoxSearchPlayer.Location = new Point(245, 776);
            txtBoxSearchPlayer.Name = "txtBoxSearchPlayer";
            txtBoxSearchPlayer.Size = new Size(250, 37);
            txtBoxSearchPlayer.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Snap ITC", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(393, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(783, 73);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Football Trading Cards";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkBlue;
            btnSearch.Font = new Font("Segoe UI", 11F);
            btnSearch.ForeColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(498, 776);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(135, 40);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkBlue;
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(998, 776);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 40);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkBlue;
            btnEdit.Font = new Font("Segoe UI", 11F);
            btnEdit.ForeColor = Color.WhiteSmoke;
            btnEdit.Location = new Point(1154, 776);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(135, 40);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkBlue;
            btnDelete.Font = new Font("Segoe UI", 11F);
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(1313, 776);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 40);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.BackColor = Color.OliveDrab;
            flowLayoutPanel.Location = new Point(79, 124);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(495, 600);
            flowLayoutPanel.TabIndex = 12;
            // 
            // cmboBoxViewPlayers
            // 
            cmboBoxViewPlayers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmboBoxViewPlayers.FormattingEnabled = true;
            cmboBoxViewPlayers.Location = new Point(686, 776);
            cmboBoxViewPlayers.Name = "cmboBoxViewPlayers";
            cmboBoxViewPlayers.Size = new Size(267, 38);
            cmboBoxViewPlayers.TabIndex = 13;
            cmboBoxViewPlayers.Text = "   View Player By Teams";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1547, 878);
            Controls.Add(cmboBoxViewPlayers);
            Controls.Add(flowLayoutPanel);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(lblTitle);
            Controls.Add(txtBoxSearchPlayer);
            Controls.Add(lblSearchPlayer);
            Controls.Add(PanelPlayerCard);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trading Cards";
            PanelPlayerCard.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)picBoxPlayerImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PanelPlayerCard;
        private PictureBox picBoxPlayerImage;
        private Label lblSearchPlayer;
        private TextBox txtBoxSearchPlayer;
        private Label lblTitle;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblPassAccuracy;
        private Label lblMatchesPlayed;
        private Label lblAssists;
        private Label lblGoals;
        private Label lblPlayerTeam;
        private Label lblPlayerName;
        private FlowLayoutPanel flowLayoutPanel;
        private Panel panel1;
        private ComboBox cmboBoxViewPlayers;
    }
}
