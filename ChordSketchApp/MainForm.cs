using System;
using System.Windows.Forms;

namespace ChordSketchApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addChordButton_Click(object sender, EventArgs e)
        {
            string chord = chordInput.Text;
            if (!string.IsNullOrWhiteSpace(chord))
            {
                chordsListBox.Items.Add(chord);
                chordInput.Clear();
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string lyrics = lyricsTextBox.Text;
            var song = new Song
            {
                Title = songTitleTextBox.Text,
                Chords = chordsListBox.Items,
                Lyrics = lyrics
            };

            Exporter.ExportToText(song);
            MessageBox.Show("Song exported successfully!");
        }
    }
}
