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
    public class Line
    {
        public static List<Line> Lines = new List<Line>();
        private int y;
        public int WidthOfLine
        {
            get
            {
                return Staff.WidthOfStaff;
            }
        }
        [DataMember]
        public NameLine NameLine { get; set; }
        [DataMember]
        public NoteName NameNote
        {
            get;
            set;
        }
        [DataMember]
        public NoteOctave OctaveNote { get; set; }
        [DataMember]
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public float X
        {
            get
            {
                return 25;
            }
        }
        public Line()
        {
            this.Y = 0;
        }
        public Line(int staffIndex)
        {
            this.Y = Staff.Staff_to_up + staffIndex * Staff.Between_staffs;
            Lines.Add(this);
        }
        public virtual void Draw(BufferedGraphics g)
        {
            g.Graphics.DrawLine(Pens.Black, X, Y, WidthOfLine, Y);
        }
    }
    public enum NameLine { SecondExt, BetweenFirstExtraAndSecondExtra, FirstExt, BetweenFirstExtAndFirst, First, BetweenFirstAndSecond, Second, BetweenSecondAndThird, Third, BetweenThirdAndFourth, Fourth, BetweenFourthAndFifth, Fifth, BetweenFifthAndSixth, Sixth, BetweenSixthAndSeventh, Seventh, BetweenSeventhAndEighth, Eighth, BetweenEighthAndNinth,Pause };
    public enum NoteName { C, D, E, F, G, A, H, Pause };
    public enum NoteOctave { First, Second, Third, Small ,Pause};
}
