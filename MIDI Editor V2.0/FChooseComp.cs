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
    public partial class FChooseComp : Form
    {
        public FChooseComp()
        {
            InitializeComponent();
        }
        bool IsClicked = false;
        Point FormCoords = new Point();
        BorderStyle bs;
        public Composition Composition
        {
            get
            {
                return (Composition)listBoxComps.SelectedItem;
            }
        }
        private void FChooseComp_Load(object sender, EventArgs e)
        {
             ListBoxRefresh();
        }
        public void ListBoxRefresh()
        {
            listBoxComps.DataSource = null;
            listBoxComps.DataSource = Composition.Items.Values.ToList();
        }
        public FAddComp fac;
        private void lblIfIsnt_Click(object sender, EventArgs e)
        {
            Composition c;
            fac = new FAddComp();
            fac.ShowDialog(this);
            if (fac.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                c = new Composition(fac.NameComp, fac.album, fac.ImageName);
                List<Performer> perfs = fac.Performers;

                foreach (var performer in fac.Performers)
                    new CompositionPerformer(c, (Performer)performer);
            }
            ListBoxRefresh();
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            Close();
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
