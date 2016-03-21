using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;
using System.Windows.Forms;

namespace MIDI_Library
{
    public class Position
    {
        
        public float X { get; set; }
        public float Y { get; set; }
        public Position()
        {
            this.X = 65;
            this.Y = 81-3.5F;
        }
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public float Height
        {
            get
            {
                return SizeOfPosition.Height;

            }
        }
        public float Width
        {
            get
            {
                return SizeOfPosition.Width;
            }
        }
        public SizeF SizeOfPosition = new SizeF(10,14);
        public void Draw(BufferedGraphics gr)
        {
            gr.Graphics.DrawRectangle(new Pen(Color.Green,1), X,Y-3.5F,Width, Height);
            gr.Render();
        }
        public void DrawWhite(BufferedGraphics gr, float Px, float py)
        {
            

            gr.Graphics.DrawRectangle(new Pen(Color.White, 1), Px, py - 3.5F, Width, Height); 
            gr.Render();
        }


    }
}
