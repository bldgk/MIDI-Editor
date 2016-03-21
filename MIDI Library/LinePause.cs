using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MIDI_Library
{
    [DataContract]
    public class LinePause : Line
    {
        public LinePause()
        {
            this.Y = Staff.Staff_to_up + Staff.Between_staff_rows * 3;
            Line_sName = MIDI_Library.NameLine.Pause;
            Note_sName = MIDI_Library.NoteName.Pause;
            Note_sOctave = MIDI_Library.NoteOctave.Pause;
            Lines.Add(this);
        }
        public LinePause(int staffIndex)
        {
            this.Y = Staff.Staff_to_up + Staff.Between_staff_rows * 3 + staffIndex * Staff.Between_staffs;
            Line_sName = MIDI_Library.NameLine.Pause;
            Note_sName = MIDI_Library.NoteName.Pause;
            Note_sOctave = MIDI_Library.NoteOctave.Pause;
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
                base.NameLine = MIDI_Library.NameLine.Pause;
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
                base.NameNote = MIDI_Library.NoteName.Pause;
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
                base.OctaveNote = MIDI_Library.NoteOctave.Pause;
            }
        }
        public override string ToString()
        {
            return this.Line_sName.ToString();
        }
    }
}
