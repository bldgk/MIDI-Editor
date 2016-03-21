using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;

namespace MIDI_Library
{
    [DataContract(Name = "NoteHalf")]
    public class NoteHalf : Note
    {
        [DataMember]
        public Type TypeOfNote
        {
            get
            {
                return base.Type;
            }
            set
            {
                base.Type = value;
            }
        }
        public Line Note_sLine
        {
            get
            {
                return base.CurrentLine;
            }
            set
            {
                base.CurrentLine = value;
            }
        }
        public NoteHalf(int x, Line ln)
        {
            this.Xpos = x;
            this.CurrentLine = ln;
            this.TypeOfNote = MIDI_Library.Type.Half;
        }
        public override void Draw(System.Drawing.BufferedGraphics g)
        {
            try
            {
                if (Octave == MIDI_Library.Octave.First)
                {
                    g.Graphics.DrawImage(Image.FromFile(ImageFileName), new Point((int)X, (int)Y - 20));
                }
                else if (Octave == MIDI_Library.Octave.Second)
                {
                    g.Graphics.DrawImage(Image.FromFile(ImageFileName), new Point((int)X, (int)Y - 2));
                }
                else if (Octave == MIDI_Library.Octave.Third)
                    g.Graphics.DrawImage(Image.FromFile(ImageFileName), new Point((int)X, (int)Y - 2));
            }
            catch { }
        }
        public override string ToString()
        {
            return "NoteHalf";
        }
    }
}
