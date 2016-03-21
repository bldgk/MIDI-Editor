using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;
using System.Windows;
using System.Media;
using System.IO;


namespace MIDI_Library
{
    [DataContract]
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
    [KnownType(typeof(NoteEighth))]
    [KnownType(typeof(NoteWhole))]
    [KnownType(typeof(NoteQuarter))]
    [KnownType(typeof(NoteSixteenth))]
    [KnownType(typeof(NoteHalf))]
    [KnownType(typeof(PauseEighth))]
    [KnownType(typeof(PauseHalf))]
    [KnownType(typeof(PauseQuarter))]
    [KnownType(typeof(PauseSixteenth))]
    [KnownType(typeof(PauseWhole))]
    [KnownType(typeof(LinePause))]
    
    abstract public class Note
    {
        [DataMember]
        public Name Name
        {
            get
            {
                return (Name)CurrentLine.NameNote;
            }
            set { }
        }
        [DataMember]
        public Type Type
        {
            get;
            set;
        }
        [DataMember]
        public Guid TrackId{get;set;}
        [DataMember]
        public Octave Octave
        {
            get
            {
                return (Octave)CurrentLine.OctaveNote;
            }
            set
            { }
        }
        public string ImageFileName
        {
            get
            {
                return "..\\images\\notes\\" + GetNameNote() + GetTypeOfNote() + GetOktaveOfNote() + ".gif";
            }
            set
            { }
        }            
        public string AudioFileName
        {
            get
            {
                return GetNameNote() + GetTypeOfNote() + GetOktaveOfNote() + ".wav";
            }
            set { }
        }
        [DataMember]
        public int Xpos = 0;
        [DataMember]
        public Line CurrentLine
        {
            get;
            set;
        }
        public float X
        {
            get
            {
                return 65 + Xpos * 30;
            }
            set
            { }
        }
        public float Y
        {
            get
            {
                return CurrentLine.Y - 3.5F;
            }
            set { }
        }
        public Note()
        {
            this.ImageFileName = null;
            this.AudioFileName = null;
            this.Type = MIDI_Library.Type.Quarter;
        }
        public Note(float x, float y)
        {
            this.X = x;
        }
        public Note(int x, Line ln)
        {
            this.Xpos = x;
            this.CurrentLine = ln;
        }
        public void SetNote(string ImageName, string SoundName)
        {
            this.ImageFileName = ImageName;
            this.AudioFileName = SoundName;
        }

        public virtual void Draw(BufferedGraphics g)
        {
            try
            {
                g.Graphics.DrawEllipse(new Pen(Color.Red, 1), new Rectangle(new Point((int)X, (int)Y), new Size(10, 7)));
                g.Graphics.DrawImage(Image.FromFile(ImageFileName), new Point((int)X, (int)Y));
                g.Render();
            }
            catch { }
        }
        public override string ToString()
        {
            return "Note" + this.Name + this.Type + this.Octave;
        }
        public virtual string GetNameNote()
        {
            return Name.ToString();
        }
        public virtual string GetTypeOfNote()
        {
            switch (Type)
            {
                case MIDI_Library.Type.Whole:
                    return "1";
                case MIDI_Library.Type.Half:
                    return "2";
                case MIDI_Library.Type.Quarter:
                    return "4";
                case MIDI_Library.Type.Eighth:
                    return "8";
                case MIDI_Library.Type.Sixteenth:
                    return "16";
                default:
                    return "";
            }
        }
        public virtual string GetOktaveOfNote()
        {
            switch (Octave)
            {
                case MIDI_Library.Octave.First:
                    return "1";
                case MIDI_Library.Octave.Second:
                    return "2";
                case MIDI_Library.Octave.Third:
                    return "3";
                case MIDI_Library.Octave.Pause:
                    return "";
                default:
                    return "";
            }
        }
    }
    public enum Type
    {
        Quarter, Whole, Sixteenth, Eighth, Half
    }
    public enum Octave
    {
        First, Second, Third, Small, Pause
    }
    public enum Name
    {
        C, D, E, F, G, A, H, Pause
    }

}