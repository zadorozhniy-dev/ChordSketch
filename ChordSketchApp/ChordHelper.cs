using System.Text.RegularExpressions;

namespace ChordSketchApp
{
    public static class ChordHelper
    {
        // Very basic chord validation (you can improve this later)
        public static bool IsValidChord(string chord)
        {
            var pattern = @"^[A-G][#b]?m?(maj7|7|sus4)?$";
            return Regex.IsMatch(chord, pattern);
        }
    }
}
