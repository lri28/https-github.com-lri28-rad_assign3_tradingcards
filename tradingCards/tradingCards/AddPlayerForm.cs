using System;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace tradingCards
{
    public partial class AddPlayerForm : Form
    {
        public Player NewPlayer { get; private set; }  // The new player object to return

        public AddPlayerForm()
        {
            InitializeComponent();
            // Populate the team combo box with predefined teams
            cmboBoxAddPlayerTeam.Items.AddRange(new string[] { "Paris Saint-Germain", "Real Madrid", "Manchester City" });
        }

        // Button click event to add player
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect player data from form fields
                string playerName = txtAddPlayersName.Text;
                string playerTeam = cmboBoxAddPlayerTeam.SelectedItem?.ToString();

                // Parse numeric fields, handle nullable values
                int? goals = string.IsNullOrWhiteSpace(txtAddGoals.Text) ? (int?)null : int.Parse(txtAddGoals.Text);
                int? assists = string.IsNullOrWhiteSpace(txtAddAssists.Text) ? (int?)null : int.Parse(txtAddAssists.Text);
                int? matchesPlayed = string.IsNullOrWhiteSpace(txtAddMatchesPlayed.Text) ? (int?)null : int.Parse(txtAddMatchesPlayed.Text);
                decimal? passAccuracy = string.IsNullOrWhiteSpace(txtAddPassAccuracy.Text) ? (decimal?)null : decimal.Parse(txtAddPassAccuracy.Text);

                // Ensure required fields are filled
                if (string.IsNullOrWhiteSpace(playerName) || playerTeam == null)
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                // Handle image saving (saving the path of the image)
                string photoURL = string.Empty;
                if (picBoxAddPlayerImage.ImageLocation != null)
                {
                    string fileName = Path.GetFileName(picBoxAddPlayerImage.ImageLocation);
                    string targetFolder = Path.Combine(Application.StartupPath, "Images");

                    // Ensure the folder exists
                    if (!Directory.Exists(targetFolder))
                    {
                        Directory.CreateDirectory(targetFolder);
                    }

                    // Define the full file path and copy image
                    string targetFilePath = Path.Combine(targetFolder, fileName);
                    File.Copy(picBoxAddPlayerImage.ImageLocation, targetFilePath, true);

                    // Store the relative path for photo URL
                    photoURL = fileName;
                }

                // Create a new Player object
                NewPlayer = new Player(0, playerName, playerTeam, photoURL, goals ?? 0, assists ?? 0, matchesPlayed ?? 0, passAccuracy ?? 0);

                // Close the form after saving
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Cancel button to close the form without saving
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Open file dialog to select player image
        private void btnAddPlayerPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set selected image to PictureBox
                picBoxAddPlayerImage.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
