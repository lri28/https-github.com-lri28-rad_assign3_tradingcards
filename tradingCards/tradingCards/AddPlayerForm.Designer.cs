namespace tradingCards
{
    partial class AddPlayerForm
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
            btnAddPlayerPhoto = new Button();
            btnCancel = new Button();
            btnAddPlayer = new Button();
            cmboBoxAddPlayerTeam = new ComboBox();
            txtAddPassAccuracy = new TextBox();
            txtAddMatchesPlayed = new TextBox();
            txtAddAssists = new TextBox();
            txtAddGoals = new TextBox();
            txtAddPlayersName = new TextBox();
            picBoxAddPlayerImage = new PictureBox();
            lblPassAccuracy = new Label();
            lblMatchesPlayed = new Label();
            lblAssists = new Label();
            lblGoals = new Label();
            lblPlayerTeam = new Label();
            lblPlayersName = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxAddPlayerImage).BeginInit();
            SuspendLayout();
            // 
            // btnAddPlayerPhoto
            // 
            btnAddPlayerPhoto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPlayerPhoto.ForeColor = Color.Navy;
            btnAddPlayerPhoto.Location = new Point(717, 580);
            btnAddPlayerPhoto.Margin = new Padding(4);
            btnAddPlayerPhoto.Name = "btnAddPlayerPhoto";
            btnAddPlayerPhoto.Size = new Size(279, 54);
            btnAddPlayerPhoto.TabIndex = 48;
            btnAddPlayerPhoto.Text = "Add Trading Card Image";
            btnAddPlayerPhoto.UseVisualStyleBackColor = true;
            btnAddPlayerPhoto.Click += btnAddPlayerPhoto_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Navy;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(353, 580);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 50);
            btnCancel.TabIndex = 47;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.BackColor = Color.Navy;
            btnAddPlayer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPlayer.ForeColor = Color.WhiteSmoke;
            btnAddPlayer.Location = new Point(111, 580);
            btnAddPlayer.Margin = new Padding(4);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(170, 50);
            btnAddPlayer.TabIndex = 46;
            btnAddPlayer.Text = " Add Player";
            btnAddPlayer.UseVisualStyleBackColor = false;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // cmboBoxAddPlayerTeam
            // 
            cmboBoxAddPlayerTeam.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmboBoxAddPlayerTeam.FormattingEnabled = true;
            cmboBoxAddPlayerTeam.Location = new Point(257, 165);
            cmboBoxAddPlayerTeam.Margin = new Padding(4);
            cmboBoxAddPlayerTeam.Name = "cmboBoxAddPlayerTeam";
            cmboBoxAddPlayerTeam.Size = new Size(304, 36);
            cmboBoxAddPlayerTeam.TabIndex = 45;
            // 
            // txtAddPassAccuracy
            // 
            txtAddPassAccuracy.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddPassAccuracy.Location = new Point(257, 453);
            txtAddPassAccuracy.Margin = new Padding(4);
            txtAddPassAccuracy.Name = "txtAddPassAccuracy";
            txtAddPassAccuracy.Size = new Size(304, 34);
            txtAddPassAccuracy.TabIndex = 44;
            // 
            // txtAddMatchesPlayed
            // 
            txtAddMatchesPlayed.Font = new Font("Segoe UI", 10F);
            txtAddMatchesPlayed.Location = new Point(257, 381);
            txtAddMatchesPlayed.Margin = new Padding(4);
            txtAddMatchesPlayed.Name = "txtAddMatchesPlayed";
            txtAddMatchesPlayed.Size = new Size(304, 34);
            txtAddMatchesPlayed.TabIndex = 43;
            // 
            // txtAddAssists
            // 
            txtAddAssists.Font = new Font("Segoe UI", 10F);
            txtAddAssists.Location = new Point(257, 309);
            txtAddAssists.Margin = new Padding(4);
            txtAddAssists.Name = "txtAddAssists";
            txtAddAssists.Size = new Size(304, 34);
            txtAddAssists.TabIndex = 42;
            // 
            // txtAddGoals
            // 
            txtAddGoals.Font = new Font("Segoe UI", 10F);
            txtAddGoals.Location = new Point(257, 237);
            txtAddGoals.Margin = new Padding(4);
            txtAddGoals.Name = "txtAddGoals";
            txtAddGoals.Size = new Size(304, 34);
            txtAddGoals.TabIndex = 41;
            // 
            // txtAddPlayersName
            // 
            txtAddPlayersName.Font = new Font("Segoe UI", 10F);
            txtAddPlayersName.Location = new Point(257, 93);
            txtAddPlayersName.Margin = new Padding(4);
            txtAddPlayersName.Name = "txtAddPlayersName";
            txtAddPlayersName.Size = new Size(304, 34);
            txtAddPlayersName.TabIndex = 40;
            // 
            // picBoxAddPlayerImage
            // 
            picBoxAddPlayerImage.AccessibleDescription = "";
            picBoxAddPlayerImage.AccessibleName = "";
            picBoxAddPlayerImage.BackColor = Color.Plum;
            picBoxAddPlayerImage.Location = new Point(664, 33);
            picBoxAddPlayerImage.Margin = new Padding(4);
            picBoxAddPlayerImage.Name = "picBoxAddPlayerImage";
            picBoxAddPlayerImage.Size = new Size(377, 527);
            picBoxAddPlayerImage.TabIndex = 39;
            picBoxAddPlayerImage.TabStop = false;
            // 
            // lblPassAccuracy
            // 
            lblPassAccuracy.AutoSize = true;
            lblPassAccuracy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassAccuracy.ForeColor = Color.FromArgb(64, 64, 64);
            lblPassAccuracy.Location = new Point(71, 453);
            lblPassAccuracy.Margin = new Padding(4, 0, 4, 0);
            lblPassAccuracy.Name = "lblPassAccuracy";
            lblPassAccuracy.Size = new Size(150, 28);
            lblPassAccuracy.TabIndex = 38;
            lblPassAccuracy.Text = "Pass Accuracy:";
            // 
            // lblMatchesPlayed
            // 
            lblMatchesPlayed.AutoSize = true;
            lblMatchesPlayed.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMatchesPlayed.ForeColor = Color.FromArgb(64, 64, 64);
            lblMatchesPlayed.Location = new Point(71, 381);
            lblMatchesPlayed.Margin = new Padding(4, 0, 4, 0);
            lblMatchesPlayed.Name = "lblMatchesPlayed";
            lblMatchesPlayed.Size = new Size(172, 28);
            lblMatchesPlayed.TabIndex = 37;
            lblMatchesPlayed.Text = "Matches Played: ";
            // 
            // lblAssists
            // 
            lblAssists.AutoSize = true;
            lblAssists.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAssists.ForeColor = Color.FromArgb(64, 64, 64);
            lblAssists.Location = new Point(71, 309);
            lblAssists.Margin = new Padding(4, 0, 4, 0);
            lblAssists.Name = "lblAssists";
            lblAssists.Size = new Size(81, 28);
            lblAssists.TabIndex = 36;
            lblAssists.Text = "Assists:";
            // 
            // lblGoals
            // 
            lblGoals.AutoSize = true;
            lblGoals.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGoals.ForeColor = Color.FromArgb(64, 64, 64);
            lblGoals.Location = new Point(71, 237);
            lblGoals.Margin = new Padding(4, 0, 4, 0);
            lblGoals.Name = "lblGoals";
            lblGoals.Size = new Size(69, 28);
            lblGoals.TabIndex = 35;
            lblGoals.Text = "Goals:";
            // 
            // lblPlayerTeam
            // 
            lblPlayerTeam.AutoSize = true;
            lblPlayerTeam.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPlayerTeam.ForeColor = Color.FromArgb(64, 64, 64);
            lblPlayerTeam.Location = new Point(71, 165);
            lblPlayerTeam.Margin = new Padding(4, 0, 4, 0);
            lblPlayerTeam.Name = "lblPlayerTeam";
            lblPlayerTeam.Size = new Size(132, 28);
            lblPlayerTeam.TabIndex = 34;
            lblPlayerTeam.Text = "Player Team:";
            // 
            // lblPlayersName
            // 
            lblPlayersName.AutoSize = true;
            lblPlayersName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPlayersName.ForeColor = Color.FromArgb(64, 64, 64);
            lblPlayersName.Location = new Point(71, 93);
            lblPlayersName.Margin = new Padding(4, 0, 4, 0);
            lblPlayersName.Name = "lblPlayersName";
            lblPlayersName.Size = new Size(138, 28);
            lblPlayersName.TabIndex = 33;
            lblPlayersName.Text = "Player Name:";
            // 
            // AddPlayerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1112, 667);
            Controls.Add(btnAddPlayerPhoto);
            Controls.Add(btnCancel);
            Controls.Add(btnAddPlayer);
            Controls.Add(cmboBoxAddPlayerTeam);
            Controls.Add(txtAddPassAccuracy);
            Controls.Add(txtAddMatchesPlayed);
            Controls.Add(txtAddAssists);
            Controls.Add(txtAddGoals);
            Controls.Add(txtAddPlayersName);
            Controls.Add(picBoxAddPlayerImage);
            Controls.Add(lblPassAccuracy);
            Controls.Add(lblMatchesPlayed);
            Controls.Add(lblAssists);
            Controls.Add(lblGoals);
            Controls.Add(lblPlayerTeam);
            Controls.Add(lblPlayersName);
            MaximizeBox = false;
            Name = "AddPlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPlayerForm";
            ((System.ComponentModel.ISupportInitialize)picBoxAddPlayerImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPlayerPhoto;
        private Button btnCancel;
        private Button btnAddPlayer;
        private ComboBox cmboBoxAddPlayerTeam;
        private TextBox txtAddPassAccuracy;
        private TextBox txtAddMatchesPlayed;
        private TextBox txtAddAssists;
        private TextBox txtAddGoals;
        private TextBox txtAddPlayersName;
        private PictureBox picBoxAddPlayerImage;
        private Label lblPassAccuracy;
        private Label lblMatchesPlayed;
        private Label lblAssists;
        private Label lblGoals;
        private Label lblPlayerTeam;
        private Label lblPlayersName;
    }
}