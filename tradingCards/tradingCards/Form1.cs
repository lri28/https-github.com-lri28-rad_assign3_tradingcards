using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing; // Use System.Drawing explicitly

namespace tradingCards
{
    public partial class Form1 : Form
    {
        private List<Player> players = new List<Player>();
        private Player currentPlayer;

        public Form1()
        {
            InitializeComponent();

            try
            {
                // Load player data and teams
                LoadPlayers();
                LoadTeams();
                // Attach event handlers for buttons
                btnSearch.Click += BtnSearch_Click;
                btnAdd.Click += BtnAdd_Click;
                btnEdit.Click += BtnEdit_Click;
                btnDelete.Click += BtnDelete_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing the form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load player data manually (no DB connection, hardcoded data)
        private void LoadPlayers()
        {
            players.Add(new Player(1, "Kylian Mbappé", "Paris Saint-Germain", "mbappe.png", 30, 10, 35, 87.5m));
            players.Add(new Player(2, "Lionel Messi", "Paris Saint-Germain", "messi.png", 25, 20, 33, 89.0m));
            players.Add(new Player(3, "Neymar Jr.", "Paris Saint-Germain", "neymar.png", 15, 12, 32, 84.3m));
            players.Add(new Player(4, "Achraf Hakimi", "Paris Saint-Germain", "hakimi.png", 5, 6, 30, 85.1m));
            players.Add(new Player(5, "Karim Benzema", "Real Madrid", "benzema.png", 20, 5, 28, 83.4m));
            players.Add(new Player(6, "Vinicius Júnior", "Real Madrid", "vinicius.png", 15, 10, 31, 80.2m));
            players.Add(new Player(7, "Luka Modri?", "Real Madrid", "modric.png", 5, 12, 30, 90.1m));
            players.Add(new Player(8, "Thibaut Courtois", "Real Madrid", "courtois.png", 0, 0, 30, 73.6m));
            players.Add(new Player(9, "Kevin De Bruyne", "Manchester City", "debruyne.png", 10, 20, 32, 88.7m));
            players.Add(new Player(10, "Bernardo Silva", "Manchester City", "silva.png", 12, 15, 33, 85.3m));
            players.Add(new Player(11, "Phil Foden", "Manchester City", "foden.png", 18, 8, 30, 84.0m));

            // Display all players initially
            DisplayPlayers(players);
        }

        // Load teams into combo box
        private void LoadTeams()
        {
            var teams = players.Select(p => p.TeamName).Distinct().ToList();
            teams.Insert(0, "View All Players");
            cmboBoxViewPlayers.DataSource = teams;
            cmboBoxViewPlayers.SelectedIndexChanged += CmboBoxViewPlayers_SelectedIndexChanged;
            cmboBoxViewPlayers.SelectedIndex = 0;
        }

        // Display players based on selected team
        private void CmboBoxViewPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTeam = cmboBoxViewPlayers.SelectedItem.ToString();

            // Set the background image based on the selected team
            SetTeamBackgroundImage(selectedTeam);

            if (selectedTeam == "View All Players")
            {
                DisplayPlayers(players);
            }
            else
            {
                var playersInTeam = players.Where(p => p.TeamName == selectedTeam).ToList();
                DisplayPlayers(playersInTeam);
            }
        }


        // Set the background image based on the selected team
        private void SetTeamBackgroundImage(string teamName)
        {
            string imageFile = teamName switch
            {
                "Paris Saint-Germain" => "psg.png",
                "Real Madrid" => "realmadrid.png",
                "Manchester City" => "manchestercity.png",
                _ => null
            };

            if (imageFile != null)
            {
                flowLayoutPanel.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Images", imageFile));
            }
            else
            {
                flowLayoutPanel.BackgroundImage = null;
            }

            flowLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
        }


        // Display players in the FlowLayoutPanel
        private void DisplayPlayers(List<Player> playersToDisplay)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (var player in playersToDisplay)
            {
                try
                {
                    PictureBox playerPictureBox = new PictureBox
                    {
                        Width = 145,
                        Height = 130,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10),
                        Tag = player
                    };

                    string imagePath = Path.Combine(Application.StartupPath, "Images", player.PlayerImage);

                    if (!string.IsNullOrWhiteSpace(player.PlayerImage) && File.Exists(imagePath))
                    {
                        playerPictureBox.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        playerPictureBox.BackColor = Color.Gray;
                    }

                    playerPictureBox.Click += (sender, e) =>
                    {
                        var selectedPlayer = (Player)((PictureBox)sender).Tag;
                        DisplayPlayerDetails(selectedPlayer);
                    };

                    flowLayoutPanel.Controls.Add(playerPictureBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error displaying player {player.PlayerName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Display selected player's details
        private void DisplayPlayerDetails(Player player)
        {
            try
            {
                currentPlayer = player;

                lblPlayerName.DataBindings.Clear();
                lblPlayerTeam.DataBindings.Clear();
                lblGoals.DataBindings.Clear();
                lblAssists.DataBindings.Clear();
                lblMatchesPlayed.DataBindings.Clear();
                lblPassAccuracy.DataBindings.Clear();

                lblPlayerName.DataBindings.Add("Text", player, nameof(player.PlayerName));
                lblPlayerTeam.DataBindings.Add("Text", player, nameof(player.TeamName));
                lblGoals.DataBindings.Add("Text", player, nameof(player.Goals));
                lblAssists.DataBindings.Add("Text", player, nameof(player.Assists));
                lblMatchesPlayed.DataBindings.Add("Text", player, nameof(player.MatchesPlayed));
                lblPassAccuracy.DataBindings.Add("Text", player, nameof(player.PassAccuracy));

                if (player.Goals < 15)
                {
                    lblGoals.Font = new Font(lblGoals.Font, FontStyle.Bold);
                    lblGoals.ForeColor = Color.Red;
                    label3.Font = new Font(lblGoals.Font, FontStyle.Bold);
                    label3.ForeColor = Color.Red;
                }
                else if (player.Goals >= 20)
                {
                    lblGoals.Font = new Font(lblGoals.Font, FontStyle.Bold);
                    lblGoals.ForeColor = Color.DarkGoldenrod;
                    label3.Font = new Font(lblGoals.Font, FontStyle.Bold);
                    label3.ForeColor = Color.DarkGoldenrod;
                }
                else
                {
                    lblGoals.Font = new Font(lblGoals.Font, FontStyle.Regular);
                    lblGoals.ForeColor = Color.FromArgb(64, 64, 64);
                    label3.Font = new Font(lblGoals.Font, FontStyle.Bold);
                    label3.ForeColor = Color.FromArgb(64, 64, 64);
                }

                string imagePath = Path.Combine(Application.StartupPath, "Images", player.PlayerImage);
                if (File.Exists(imagePath))
                {
                    picBoxPlayerImage.Image = Image.FromFile(imagePath);
                }
                else
                {
                    picBoxPlayerImage.Image = null;
                    MessageBox.Show($"Image not found: {imagePath}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying player {player.PlayerName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search players by name
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtBoxSearchPlayer.Text.ToLower();
            var filteredPlayers = players.Where(p => p.PlayerName.ToLower().Contains(searchQuery)).ToList();

            if (filteredPlayers.Count == 0)
            {
                MessageBox.Show("No matching player found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DisplayPlayers(filteredPlayers);
            }
        }

        // Add a new player (using the player list instead of the database)
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            if (addPlayerForm.ShowDialog() == DialogResult.OK)
            {
                players.Add(addPlayerForm.NewPlayer);
                DisplayPlayers(players); // Refresh the list
            }
        }

        // Edit the selected player
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (currentPlayer != null)
            {
                EditPlayerForm editForm = new EditPlayerForm(currentPlayer);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayPlayers(players); // Refresh the list
                }
            }
            else
            {
                MessageBox.Show("Please select a player to edit.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete selected player
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (currentPlayer != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {currentPlayer.PlayerName}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    players.Remove(currentPlayer);
                    DisplayPlayers(players); // Refresh display
                    currentPlayer = null; // Clear selection
                }
            }
            else
            {
                MessageBox.Show("Please select a player to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
