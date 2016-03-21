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
    public class PauseHalf : Note
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
        public PauseHalf(int x, Line l)
        {
            this.Xpos = x;
            PauseLine = l;
            this.TypeOfPause = MIDI_Library.Type.Half;
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
            return "PauseHalf";
        }
    }
}
