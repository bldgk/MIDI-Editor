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
    public class LineThird : Line
    {
        public LineThird()
        {
            this.Y = Staff.Staff_to_up + Staff.Between_staff_rows * 5;
            Line_sName = MIDI_Library.NameLine.Third;
            Note_sName = MIDI_Library.NoteName.H;
            Note_sOctave = MIDI_Library.NoteOctave.First;
            Lines.Add(this);
        }
        [DataMember]
        public int StaffIndex
        {
            get;
            set;
        }

        public LineThird(int staffIndex)
        {
            this.Y = Staff.Staff_to_up + Staff.Between_staff_rows * 5 + staffIndex * Staff.Between_staffs;
            Line_sName = MIDI_Library.NameLine.Third;
            Note_sName = MIDI_Library.NoteName.H;
            Note_sOctave = MIDI_Library.NoteOctave.First;
            StaffIndex = staffIndex;
            Lines.Add(this);
        }
        public override void Draw(BufferedGraphics g)
        {

            g.Graphics.DrawLine(Pens.Black, 25, Y, WidthOfLine, Y);
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
                base.NameLine = MIDI_Library.NameLine.Third;
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
                base.NameNote = MIDI_Library.NoteName.H;
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
                base.OctaveNote = MIDI_Library.NoteOctave.First;
            }
        }
        public override string ToString()
        {
            return this.Line_sName.ToString();
        }
    }
}
