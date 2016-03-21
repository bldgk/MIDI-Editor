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
    public partial class DeleteTrack : Form
    {
        Song song;
        public List<String> tr = new List<string>();
        bool IsClicked = false;
        Point FormCoords = new Point();
        BorderStyle bs;

        public DeleteTrack()
        {
            InitializeComponent();
        }

        public DeleteTrack(Song sng)
        {
            InitializeComponent();
            song = sng;
        }public List<String> tracks
        {
            get
            {
                return tr;
            }
        }

        private void DeleteTrack_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        public void RefreshListBox()
        {
            lBTracks.DataSource = null;
            lBTracks.DataSource = song.Tracks.Values.ToList();
        }

        private void butDeleteTrack_Click(object sender, EventArgs e)
        {
            tr.Add(((Track)lBTracks.SelectedItem).ToString());
            song.Tracks.Remove(((Track)lBTracks.SelectedItem).ID);
            RefreshListBox();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panelClose_MouseEnter(object sender, EventArgs e)
        {
            bs = panelClose.BorderStyle;
            panelClose.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BorderStyle = bs;
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
