using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;
namespace MIDI_Library
{
    [DataContract]
    public class LineEighth : Line
    {
        public LineEighth()
        {
            this.Y = Staff.Staff_to_up;
            Line_sName = MIDI_Library.NameLine.Eighth;
            Note_sName = MIDI_Library.NoteName.E;
            Note_sOctave = MIDI_Library.NoteOctave.Third;
            Lines.Add(this);
        }
        public LineEighth(int staffIndex)
        {
            this.Y = Staff.Staff_to_up + staffIndex * Staff.Between_staffs;
            Line_sName = MIDI_Library.NameLine.Eighth;
            Note_sName = MIDI_Library.NoteName.E;
            Note_sOctave = MIDI_Library.NoteOctave.Third;
            StaffIndex = staffIndex;
            Lines.Add(this);
        }
        [DataMember]
        public int StaffIndex
        {
            get;
            set;
        }
        [DataMember]
        public NameLine Line_sName
        {
            get
            {
                return base.NameLine;
            }
            set
            {
                base.NameLine = MIDI_Library.NameLine.Eighth;
            }
        }
        [DataMember]
        public NoteName Note_sName
        {
            get
            {
                return base.NameNote;
            }
            set
            {
                base.NameNote = MIDI_Library.NoteName.E;
            }
        }
        [DataMember]
        public NoteOctave Note_sOctave
        {
            get
            {
                return base.OctaveNote;
            }
            set
            {
                base.OctaveNote = MIDI_Library.NoteOctave.Third;
            }
        }
        public override void Draw(BufferedGraphics g)
        {

            g.Graphics.DrawLine(Pens.Transparent, 25, Y, WidthOfLine, Y);
        }
        public override string ToString()
        {
            return Line_sName.ToString();
        }
    }
}
