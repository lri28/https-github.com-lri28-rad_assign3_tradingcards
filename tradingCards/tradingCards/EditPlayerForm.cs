using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace tradingCards
{
    public partial class EditPlayerForm : Form
    {
        private Player currentPlayer;

        public EditPlayerForm(Player player)
        {
            InitializeComponent();
            currentPlayer = player;

            // Populate the form with the player's current details
            txtPlayersName.Text = currentPlayer.PlayerName;
            cmboBoxPlayerTeam.Text = currentPlayer.TeamName;
            txtGoals.Text = currentPlayer.Goals.ToString();
            txtAssists.Text = currentPlayer.Assists.ToString();
            txtMatchesPlayed.Text = currentPlayer.MatchesPlayed.ToString();
            txtPassAccuracy.Text = currentPlayer.PassAccuracy.ToString();

            // Load the player's photo if it exists
            string imagePath = Path.Combine(Application.StartupPath, "Images", currentPlayer.PlayerImage ?? "");
            if (File.Exists(imagePath))
            {
                picBoxPlayerImage.Image = Image.FromFile(imagePath);
            }
            else
            {
                picBoxPlayerImage.Image = null; // Leave blank if no image
            }
        }

        // Save edited player details
        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtPlayersName.Text))
                {
                    MessageBox.Show("Player name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(cmboBoxPlayerTeam.Text))
                {
                    MessageBox.Show("Team name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update currentPlayer object with the new details
                currentPlayer.PlayerName = txtPlayersName.Text;
                currentPlayer.TeamName = cmboBoxPlayerTeam.Text;

                // Safely parse numeric fields
                currentPlayer.Goals = string.IsNullOrWhiteSpace(txtGoals.Text) ? 0 : int.Parse(txtGoals.Text);
                currentPlayer.Assists = string.IsNullOrWhiteSpace(txtAssists.Text) ? 0 : int.Parse(txtAssists.Text);
                currentPlayer.MatchesPlayed = string.IsNullOrWhiteSpace(txtMatchesPlayed.Text) ? 0 : int.Parse(txtMatchesPlayed.Text);
                currentPlayer.PassAccuracy = string.IsNullOrWhiteSpace(txtPassAccuracy.Text) ? 0 : decimal.Parse(txtPassAccuracy.Text);

                // Optionally, update the player's photo if a new image is selected
                if (picBoxPlayerImage.ImageLocation != null)
                {
                    string fileName = Path.GetFileName(picBoxPlayerImage.ImageLocation);
                    string targetFolder = Path.Combine(Application.StartupPath, "Images");

                    // Ensure the folder exists
                    if (!Directory.Exists(targetFolder))
                    {
                        Directory.CreateDirectory(targetFolder);
                    }

                    string targetFilePath = Path.Combine(targetFolder, fileName);
                    if (picBoxPlayerImage.ImageLocation != targetFilePath)
                    {
                        File.Copy(picBoxPlayerImage.ImageLocation, targetFilePath, true);
                    }

                    // Update the PlayerImage in the Player object
                    currentPlayer.PlayerImage = fileName;
                }

                // After editing, close the form and return the updated player object
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Close the form without saving
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Select a new photo for the player
        private void btnPlayerPhoto_Click(object sender, EventArgs e)
        {
            // Open file dialog to select a new image
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select Player's Photo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picBoxPlayerImage.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
