namespace tradingCards
{
    partial class EditPlayerForm
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
            btnPlayerPhoto = new Button();
            btnCancel = new Button();
            btnEditPlayer = new Button();
            cmboBoxPlayerTeam = new ComboBox();
            txtPassAccuracy = new TextBox();
            txtMatchesPlayed = new TextBox();
            txtAssists = new TextBox();
            txtGoals = new TextBox();
            txtPlayersName = new TextBox();
            picBoxPlayerImage = new PictureBox();
            lblPassAccuracy = new Label();
            lblMatchesPlayed = new Label();
            lblAssists = new Label();
            lblGoals = new Label();
            lblPlayerTeam = new Label();
            lblPlayersName = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayerImage).BeginInit();
            SuspendLayout();
            // 
            // btnPlayerPhoto
            // 
            btnPlayerPhoto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlayerPhoto.ForeColor = Color.Navy;
            btnPlayerPhoto.Location = new Point(717, 572);
            btnPlayerPhoto.Margin = new Padding(4);
            btnPlayerPhoto.Name = "btnPlayerPhoto";
            btnPlayerPhoto.Size = new Size(279, 54);
            btnPlayerPhoto.TabIndex = 32;
            btnPlayerPhoto.Text = "Edit Trading Card Image";
            btnPlayerPhoto.UseVisualStyleBackColor = true;
            btnPlayerPhoto.Click += btnPlayerPhoto_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Navy;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(353, 572);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 50);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEditPlayer
            // 
            btnEditPlayer.BackColor = Color.Navy;
            btnEditPlayer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditPlayer.ForeColor = Color.WhiteSmoke;
            btnEditPlayer.Location = new Point(111, 572);
            btnEditPlayer.Margin = new Padding(4);
            btnEditPlayer.Name = "btnEditPlayer";
            btnEditPlayer.Size = new Size(170, 50);
            btnEditPlayer.TabIndex = 30;
            btnEditPlayer.Text = "Edit Player";
            btnEditPlayer.UseVisualStyleBackColor = false;
            btnEditPlayer.Click += btnEditPlayer_Click;
            // 
            // cmboBoxPlayerTeam
            // 
            cmboBoxPlayerTeam.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmboBoxPlayerTeam.FormattingEnabled = true;
            cmboBoxPlayerTeam.Location = new Point(257, 157);
            cmboBoxPlayerTeam.Margin = new Padding(4);
            cmboBoxPlayerTeam.Name = "cmboBoxPlayerTeam";
            cmboBoxPlayerTeam.Size = new Size(304, 36);
            cmboBoxPlayerTeam.TabIndex = 29;
            // 
            // txtPassAccuracy
            // 
            txtPassAccuracy.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassAccuracy.Location = new Point(257, 445);
            txtPassAccuracy.Margin = new Padding(4);
            txtPassAccuracy.Name = "txtPassAccuracy";
            txtPassAccuracy.Size = new Size(304, 34);
            txtPassAccuracy.TabIndex = 28;
            // 
            // txtMatchesPlayed
            // 
            txtMatchesPlayed.Font = new Font("Segoe UI", 10F);
            txtMatchesPlayed.Location = new Point(257, 373);
            txtMatchesPlayed.Margin = new Padding(4);
            txtMatchesPlayed.Name = "txtMatchesPlayed";
            txtMatchesPlayed.Size = new Size(304, 34);
            txtMatchesPlayed.TabIndex = 27;
            // 
            // txtAssists
            // 
            txtAssists.Font = new Font("Segoe UI", 10F);
            txtAssists.Location = new Point(257, 301);
            txtAssists.Margin = new Padding(4);
            txtAssists.Name = "txtAssists";
            txtAssists.Size = new Size(304, 34);
            txtAssists.TabIndex = 26;
            // 
            // txtGoals
            // 
            txtGoals.Font = new Font("Segoe UI", 10F);
            txtGoals.Location = new Point(257, 229);
            txtGoals.Margin = new Padding(4);
            txtGoals.Name = "txtGoals";
            txtGoals.Size = new Size(304, 34);
            txtGoals.TabIndex = 25;
            // 
            // txtPlayersName
            // 
            txtPlayersName.Font = new Font("Segoe UI", 10F);
            txtPlayersName.Location = new Point(257, 85);
            txtPlayersName.Margin = new Padding(4);
            txtPlayersName.Name = "txtPlayersName";
            txtPlayersName.Size = new Size(304, 34);
            txtPlayersName.TabIndex = 24;
            // 
            // picBoxPlayerImage
            // 
            picBoxPlayerImage.AccessibleDescription = "";
            picBoxPlayerImage.AccessibleName = "";
            picBoxPlayerImage.Location = new Point(664, 25);
            picBoxPlayerImage.Margin = new Padding(4);
            picBoxPlayerImage.Name = "picBoxPlayerImage";
            picBoxPlayerImage.Size = new Size(377, 527);
            picBoxPlayerImage.TabIndex = 23;
            picBoxPlayerImage.TabStop = false;
            // 
            // lblPassAccuracy
            // 
            lblPassAccuracy.AutoSize = true;
            lblPassAccuracy.Font = new Font("Segoe UI", 10F);
            lblPassAccuracy.ForeColor = Color.White;
            lblPassAccuracy.Location = new Point(71, 445);
            lblPassAccuracy.Margin = new Padding(4, 0, 4, 0);
            lblPassAccuracy.Name = "lblPassAccuracy";
            lblPassAccuracy.Size = new Size(135, 28);
            lblPassAccuracy.TabIndex = 22;
            lblPassAccuracy.Text = "Pass Accuracy:";
            // 
            // lblMatchesPlayed
            // 
            lblMatchesPlayed.AutoSize = true;
            lblMatchesPlayed.Font = new Font("Segoe UI", 10F);
            lblMatchesPlayed.ForeColor = Color.White;
            lblMatchesPlayed.Location = new Point(71, 373);
            lblMatchesPlayed.Margin = new Padding(4, 0, 4, 0);
            lblMatchesPlayed.Name = "lblMatchesPlayed";
            lblMatchesPlayed.Size = new Size(157, 28);
            lblMatchesPlayed.TabIndex = 21;
            lblMatchesPlayed.Text = "Matches Played: ";
            // 
            // lblAssists
            // 
            lblAssists.AutoSize = true;
            lblAssists.Font = new Font("Segoe UI", 10F);
            lblAssists.ForeColor = Color.White;
            lblAssists.Location = new Point(71, 301);
            lblAssists.Margin = new Padding(4, 0, 4, 0);
            lblAssists.Name = "lblAssists";
            lblAssists.Size = new Size(73, 28);
            lblAssists.TabIndex = 20;
            lblAssists.Text = "Assists:";
            // 
            // lblGoals
            // 
            lblGoals.AutoSize = true;
            lblGoals.Font = new Font("Segoe UI", 10F);
            lblGoals.ForeColor = Color.White;
            lblGoals.Location = new Point(71, 229);
            lblGoals.Margin = new Padding(4, 0, 4, 0);
            lblGoals.Name = "lblGoals";
            lblGoals.Size = new Size(65, 28);
            lblGoals.TabIndex = 19;
            lblGoals.Text = "Goals:";
            // 
            // lblPlayerTeam
            // 
            lblPlayerTeam.AutoSize = true;
            lblPlayerTeam.Font = new Font("Segoe UI", 10F);
            lblPlayerTeam.ForeColor = Color.White;
            lblPlayerTeam.Location = new Point(71, 157);
            lblPlayerTeam.Margin = new Padding(4, 0, 4, 0);
            lblPlayerTeam.Name = "lblPlayerTeam";
            lblPlayerTeam.Size = new Size(119, 28);
            lblPlayerTeam.TabIndex = 18;
            lblPlayerTeam.Text = "Player Team:";
            // 
            // lblPlayersName
            // 
            lblPlayersName.AutoSize = true;
            lblPlayersName.Font = new Font("Segoe UI", 10F);
            lblPlayersName.ForeColor = Color.White;
            lblPlayersName.Location = new Point(71, 85);
            lblPlayersName.Margin = new Padding(4, 0, 4, 0);
            lblPlayersName.Name = "lblPlayersName";
            lblPlayersName.Size = new Size(126, 28);
            lblPlayersName.TabIndex = 17;
            lblPlayersName.Text = "Player Name:";
            // 
            // EditPlayerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1112, 667);
            Controls.Add(btnPlayerPhoto);
            Controls.Add(btnCancel);
            Controls.Add(btnEditPlayer);
            Controls.Add(cmboBoxPlayerTeam);
            Controls.Add(txtPassAccuracy);
            Controls.Add(txtMatchesPlayed);
            Controls.Add(txtAssists);
            Controls.Add(txtGoals);
            Controls.Add(txtPlayersName);
            Controls.Add(picBoxPlayerImage);
            Controls.Add(lblPassAccuracy);
            Controls.Add(lblMatchesPlayed);
            Controls.Add(lblAssists);
            Controls.Add(lblGoals);
            Controls.Add(lblPlayerTeam);
            Controls.Add(lblPlayersName);
            MaximizeBox = false;
            Name = "EditPlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditPlayerForm";
            ((System.ComponentModel.ISupportInitialize)picBoxPlayerImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlayerPhoto;
        private Button btnCancel;
        private Button btnEditPlayer;
        private ComboBox cmboBoxPlayerTeam;
        private TextBox txtPassAccuracy;
        private TextBox txtMatchesPlayed;
        private TextBox txtAssists;
        private TextBox txtGoals;
        private TextBox txtPlayersName;
        private PictureBox picBoxPlayerImage;
        private Label lblPassAccuracy;
        private Label lblMatchesPlayed;
        private Label lblAssists;
        private Label lblGoals;
        private Label lblPlayerTeam;
        private Label lblPlayersName;
    }
}