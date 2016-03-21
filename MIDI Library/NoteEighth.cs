using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace MIDI_Library
{
    [DataContract(Name = "NoteEighth")]
    [KnownType(typeof(Line))]
    [KnownType(typeof(LineEigthNinth))]
    [KnownType(typeof(LineEighth))]
    [KnownType(typeof(LineSeventhEighth))]
    [KnownType(typeof(LineFifth))]
    [KnownType(typeof(LineSixthSeventh))]
    [KnownType(typeof(LineFirst))]
    [KnownType(typeof(LineFifthSixth))]
    [KnownType(typeof(LineFourth))]
    [KnownType(typeof(LineFourthFifth))]
    [KnownType(typeof(LineFirstExt))]
    [KnownType(typeof(LineThirdFourth))]
    [KnownType(typeof(LineSecondThird))]
    [KnownType(typeof(LineSecond))]
    [KnownType(typeof(LineFirstSecond))]
    [KnownType(typeof(LineSecondExt))]
    [KnownType(typeof(LineFirstExtFirst))]
    [KnownType(typeof(LineSeventh))]
    [KnownType(typeof(LineSecondExtFirstExt))]
    [KnownType(typeof(LineSixth))]
    [KnownType(typeof(LineThird))]
    [KnownType(typeof(Note))]
    public class NoteEighth : Note
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
        public NoteEighth()
        {
            TypeOfNote = MIDI_Library.Type.Eighth;
            Note_sLine = base.CurrentLine;

        }
        public NoteEighth(int x, Line ln)
        {
            this.Xpos = x;
            this.Note_sLine = ln;
            TypeOfNote = MIDI_Library.Type.Eighth;
        }
        public override void Draw(System.Drawing.BufferedGraphics g)
        {
            try
            {
                if (Octave == MIDI_Library.Octave.First)
                {
                    g.Graphics.DrawImage(Image.FromFile(ImageFileName), new Point((int)X, (int)Y - 15));
                }
                else if (Octave == MIDI_Library.Octave.Second)
                {
                    g.Graphics.DrawImage(Image.FromFile(ImageFileName), new Point((int)X, (int)Y + 2));
                }
                else if (Octave == MIDI_Library.Octave.Third)
                    g.Graphics.DrawImage(Image.FromFile(ImageFileName), new Point((int)X, (int)Y + 2));
            }
            catch { }
        }
        public override string ToString()
        {
            return "NoteEighth";
        }
    }
}
