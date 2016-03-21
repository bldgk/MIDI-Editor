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
    public partial class FormCreateTrack : Form
    {
        public FormCreateTrack()
        {
            InitializeComponent();
        }
        bool IsClicked = false;
        Point FormCoords = new Point();
        public List<Instrument> Instruments = new List<Instrument>();

        public string NameTrack
        {
            get
            {
                return tBCreateTrack.Text;
            }
            set
            {
                tBCreateTrack.Text = value;
            }
        }

        public Instrument Ins
        {
            get
            {
                if ((cBInstruments.SelectedItem).ToString() == "Piano")
                {
                    return (Piano)cBInstruments.SelectedItem;
                }
                else if ((cBInstruments.SelectedItem).ToString() == "AcousticGuitar")
                {
                    return (AcousticGuitar)cBInstruments.SelectedItem;
                }
                else if ((cBInstruments.SelectedItem).ToString() == "ElectroGuitar")
                {
                    return (ElectroGuitar)cBInstruments.SelectedItem;
                }
                else if ((cBInstruments.SelectedItem).ToString() == "BassGuitar")
                    return (BassGuitar)cBInstruments.SelectedItem;
                else if ((cBInstruments.SelectedItem).ToString() == "Sax")
                    return (Saxophone)cBInstruments.SelectedItem;
                else if ((cBInstruments.SelectedItem).ToString() == "Drums")
                    return (Drums)cBInstruments.SelectedItem;
                else return null;
            }
        }

        private void FormCreateTrack_Load(object sender, EventArgs e)
        {
            Instruments.Add(new AcousticGuitar());
            Instruments.Add(new Piano());
            Instruments.Add(new Saxophone());
            Instruments.Add(new ElectroGuitar());
            Instruments.Add(new BassGuitar());
            Instruments.Add(new Drums());
            
            cBInstruments.DataSource = Instruments;
        }

        private void cBInstruments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instrument ins = (Instrument)cBInstruments.SelectedItem;
            pictureBox.Image = Image.FromFile(ins.ImageName());
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

        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
                 
