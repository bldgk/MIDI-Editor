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
    public partial class FAddComp : Form
    {
        public FAddComp()
        {
            InitializeComponent();
        }
        BorderStyle bs;
        bool IsClicked = false;
        Point FormCoords = new Point();

        public string NameComp
        {
            get
            {
                return tb_name_comp.Text;
            }
            set
            {
                tb_name_comp.Text = value;
            }
        }

        public string album
        {
            get
            {
                return tb_album.Text;
            }
            set
            {
                tb_album.Text = value;
            }
        }

        public List<Performer> Performers
        {
            get
            {
                var perf  = new List<Performer>();
                foreach (var p in lb_performers_in_comps.SelectedItems)
                    perf.Add((Performer)p);
                return perf;
            }
        }

        private void ListBoxRefresh()
        {
            lb_performers_in_comps.DataSource = null;
            lb_performers_in_comps.DataSource = Performer.Items.Values.ToList();
        }

        private void FAddComp_Load(object sender, EventArgs e)
        {
            ListBoxRefresh();
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

        private void lblImport_MouseEnter(object sender, EventArgs e)
        {
            bs = lblImport.BorderStyle;
            lblImport.BorderStyle = BorderStyle.Fixed3D;
        }

        public string temp;

        private void lblImport_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.FileName = "*.jpg";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    temp = openFileDialog.FileName;
                    pb_img_comp.Image = Image.FromFile(openFileDialog.FileName);
                    textBox1.Text = openFileDialog.FileName;
                }
            }
            catch { }
        }

        private void lblImport_MouseLeave(object sender, EventArgs e)
        {
            lblImport.BorderStyle = bs;
        }

        private void panelClose_MouseEnter(object sender, EventArgs e)
        {
            bs = panelClose.BorderStyle;
            panelClose.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button_add_Click(object sender, EventArgs e)
        {

        }
    }
}
