using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;

namespace MIDI_Library
{
    [DataContract(Name = "NoteWhole")]
    public class NoteWhole : Note
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

        public NoteWhole(int x, Line l)
        {
            this.Xpos = x;
            this.Note_sLine = l;
            this.TypeOfNote = MIDI_Library.Type.Whole;
        }

        public override void Draw(System.Drawing.BufferedGraphics g)
        {
            try
            {
                switch (Octave)
                {
                    case MIDI_Library.Octave.First:
                        g.Graphics.DrawImage(Image.FromFile(ImageFileName), new Point((int)X, (int)Y));
                        break;
                    case MIDI_Library.Octave.Second:
                        g.Graphics.DrawImage(Image.FromFile(ImageFileName), new Point((int)X, (int)Y));
                        break;
                    case MIDI_Library.Octave.Third:
                        g.Graphics.DrawImage(Image.FromFile(ImageFileName), new Point((int)X, (int)Y));
                        break;
                }
            }
            catch { }
        }
        public override string ToString()
        {
            return "NoteWhole";
        }
    }
}
