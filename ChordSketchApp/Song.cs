using System.Collections;
using System.Collections.Generic;

namespace ChordSketchApp
{
    public class Song
    {
        public string Title { get; set; }
        public IEnumerable Chords { get; set; }
        public string Lyrics { get; set; }
    }
}
