using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Serialization;
using MIDI_Library;
using System.IO;

namespace MIDI_Editor_V2._0
{
    public partial class FSongs : Form
    {
        public FSongs()
        {
            InitializeComponent();
        }
        FEditComposition FEC;
        FAddComp FAs;
        FNoteEdit fn;
        BorderStyle bs;
        bool IsClicked = false;
        Point FormCoords = new Point();

        private void FSongs_Load(object sender, EventArgs e)
        {
            try
            {
                ListBoxRefresh();
                label_album_comp.Text = ((Composition)lb_songs.SelectedItem).Album;
                pb_comp.Image = Image.FromFile(((Composition)lb_songs.SelectedItem).Imagename);
                lb_performers_in_comps.DataSource = null;
                lb_performers_in_comps.DataSource = ((Composition)lb_songs.SelectedItem).Performers;
            }
            catch { }
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

        private void lblAdd_MouseEnter(object sender, EventArgs e)
        {
            bs = lblAdd.BorderStyle;
            lblAdd.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FAs = new FAddComp();
                Composition c;
                FAs.ShowDialog(this);
                if (FAs.DialogResult == DialogResult.OK)
                {
                    c = new Composition(FAs.NameComp, FAs.album, FAs.ImageName);
                    List<Performer> perfs = FAs.Performers;
                    label_album_comp.Text = c.Album;
                    pb_comp.Image = Image.FromFile(c.Imagename);
                    foreach (var performer in FAs.Performers)
                        new CompositionPerformer(c, (Performer)performer);

                }
                ListBoxRefresh();
                Invalidate();
                FSongs.ActiveForm.Update();
            }
            catch { }
        }

        private void lblAdd_MouseLeave(object sender, EventArgs e)
        {
            lblAdd.BorderStyle = bs;
        }
        private void lblEdit_MouseEnter(object sender, EventArgs e)
        {
            bs = lblEdit.BorderStyle;
            lblEdit.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FEC = new FEditComposition();
                var EditedComp = (Composition)lb_songs.SelectedItem;
                FEC.NameComp = EditedComp.Name;
                FEC.Album = EditedComp.Album;
                FEC.Performers = EditedComp.Performers;
                FEC.ImageName = pb_comp.ImageLocation;
                FEC.ShowDialog(this);
                if (FEC.DialogResult == DialogResult.OK)
                {
                    EditedComp.Name = FEC.NameComp;
                    EditedComp.Album = FEC.Album;
                    EditedComp.Imagename = FEC.ImageName;
                    label_album_comp.Text = EditedComp.Album;
                    pb_comp.Image = Image.FromFile(((Composition)lb_songs.SelectedItem).Imagename);
                    foreach (var ba in EditedComp.CompositionPerformers)
                        CompositionPerformer.Items.Remove(ba);
                    EditedComp.Performers.Clear();
                    foreach (var performerItem in FEC.Performers)
                    {
                        new CompositionPerformer(EditedComp, (Performer)performerItem);
                    }
                }
                Invalidate();
                ListBoxRefresh();
                FSongs.ActiveForm.Update();
            }
            catch { }
        }



        private void lblEdit_MouseLeave(object sender, EventArgs e)
        {
            lblEdit.BorderStyle = bs;
        }

        private void lblRemove_MouseEnter(object sender, EventArgs e)
        {
            bs = lblRemove.BorderStyle;
            lblRemove.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lblRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Composition temp = (Composition)lb_songs.SelectedItem;
                int i = 0;
                CompositionPerformer[] items = new CompositionPerformer[CompositionPerformer.Items.Count];
                CompositionPerformer.Items.CopyTo(items);
                while (i < items.Length)
                {
                    var cp = items[i];
                    if (cp.Composition == temp)
                    {
                        CompositionPerformer.Items.Remove(cp);
                    }
                    i++;
                }
                Composition.Items.Remove(((Composition)lb_songs.SelectedItem).ID);
                Update_labels();
                pb_comp.Image = null;
                ListBoxRefresh();
                Invalidate();
                FSongs.ActiveForm.Update();
            }
            catch { }
        }



        private void lblRemove_MouseLeave(object sender, EventArgs e)
        {
            lblRemove.BorderStyle = bs;
        }

        private void lblShow_MouseEnter(object sender, EventArgs e)
        {
            bs = lblShow.BorderStyle;
            lblShow.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("..\\Songs\\" + ((Composition)lb_songs.SelectedItem).DocName + ".nt") == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Такого файлу не існує. Створити?", "Попередження!", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {

                        ((Composition)lb_songs.SelectedItem).DocName = ((Composition)lb_songs.SelectedItem).Name;
                        fn = new FNoteEdit((Composition)lb_songs.SelectedItem);
                        fn.ShowDialog();
                    }
                }
                else
                {
                    fn = new FNoteEdit((Composition)lb_songs.SelectedItem);
                    fn.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Такого файлу не знайдено");
            }

        }

        private void lblShow_MouseLeave(object sender, EventArgs e)
        {
            lblShow.BorderStyle = bs;
        }
        private void ListBoxRefresh()
        {
            lb_songs.DataSource = null;

            lb_songs.DataSource = Composition.Items.Values.ToList();
        }

        private void lb_songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Composition temp = ((Composition)lb_songs.SelectedItem);
                label_album_comp.Text = temp.Album;
                if (temp.Imagename == "*.jpg")
                {
                    pb_comp.Image = null;
                }
                else
                {
                    pb_comp.Image = Image.FromFile(temp.Imagename);
                }
                lb_performers_in_comps.DataSource = null;
                lb_performers_in_comps.DataSource = temp.Performers;
                Invalidate();
                FSongs.ActiveForm.Update();
            }
            catch { }
        }
        private void Update_labels()
        {
            label_album_comp.Text = null;
        }
    }
}