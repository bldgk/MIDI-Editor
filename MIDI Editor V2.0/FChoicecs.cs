using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using MIDI_Library;
using System.Xml;
using System.IO;

namespace MIDI_Editor_V2._0
{
    public partial class FChoicecs : Form
    {
        public FChoicecs()
        {
            InitializeComponent();
        }
        FSongs FS;
        FPerformers FP;
        BorderStyle bs;
        Point FormCoords = new Point();
        bool IsClicked = false;

        private void panel_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_Close_MouseEnter(object sender, EventArgs e)
        {
            bs = panel_Close.BorderStyle;
            panel_Close.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel_Close_MouseLeave(object sender, EventArgs e)
        {
            panel_Close.BorderStyle = bs;
        }

        private void pnlFrame_MouseDown(object sender, MouseEventArgs e)
        {
            int x = -e.X - SystemInformation.FrameBorderSize.Width;
            int y = -e.Y - SystemInformation.FrameBorderSize.Height;
            FormCoords = new Point(x, y);
            IsClicked = true;
        }

        private void pnlFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked == true)
            {
                Point MousePosition = Control.MousePosition;
                MousePosition.Offset(FormCoords.X, FormCoords.Y);
                Location = new Point(MousePosition.X, MousePosition.Y);
            }
        }

        private void pnlFrame_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
        }

        private void lbl_perf_Click(object sender, EventArgs e)
        {
            FP = new FPerformers();
            FP.Show();
        }

        private void lbl_comp_Click(object sender, EventArgs e)
        {
            FS = new FSongs();
            FS.Show();
        }

        private void lbl_perf_MouseEnter(object sender, EventArgs e)
        {
            bs = lbl_perf.BorderStyle;
            lbl_perf.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lbl_perf_MouseLeave(object sender, EventArgs e)
        {
            lbl_perf.BorderStyle = bs;
        }

        private void lbl_comp_MouseEnter(object sender, EventArgs e)
        {
            bs = lbl_comp.BorderStyle;
            lbl_comp.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lbl_comp_MouseLeave(object sender, EventArgs e)
        {
            lbl_comp.BorderStyle = bs;
        }
    }
}
