using System;
using System.Collections;
using System.IO;
using System.Text;

namespace ChordSketchApp
{
    public static class Exporter
    {
        public static void ExportToText(Song song)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Title: {song.Title}");
            sb.AppendLine("Chords:");
            foreach (var chord in song.Chords)
            {
                sb.AppendLine($"- {chord}");
            }
            sb.AppendLine("\nLyrics:");
            sb.AppendLine(song.Lyrics);

            var fileName = $"{song.Title.Replace(" ", "_")}_{DateTime.Now:yyyyMMddHHmmss}.txt";
            File.WriteAllText($"Songs/{fileName}", sb.ToString());
        }
    }
}
