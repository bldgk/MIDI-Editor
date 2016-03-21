using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;

namespace MIDI_Library
{
    [DataContract]
    [KnownType(typeof(Guitar))]
    [KnownType(typeof(AcousticGuitar))]
    [KnownType(typeof(ElectroGuitar))]
    [KnownType(typeof(BassGuitar))]
    [KnownType(typeof(Piano))]
    [KnownType(typeof(Saxophone))]
    [KnownType(typeof(Drums))]

    public class Track
    {
        Note nt = new NoteQuarter();
        [DataMember]
        public List<Note> Notes = new List<Note>();
        [DataMember]
        public Guid _compositionId;
        double Sum = 0;
        [DataMember]
        public Dictionary<Guid, Line> Lines = new Dictionary<Guid, Line>();
        [DataMember]
        public int TopSignature { get; set; }
        [DataMember]
        public int BottomSignature { get; set; }
        public Composition Composition
        {
            get
            {
                return Composition.Items[_compositionId];
            }
            set
            {
                _compositionId = value.ID;
            }
        }
        [DataMember]
        public Guid ID { get; set; }
        [DataMember]
        public string NameTrack { get; set; }
        [DataMember]
        public Instrument Instrument;

        public Track()
        {
            this.ID = Guid.NewGuid();
            this.NameTrack = "";
            this.Instrument = new Guitar();
            this.TopSignature = 4;
            this.BottomSignature = 4;
        }

        public Track(string name, Instrument ins, Composition comp,int top, int bottom)
        {
            this.ID = Guid.NewGuid();
            this.NameTrack = name;
            this.Instrument = ins;
            this.Composition = comp;
            this.TopSignature = top;
            this.BottomSignature = bottom;
        }

        public override string ToString()
        {
            return NameTrack;
        }
        
        public void Draw(BufferedGraphics gr)
        {
            foreach (var note in Notes)
            {
                //Sum += 1.0 / Convert.ToInt32(note.GetTypeOfNote());
                //if (Sum == TopSignature / BottomSignature)
                //{
                //    gr.Graphics.DrawLine(Pens.Black, note.X + 25, Staff.Staff_to_up + Staff.Between_staff_rows * 3, note.X + 25, Staff.Staff_to_up + Staff.Between_staff_rows * 7);
                //    Sum = 0;
                //}
                note.Draw(gr);
            }
            gr.Render();
        }
        
        public void Add(Note nt, int x)
        {
            if (x >= Notes.Count)
            {
                Notes.Add(nt);
            }
            else
            {
                bool ok = false;
                for (int i = 0; i < Notes.Count; i++)
                {
                    var nnt = Notes[i];
                    if (nt.X == nnt.X && nt.Y == nnt.Y)
                    {
                        ok = false;
                        break;
                    }
                    else
                    {
                        ok = true;
                    }
                }
                if (ok)
                    Notes.Insert(x, nt);
            }
        }
    }
}