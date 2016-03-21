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
using System.Xml;
using MIDI_Library;

namespace MIDI_Editor_V2._0
{
    public partial class FPerformers : Form
    {
        public FPerformers()
        {
            InitializeComponent();
        }
        FAddPerformer FAP;
        FEditPerformer FEP;

        BorderStyle bs;
        bool IsClicked = false;
        Point FormCoords = new Point();

        private void FPerformers_Load(object sender, EventArgs e)
        {
            ListBoxRefresh();
        }

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

        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            int x = -e.X - SystemInformation.FrameBorderSize.Width;
            int y = -e.Y - SystemInformation.FrameBorderSize.Height;
            FormCoords = new Point(x, y);
            IsClicked = true;
        }

        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked == true)
            {
                Point MousePosition = Control.MousePosition;
                MousePosition.Offset(FormCoords.X, FormCoords.Y);
                Location = new Point(MousePosition.X, MousePosition.Y);
            }
        }

        private void panelMain_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                FAP = new FAddPerformer();
                Performer perf;
                FAP.ShowDialog(this);
                if (FAP.DialogResult == DialogResult.OK)
                {
                    if (IsThere(FAP.NamePerf))
                        MessageBox.Show("Такий виконавець вже існує");
                    else
                    {
                        perf = new Performer(FAP.NamePerf, FAP.ImageName, FAP.Date);
                        pb_performer.Image = Image.FromFile(perf.ImageName);
                        lb_perfs_comps.DataSource = perf.Compositions;
                    }
                }
                ListBoxRefresh();
                Invalidate();
                FPerformers.ActiveForm.Update();
            }
            catch { }


        }
        public bool IsThere(string text)
        {
            bool st = false;
            foreach (var item in Performer.Items.Values.ToList())
            {
                if (item.Name == text)
                {
                    st = true;
                }
                else
                {
                    st = false;
                }
            }
            return st;
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                FEP = new FEditPerformer();
                FEP.NamePerf = ((Performer)lb_performers.SelectedItem).Name;
                FEP.Date = ((Performer)lb_performers.SelectedItem).Date_foundation;
                FEP.ImageName = ((Performer)lb_performers.SelectedItem).ImageName;

                FEP.ShowDialog(this);
                if (FEP.DialogResult == DialogResult.OK)
                {
                    ((Performer)lb_performers.SelectedItem).Name = FEP.NamePerf;
                    ((Performer)lb_performers.SelectedItem).Date_foundation = FEP.Date;
                    ((Performer)lb_performers.SelectedItem).ImageName = FEP.ImageName;
                    pb_performer.Image = Image.FromFile(((Performer)lb_performers.SelectedItem).ImageName);
                    lb_perfs_comps.DataSource = ((Performer)lb_performers.SelectedItem).Compositions;
                }
                Invalidate();
                ListBoxRefresh();
                FPerformers.ActiveForm.Update();
            }
            catch { }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

            Performer tp = (Performer)lb_performers.SelectedItem;
            int i = 0;
            CompositionPerformer[] it = new CompositionPerformer[CompositionPerformer.Items.Count];
            CompositionPerformer.Items.CopyTo(it);
            while (i < it.Length)
            {
                var cp = (it[i]);
                if ((cp).Performer == tp)
                {
                    CompositionPerformer.Items.Remove(cp);
                }
                i++;
            }

            Performer.Items.Remove(((Performer)lb_performers.SelectedItem).ID);
            pb_performer.Image = null;
            if (Performer.Items.Count == 0)
            {
                lb_perfs_comps.DataSource = null;
            }
            else
            {
                lb_perfs_comps.DataSource = ((Performer)lb_performers.SelectedItem).Compositions;
            }
            ListBoxRefresh();
            Invalidate();
        }

        private void lb_performers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Performer perftemp = ((Performer)lb_performers.SelectedItem);
                if (perftemp.ImageName == "*.jpg" || perftemp.ImageName == null)
                {
                    pb_performer.Image = null;
                }
                else
                {
                    pb_performer.Image = Image.FromFile(perftemp.ImageName);
                }
                lb_perfs_comps.DataSource = perftemp.Compositions;
                Invalidate();
                FPerformers.ActiveForm.Update();
            }
            catch { }
        }
        private void ListBoxRefresh()
        {
            lb_performers.DataSource = null;
            lb_performers.DataSource = Performer.Items.Values.ToList();
        }
    }
}