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
    public class LineSecondExt : Line
    {
        public LineSecondExt()
        {
            this.Y = Staff.Staff_to_up + Staff.Between_staff_rows * 9;
            Line_sName = MIDI_Library.NameLine.SecondExt;
            Note_sName = MIDI_Library.NoteName.A;
            Note_sOctave = MIDI_Library.NoteOctave.Small;
            Lines.Add(this);
        }
        public LineSecondExt(int staffIndex)
        {
            this.Y = Staff.Staff_to_up + Staff.Between_staff_rows * 9 + staffIndex * Staff.Between_staffs;
            Line_sName = MIDI_Library.NameLine.SecondExt;
            Note_sName = MIDI_Library.NoteName.A;
            Note_sOctave = MIDI_Library.NoteOctave.Small;
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
                base.NameLine = MIDI_Library.NameLine.SecondExt;
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
                base.NameNote = MIDI_Library.NoteName.A;
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
                base.OctaveNote = MIDI_Library.NoteOctave.Small;
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
