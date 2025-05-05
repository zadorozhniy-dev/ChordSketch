namespace ChordSketchApp
{
    partial class MainForm
    {
        private System.Windows.Forms.TextBox chordInput;
        private System.Windows.Forms.ListBox chordsListBox;
        private System.Windows.Forms.TextBox lyricsTextBox;
        private System.Windows.Forms.TextBox songTitleTextBox;
        private System.Windows.Forms.Button addChordButton;
        private System.Windows.Forms.Button exportButton;

        private void InitializeComponent()
        {
            this.chordInput = new System.Windows.Forms.TextBox();
            this.chordsListBox = new System.Windows.Forms.ListBox();
            this.lyricsTextBox = new System.Windows.Forms.TextBox();
            this.songTitleTextBox = new System.Windows.Forms.TextBox();
            this.addChordButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // songTitleTextBox
            this.songTitleTextBox.PlaceholderText = "Song Title";
            this.songTitleTextBox.Location = new System.Drawing.Point(20, 20);

            // chordInput
            this.chordInput.PlaceholderText = "Enter Chord";
            this.chordInput.Location = new System.Drawing.Point(20, 60);

            // addChordButton
            this.addChordButton.Text = "Add Chord";
            this.addChordButton.Location = new System.Drawing.Point(150, 60);
            this.addChordButton.Click += new System.EventHandler(this.addChordButton_Click);

            // chordsListBox
            this.chordsListBox.Location = new System.Drawing.Point(20, 100);
            this.chordsListBox.Size = new System.Drawing.Size(200, 100);

            // lyricsTextBox
            this.lyricsTextBox.Multiline = true;
            this.lyricsTextBox.Location = new System.Drawing.Point(20, 210);
            this.lyricsTextBox.Size = new System.Drawing.Size(300, 100);

            // exportButton
            this.exportButton.Text = "Export Song";
            this.exportButton.Location = new System.Drawing.Point(20, 320);
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.songTitleTextBox);
            this.Controls.Add(this.chordInput);
            this.Controls.Add(this.addChordButton);
            this.Controls.Add(this.chordsListBox);
            this.Controls.Add(this.lyricsTextBox);
            this.Controls.Add(this.exportButton);
            this.Text = "ChordSketch";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
