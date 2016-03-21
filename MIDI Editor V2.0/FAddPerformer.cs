using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIDI_Library;

namespace MIDI_Editor_V2._0
{
    public partial class FAddPerformer : Form
    {
        public FAddPerformer()
        {
            InitializeComponent();
        }
        BorderStyle bs;
        bool IsClicked = false;
        Point FormCoords = new Point();

        public string NamePerf
        {
            get
            {
                return tb_name_performer.Text;
            }
            set
            {
                tb_name_performer.Text = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return dfound_performer.Value;
            }
            set
            {
                dfound_performer.Value = value;
            }
        }

        public string ImageName
        {
            get
            {
                return openFileDialog.FileName;
            }
            set
            {
                openFileDialog.FileName = value;
            }
        }

        private void FAddPerformer_Load(object sender, EventArgs e)
        {
            try
            {
                pb_img_peformer.Image = Image.FromFile(ImageName);
            }
            catch { }
        }
        public string temp;
        private void lbl_import_MouseLeave(object sender, EventArgs e)
        {
            lbl_import.BorderStyle = bs;
        }

        private void lbl_import_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.FileName = "";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {

                    pb_img_peformer.Image = Image.FromFile(openFileDialog.FileName);
                    tb_img_src.Text = openFileDialog.FileName;
                }
            }
            catch { }
        }

        private void lbl_import_MouseEnter(object sender, EventArgs e)
        {
            bs = lbl_import.BorderStyle;
            lbl_import.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlClose_MouseEnter(object sender, EventArgs e)
        {
            bs = pnlClose.BorderStyle;
            pnlClose.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlClose_MouseLeave(object sender, EventArgs e)
        {
            pnlClose.BorderStyle = bs;
        }

        private void panelFrame_MouseDown(object sender, MouseEventArgs e)
        {
            int x = -e.X - SystemInformation.FrameBorderSize.Width;
            int y = -e.Y - SystemInformation.FrameBorderSize.Height;
            FormCoords = new Point(x, y);
            IsClicked = true;
        }

        private void panelFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked == true)
            {
                Point MousePosition = Control.MousePosition;
                MousePosition.Offset(FormCoords.X, FormCoords.Y);
                Location = new Point(MousePosition.X, MousePosition.Y);
            }
        }

        private void panelFrame_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
        }
    }
}