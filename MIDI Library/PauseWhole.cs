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
    public class PauseWhole  :Note
    {
        [DataMember]
        public Type TypeOfPause
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
        public Line PauseLine
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
        public PauseWhole(int x, Line l)
        {
            this.Xpos = x;
            PauseLine = l;
            this.TypeOfPause = MIDI_Library.Type.Whole;
        }
        public override void Draw(System.Drawing.BufferedGraphics g)
        {
            try
            {
                g.Graphics.DrawImage(Image.FromFile(ImageFileName), new Point((int)X, (int)Y));
            }
            catch { }
        }
        public override string ToString()
        {
            return "PauseWhole";
        }
    }
}
