using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MIDI_Library
{
    public class Staff
    {
        BufferedGraphics Graphics { get; set; }
        BufferedGraphicsContext myContext { get; set; }
        public static int Staff_to_up { get; private set; }
        public static int Sizech_to_left { get; private set; }
        public static int Between_staffs { get; private set; }
        public static int Between_staff_rows { get; private set; }
        public static int NumOfMeasuresOnStaff { get; private set; }
        public static int WidthOfStaff { get; private set; }
        public Font SignatureFont
        {
            get;
            set;
        }
        public Image Staffbm { get; set; }
        public static int TopSignature { get; set; }
        public static int BottomSignature { get; set; }

        public Staff()
        {
            try
            {
                Staff_to_up = 60;
                Sizech_to_left = 50;
                Between_staffs = 75;
                Between_staff_rows = 7;
                NumOfMeasuresOnStaff = 4;
                WidthOfStaff = 1000;
                SignatureFont = new Font("Century Gothic", 14);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public void DrawClef(BufferedGraphics g, int staffIndex)
        {
            g.Graphics.DrawImage(Image.FromFile("..\\images\\notes\\clef.gif"), new Point(25, Staff.Staff_to_up + Staff.Between_staff_rows + staffIndex * Between_staffs));
            g.Render();
        }

        public void DrawSize(BufferedGraphics g, int staffIndex)
        {
            g.Graphics.DrawString(TopSignature.ToString(), SignatureFont, Brushes.Black, Sizech_to_left, Staff_to_up + Staff.Between_staff_rows * 3 + staffIndex * Between_staffs - 3, new StringFormat());
            g.Graphics.DrawString(BottomSignature.ToString(), SignatureFont, Brushes.Black, Sizech_to_left, Staff_to_up + Staff.Between_staff_rows * 3 + staffIndex * Between_staffs + SignatureFont.Size - 3, new StringFormat());
            g.Render();
        }

        public void Draw(BufferedGraphics g, int staffIndex)
        {
            LineEigthNinth l98 = new LineEigthNinth(staffIndex);
            LineEighth l8 = new LineEighth(staffIndex);
            LineSeventhEighth l87 = new LineSeventhEighth(staffIndex);
            LineSeventh l7 = new LineSeventh(staffIndex);
            LineSixthSeventh l76 = new LineSixthSeventh(staffIndex);
            LineSixth L6 = new LineSixth(staffIndex);
            LineFifthSixth l65 = new LineFifthSixth(staffIndex);
            LineFifth l5 = new LineFifth(staffIndex);
            LineFourthFifth l54 = new LineFourthFifth(staffIndex);
            LineFourth l4 = new LineFourth(staffIndex);
            LineThirdFourth l43 = new LineThirdFourth(staffIndex);
            LineThird l3 = new LineThird(staffIndex);
            LineSecondThird l32 = new LineSecondThird(staffIndex);
            LineSecond l2 = new LineSecond(staffIndex);
            LineFirstSecond l21 = new LineFirstSecond(staffIndex);
            LineFirst l1 = new LineFirst(staffIndex);
            LineFirstExtFirst l1fe = new LineFirstExtFirst(staffIndex);
            LineFirstExt lfe = new LineFirstExt(staffIndex);
            LineSecondExtFirstExt lfese = new LineSecondExtFirstExt(staffIndex);
            LineSecondExt lsc = new LineSecondExt(staffIndex);
            LinePause lp = new LinePause(staffIndex);
            foreach (var ll in Line.Lines)
            {
                ll.Draw(g);
            }
            DrawSize(g, staffIndex);
            DrawClef(g, staffIndex);
        }
    }
}