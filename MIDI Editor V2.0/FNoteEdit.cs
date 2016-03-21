using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MIDI_Library;
using System.Runtime.Serialization;
using System.Xml;
using System.Media;
using System.Windows;
using System.Threading;
using System.Threading.Tasks;
using System.IO;



namespace MIDI_Editor_V2._0
{
    public partial class FNoteEdit : Form
    {
        bool IsClicked = false;
        Point FormCoords = new Point();
        public Composition Composition;
        int xX, xH, yH, yX, width;
        public static int CurrentStaffIndex { get; set; }
        public static int CurrentMeasureIndex { get; set; }
        public static int CurrentPageIndex { get; set; }
        public static int CurrentStaffPosition { get; set; }
        public Page Page;
        public string SongTitleString { get; set; }
        Thread ThreadPlay;
        Thread ThreadPlayFromStart;
        Thread ThreadFromPosition;
        public FormCreateTrack fct;
        Instrument ins;
        FChooseComp fcc;
        Label[] labels = new Label[10];
        SoundPlayer sn;
        int PositionPlayer = 1;
        public Font TitleFont { get; private set; }
        public string DocumentName { get; set; }
        int i = 0;
        int ij = 0;
        int ih = 0;
        BufferedGraphics Graphics;
        BufferedGraphicsContext myContext;
        public List<Page> Pages = new List<Page>();
        public Song Song = new Song();
        public Track Track;
        public Position pos = new Position();
         public DeleteTrack dt;

        public FNoteEdit(Composition comp)
        {
            InitializeComponent();
            SongTitleString = comp.Name;
            DocumentName = comp.DocName;
            OpenSong(DocumentName);
            Composition = comp;
            timerPlay.Stop();
            timerPlay.Interval = 30;
        }

        public FNoteEdit()
        {
            InitializeComponent();
            timerPlay.Stop();
            timerPlay.Interval = 30;
        }

        private void FNoteEdit_Paint(object sender, PaintEventArgs e)
        {
            try
            {

                Rectangle rect = this.ClientRectangle;
                Graphics.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Graphics.Graphics.FillRectangle(Brushes.White, rect);
                lblFormName.Text = SongTitleString;
                Line.Lines.Clear();
                Page.Draw(Graphics);

                pos.Draw(Graphics);
                Graphics.Render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void Title(string text)
        {

            lblTrack.Text = text;
        }

        private void FNoteEdit_Load(object sender, EventArgs e)
        {
            try
            {
                myContext = BufferedGraphicsManager.Current;

                Graphics = myContext.Allocate(pnl_for_graph.CreateGraphics(), pnl_for_graph.ClientRectangle);

                CurrentStaffIndex = 0;
                CurrentPageIndex = 0;
                CurrentStaffPosition = 0;
                Staff.TopSignature = 4;
                Staff.BottomSignature = 4;
                Page = new Page();
                TitleFont = new Font("Century Gothic", 16);

                Page.Draw(Graphics);
                Track.Draw(Graphics);

            }
            catch { }
        }

        public void OpenSong(string _docName)
        {

            try
            {
                DataContractSerializer xmls = new DataContractSerializer(typeof(Song));
                XmlReader xmlr = XmlReader.Create("..\\Songs\\" + _docName + ".nt");
                Song = (Song)xmls.ReadObject(xmlr);
                xmlr.Close();
                foreach (var item in Song.Tracks.Values.ToList())
                {
                    Label lbl = new Label();
                    lbl.Name = item.NameTrack;
                    lbl.Text = item.NameTrack;
                    lbl.AutoSize = true;
                    lbl.Width = 80;
                    lbl.Height = 25;
                    lbl.ForeColor = SystemColors.ControlLightLight;

                    lbl.BackColor = System.Drawing.Color.Transparent;
                    lbl.Location = new Point(80 * i, 0);
                    lbl.Click += new EventHandler(label_Click);
                    i++;
                    this.Controls["panelTracks"].SuspendLayout();
                    this.Controls["panelTracks"].Controls.Add(lbl);
                    this.Controls["panelTracks"].ResumeLayout();
                }
            }
            catch { }
        }

        public void SaveSong(string _docName)
        {

            DataContractSerializer xmls = new DataContractSerializer(typeof(Song));
            XmlWriter xmlw = XmlWriter.Create("..\\Songs\\" + _docName + ".nt");
            xmls.WriteObject(xmlw, Song);
            xmlw.Close();

        }

        private void FNoteEdit_KeyDown(object sender, KeyEventArgs e)
        {
            ReDraw();
            var Px = pos.X;
            var Py = pos.Y;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int o = 0;
                    Note nt = new NoteQuarter();
                    Note[] NoteArray = new Note[Track.Notes.Count];
                    Track.Notes.CopyTo(NoteArray);
                    int l = 0;
                    bool ExitFromLoop = false;
                    while (l < Line.Lines.Count)
                    {
                        var L = Line.Lines[l];
                        if (pos.Y + 3.5F == L.Y || pos.Y + 3F == L.Y)
                        {
                            bool isBreak = false;
                            if (NoteArray.Length == 0)
                                nt = new NoteQuarter(ij, L);
                            else
                            {
                                while (o < NoteArray.Length)
                                {
                                    if (NoteArray[o].X == pos.X)
                                    {
                                        int x = NoteArray[o].Xpos;
                                        var str = NoteArray[o].ToString();
                                        int index = o;
                                        switch (str)
                                        {
                                            case "PauseSixteenth":
                                                Track.Notes.Remove(NoteArray[o]);
                                                nt = new NoteSixteenth(x, L);
                                                Track.Notes.Insert(index, nt);
                                                isBreak = true;
                                                break;
                                            case "PauseEighth":
                                                Track.Notes.Remove(NoteArray[o]);
                                                nt = new NoteEighth(x, L);
                                                Track.Notes.Insert(index, nt);
                                                isBreak = true;
                                                break;
                                            case "PauseWhole":
                                                Track.Notes.Remove(NoteArray[o]);
                                                nt = new NoteWhole(x, L);
                                                Track.Notes.Insert(index, nt);
                                                isBreak = true;
                                                break;
                                            case "PauseHalf":
                                                Track.Notes.Remove(NoteArray[o]);
                                                nt = new NoteHalf(x, L);
                                                Track.Notes.Insert(index, nt);
                                                isBreak = true;
                                                break;
                                            case "PauseQuarter":
                                                Track.Notes.Remove(NoteArray[o]);
                                                nt = new NoteQuarter(x, L);
                                                Track.Notes.Insert(index, nt);
                                                isBreak = true;
                                                break;
                                            default:
                                                nt = new NoteQuarter(ij, L);
                                                ExitFromLoop = true;
                                                break;
                                        }
                                    }
                                    else
                                        if (ExitFromLoop) { }
                                        else
                                            nt = new NoteQuarter(ij, L);
                                    if (isBreak)
                                        break;
                                    o++;
                                }
                            }
                            try
                            {
                                if (isBreak) { }
                                else
                                    Track.Add(nt, ij);
                            }
                            catch { }
                        }
                        l++;
                    }
                    if (nt.Name == MIDI_Library.Name.Pause)
                        Refresh();
                }
                catch { }
                Refresh();
                ReDraw();
                pos.Draw(Graphics);
                Graphics.Render();
            }
            else if (e.KeyCode == Keys.Right)
            {

                if (pos.X >= Staff.WidthOfStaff)
                {
                   
                    pos.Y += 75;
                    pos.X = 65;
                    ih = ij;
                    ij = 0;
                }
                else
                {

                    pos.X += 30;
                    ij++;
                }
                ReDraw();
                pos.Draw(Graphics);
                Graphics.Render();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                SaveSong(DocumentName);
                ReDraw();
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (pos.Y >= Staff.Staff_to_up - Staff.Between_staff_rows / 2 && pos.Y <= Staff.Staff_to_up + Staff.Between_staff_rows * 9 + Staff.Between_staff_rows / 2)
                {
                    pos.Y += (float)Staff.Between_staff_rows / 2;
                }
                ReDraw();
                pos.Draw(Graphics);
                Graphics.Render();
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (pos.Y > 60 - 3.5F)
                {
                    if (pos.X <= 65)
                    {
                        pos.Y -= 75;
                        pos.X = Staff.WidthOfStaff;
                        ij = ih;
                    }
                    else
                    {
                        pos.X -= 30;
                        ij--;
                    }
                }
                ReDraw();
                pos.Draw(Graphics);
                Graphics.Render();
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (pos.Y >= 50)
                {
                    pos.DrawWhite(Graphics, Px, Py);
                    
                    pos.Y -= (float)Staff.Between_staff_rows / 2;
                }
                ReDraw();
                pos.Draw(Graphics);
                Graphics.Render();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                int z = 0;
                int index = 0;
                int x = 0;
                var type = MIDI_Library.Type.Quarter;
                Note[] NoteArray = new Note[Track.Notes.Count];
                Track.Notes.CopyTo(NoteArray);
                bool isBreak = false;
                for (int iv = 0; iv < Line.Lines.Count; iv++)
                {
                    if (isBreak) { break; }
                    else
                    {
                        var ln = Line.Lines[iv];
                        if (ln.ToString() == "Pause")
                        {
                            while (z < NoteArray.Length)
                            {
                                if ((NoteArray[z].Y == pos.Y && NoteArray[z].X == pos.X) || (NoteArray[z].Y == pos.Y - 0.5F && NoteArray[z].X == pos.X) || (NoteArray[z].Y == pos.Y + 3F && NoteArray[z].X == pos.X))
                                {
                                    index = z;
                                    type = NoteArray[z].Type;
                                    x = NoteArray[z].Xpos;
                                    switch (type)
                                    {
                                        case MIDI_Library.Type.Sixteenth:
                                            Track.Notes[z] = new PauseSixteenth(x, ln);
                                            isBreak = true;
                                            break;
                                        case MIDI_Library.Type.Quarter:
                                            Track.Notes[z] = new PauseQuarter(x, ln);
                                            isBreak = true;
                                            break;
                                        case MIDI_Library.Type.Eighth:
                                            Track.Notes[z] = new PauseEighth(x, ln);
                                            isBreak = true;
                                            break;
                                        case MIDI_Library.Type.Half:

                                            Track.Notes[z] = new PauseHalf(x, ln);
                                            isBreak = true;
                                            break;
                                        case MIDI_Library.Type.Whole:

                                            Track.Notes[z] = new PauseWhole(x, ln);
                                            isBreak = true;
                                            break;
                                    }
                                    if (isBreak)
                                        break;
                                }
                                z++;
                            }
                        }
                    }
                }
                Refresh();
                ReDraw();
                pos.Draw(Graphics);
                Graphics.Render();
            }
            else if (e.KeyCode == Keys.Add)
            {
                Note[] temp = new Note[Track.Notes.Count];
                Track.Notes.CopyTo(temp);
                for (int n = 0; n < Track.Notes.Count; n++)
                {
                    if ((Track.Notes[n].Y == pos.Y && Track.Notes[n].X == pos.X) || (Track.Notes[n].Y == pos.Y - 0.5F && Track.Notes[n].X == pos.X) || Track.Notes[n].Y == pos.Y + 3F && Track.Notes[n].X == pos.X)
                    {
                        var Ln = Track.Notes[n].CurrentLine;
                        var xx = Track.Notes[n].Xpos;
                        if (Track.Notes[n].Name != MIDI_Library.Name.Pause)
                        {
                            switch (Track.Notes[n].Type)
                            {
                                case MIDI_Library.Type.Quarter:
                                    Track.Notes[n] = new NoteEighth(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Half:
                                    Track.Notes[n] = new NoteQuarter(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Whole:
                                    Track.Notes[n] = new NoteHalf(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Eighth:
                                    Track.Notes[n] = new NoteSixteenth(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Sixteenth:
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (Track.Notes[n].Type)
                            {
                                case MIDI_Library.Type.Quarter:
                                    Track.Notes[n] = new PauseEighth(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Half:
                                    Track.Notes[n] = new PauseQuarter(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Whole:
                                    Track.Notes[n] = new PauseHalf(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Eighth:
                                    Track.Notes[n] = new PauseSixteenth(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Sixteenth:
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                Refresh();
                Track.Draw(Graphics);
                Graphics.Render();
            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                Refresh();
                Note[] temp = new Note[Track.Notes.Count];
                Track.Notes.CopyTo(temp);
                for (int n = 0; n < Track.Notes.Count; n++)
                {
                    if ((Track.Notes[n].Y == pos.Y && Track.Notes[n].X == pos.X) || (Track.Notes[n].Y == pos.Y - 0.5F && Track.Notes[n].X == pos.X) || (Track.Notes[n].Y == pos.Y + 3F && Track.Notes[n].X == pos.X))
                    {
                        var Ln = Track.Notes[n].CurrentLine;
                        var xx = Track.Notes[n].Xpos;
                        if (Track.Notes[n].Name != MIDI_Library.Name.Pause)
                        {
                            switch (Track.Notes[n].Type)
                            {
                                case MIDI_Library.Type.Quarter:
                                    Track.Notes[n] = new NoteHalf(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Half:
                                    Track.Notes[n] = new NoteWhole(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Sixteenth:
                                    Track.Notes[n] = new NoteEighth(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Eighth:
                                    Track.Notes[n] = new NoteQuarter(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Whole:
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (Track.Notes[n].Type)
                            {
                                case MIDI_Library.Type.Quarter:
                                    Track.Notes[n] = new PauseHalf(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Half:
                                    Track.Notes[n] = new PauseWhole(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Sixteenth:
                                    Track.Notes[n] = new PauseEighth(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Eighth:
                                    Track.Notes[n] = new PauseQuarter(xx, Ln);
                                    break;
                                case MIDI_Library.Type.Whole:
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                Refresh();
                ReDraw();
                Graphics.Render();
            }
            else if ((e.Shift) && e.KeyCode == Keys.Space)
            {
                if (ThreadPlayFromStart == null)
                {
                    ThreadPlayFromStart = new Thread(PlayTrack);
                    ThreadPlayFromStart.Start();
                }
                else
                {
                    ThreadPlayFromStart.Abort();
                    ThreadPlayFromStart = null;
                }
            }
            else if ((e.Control) && e.KeyCode == Keys.Space)
            {
                ThreadFromPosition = new Thread(PlayTrackFromPosition);
                ThreadFromPosition.Start();
            }
            else
            {
                ReDraw();
            }
        }

        public void PlayTrack()
        {
            try
            {
                PositionPlayer = 0;
                foreach (var NotePlaying in Track.Notes)
                {
                    double time = WAVEDuration.DurationWave(Track.Instrument.PathAudio() + NotePlaying.AudioFileName);
                    sn = new SoundPlayer(Track.Instrument.PathAudio() + NotePlaying.AudioFileName);
                    sn.Play();
                    System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(time));
                    Graphics.Render();
                    PositionPlayer++;
                }
                if (PositionPlayer == Track.Notes.Count)
                {
                    PositionPlayer = 0;
                    ThreadPlayFromStart = null;
                }
            }
            catch { }
        }

        //            public void PlayTrack(Track TempTrack)
        //{

        //    try
        //    {
        //        PositionPlayer = 0;
        //        foreach (var NotePlaying in TempTrack.Notes)
        //        {
        //            double time = WAVEDuration.DurationWave(Track.Instrument.PathAudio() + NotePlaying.AudioFileName);

        //            sn = new SoundPlayer(Track.Instrument.PathAudio() + NotePlaying.AudioFileName);
        //            sn.Play();
        //            System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(time));
        //            Graphics.Render();

        //            PositionPlayer++;
        //        }

        //        if (PositionPlayer == TempTrack.Notes.Count)
        //        {
        //            PositionPlayer = 0;
        //            ThreadPlayFromStart = null;
        //        }
        //    }
        //    catch { }
        //}

        public void PlayTrackFromPosition()
        {
            List<Note> ListForPlaying = Track.Notes.GetRange(PositionPlayer, Track.Notes.Count - PositionPlayer);
            try
            {
                if (PositionPlayer >= 0)
                {
                    foreach (var NotePlaying in ListForPlaying)
                    {
                        double time = WAVEDuration.DurationWave(Track.Instrument.PathAudio() + NotePlaying.AudioFileName);
                        sn = new SoundPlayer(Track.Instrument.PathAudio() + NotePlaying.AudioFileName);
                        sn.Play();
                        System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(time));
                        Graphics.Render();
                        PositionPlayer++;
                    }
                }
                else if (PositionPlayer == Track.Notes.Count)
                {
                    PositionPlayer = 0;
                }
            }
            catch { }
        }

        private void FNoteEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThreadPlayFromStart = null;
            Line.Lines.Clear();
        }

        private void створитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fct = new FormCreateTrack();
                fct.ShowDialog();
                string str;
                if (fct.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    str = fct.NameTrack;
                    ins = fct.Ins;
                    Track = new Track(str, ins, Composition, Staff.TopSignature, Staff.BottomSignature);
                    Song.Tracks.Add(Track.ID, Track);
                }
                else str = "";
                Label lbl = new Label();
                lbl.Name = str;
                lbl.Text = str;
                lbl.AutoSize = true;
                lbl.Width = 80;
                lbl.Height = 25;
                lbl.ForeColor = SystemColors.ControlLightLight;
                lbl.BackColor = System.Drawing.Color.Transparent;
                lbl.Location = new Point(80 * i, 0);
                lbl.Click += new EventHandler(label_Click);
                this.Controls["panelTracks"].SuspendLayout();
                this.Controls["panelTracks"].Controls.Add(lbl);
                this.Controls["panelTracks"].ResumeLayout();
                i++;
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Ви ввели невірні дані." + fe);
            }
        }

        public string GetName()
        {
            return "label_MouseEnter" + i;
        }

        private void label_Click(object sender, System.EventArgs e)
        {
            try
            {
                Refresh();
                Label label = (Label)sender;
                foreach (var item in Song.Tracks.Values.ToList())
                {
                    if (label.Name == item.NameTrack)
                    {
                        Track = (Track)item;
                        Track.Draw(Graphics);
                        Title(label.Name);
                        Graphics.Render();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ви не вибрали доріжку для редагування.");
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DeleteTrack(Song);
                dt.ShowDialog();
                if (dt.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    var tempcontrols = this.Controls["panelTracks"].Controls;
                    foreach (var item in dt.tracks)
                    {
                        foreach (Control control in tempcontrols)
                        {
                            if (control.Name == item)
                                this.Controls["panelTracks"].Controls.Remove(control);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неможливо видалити файл");
            }
        }

        private void panelFrame_MouseDown(object sender, MouseEventArgs e)
        {
            int x = -e.X - SystemInformation.FrameBorderSize.Width;
            int y = -e.Y - SystemInformation.FrameBorderSize.Height;
            FormCoords = new Point(x, y);
            IsClicked = true;
            ReDraw();
        }

        private void panelFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked == true)
            {
                Point MousePosition = Control.MousePosition;
                MousePosition.Offset(FormCoords.X, FormCoords.Y);
                Location = new Point(MousePosition.X, MousePosition.Y);
                ReDraw();
            }
        }

        private void panelFrame_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
            ReDraw();
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FNoteEdit_MouseMove(object sender, MouseEventArgs e)
        {
            lblRowState.Text = "Курсор: Х " + e.X.ToString() + ", Y " + e.Y.ToString();
            ReDraw();
        }

        private void panelFrame_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ToRight();
        }

        public bool IsMiximized()
        {
            if (WindowState == FormWindowState.Maximized)
                return true;
            else if (WindowState == FormWindowState.Normal)
                return false;
            else
                return false;
        }

        public void ToRight()
        {
            if (IsMiximized())
            {
                WindowState = FormWindowState.Normal;
                panelFrame.Width = width;
                panelClose.Location = new Point(xX, yX);
                panelHide.Location = new Point(xH, yH);
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                yX = panelClose.Location.Y;
                yH = panelHide.Location.Y;
                xX = panelClose.Location.X;
                xH = panelHide.Location.X;
                width = panelFrame.Width;
                panelFrame.Width = Width;
                panelClose.Location = new Point(Width - panelClose.Width, yX);
                panelHide.Location = new Point(Width - panelClose.Width - panelHide.Width, yH);
            }
        }

        private void panelHide_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ReDraw();
        }

        private void lblFormName_MouseDown(object sender, MouseEventArgs e)
        {
            int x = -e.X - SystemInformation.FrameBorderSize.Width;
            int y = -e.Y - SystemInformation.FrameBorderSize.Height;
            FormCoords = new Point(x, y);
            IsClicked = true;
            ReDraw();
        }

        private void lblFormName_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked == true)
            {
                Point MousePosition = Control.MousePosition;
                MousePosition.Offset(FormCoords.X, FormCoords.Y);
                Location = new Point(MousePosition.X, MousePosition.Y);

            }
            ReDraw();
        }

        private void lblFormName_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
            ReDraw();
        }

        private void menuStrip_MouseEnter(object sender, EventArgs e)
        {
            ReDraw();
        }

        private void menuStrip_MouseLeave(object sender, EventArgs e)
        {
            ReDraw();
        }

        public void ReDraw()
        {
            try
            {
                Track.Draw(Graphics);
            }
            catch { }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fcc = new FChooseComp();
                fcc.ShowDialog();
                if (fcc.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    Composition = fcc.Composition;
                    Composition.DocName = Composition.Name;
                    SongTitleString = fcc.Composition.Name;
                    DocumentName = Composition.DocName;
                    OpenSong(DocumentName);
                }
            }
            catch
            {
                MessageBox.Show("Не вдалося створити пісню. Спробуйте ще раз");
            }
        }

        private void зберегтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveSong(DocumentName);
        }

        private void lblMan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Меню->Файл->Новий: Створити нову композицію" + "\n" + "Меню->Файл->Зберегти: Зберігає дану композицію" + "\n" + "Меню->Доріжка->Створити: Створити нову доріжку" + "\n" + "Меню->Доріжка->Видалити: Видалити одну із доріжок" + "\n" + "NumPad+: Зменшити довжину ноти" + "\n" + "-: Збільшити довжину ноти" + "\n" + "Enter: Додати ноту" + "\n" + "Delete: Видалити ноту" + "\n" + "Space: Програти комозицію" + "\n" + "Shift+Space: Програти даний трек" + "\n" + "Ctrl+S: Зберегти", "Управління нотним редактором");
        }
    }
}