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
    public class LineFourth : Line
    {
        public LineFourth()
        {
            this.Y = Staff.Staff_to_up + Staff.Between_staff_rows * 4;
            Line_sName = MIDI_Library.NameLine.Fourth;
            Note_sName = MIDI_Library.NoteName.D;
            Note_sOctave = MIDI_Library.NoteOctave.Second;
            Lines.Add(this);
        }
        [DataMember]
        public int StaffIndex
        {
            get;
            set;
        }
        public LineFourth(int staffIndex)
        {
            this.Y = Staff.Staff_to_up + Staff.Between_staff_rows * 4 + staffIndex * Staff.Between_staffs;
            Line_sName = MIDI_Library.NameLine.Fourth;
            Note_sName = MIDI_Library.NoteName.D;
            Note_sOctave = MIDI_Library.NoteOctave.Second;
            StaffIndex = staffIndex;
            Lines.Add(this);
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
                base.NameLine = MIDI_Library.NameLine.Fourth;
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
                base.NameNote = MIDI_Library.NoteName.D;
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
                base.OctaveNote = MIDI_Library.NoteOctave.Second;
            }
        }
        public override void Draw(BufferedGraphics g)
        {
            g.Graphics.DrawLine(Pens.Black, 25, Y, WidthOfLine, Y);
        }
        public override string ToString()
        {
            return this.Line_sName.ToString();
        }
    }
}
