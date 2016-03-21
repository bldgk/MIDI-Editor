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
using System.IO;
using MIDI_Library;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace MIDI_Editor_V2._0
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        FChoicecs FC;
        Color clr = new Color();
        Color clrh = new Color();
        bool IsClicked = false;
        Point FormCoords = new Point();
        int xX, xH, yH, yX, width;
        public int label_infoWidth, label_infoHeight;
        Thread th;
        private void FormMain_Load(object sender, EventArgs e)
        {
            OpenCompositionPerformer();
            OpenPerformers();
            OpenComposition();
            th = new Thread(PlaySound);
            th.Start();
        }
        public void PlaySound()
        {
            SoundPlayer sn = new SoundPlayer(Properties.Resources.loadound);
            sn.Play();
        }
        /// <summary>
        /// Закриття форми.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void X_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// При наведенні на кнопку закриття.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void X_MouseEnter(object sender, EventArgs e)
        {
            clr = X.BackColor;
            X.BackColor = Color.DarkGray;
        }
        /// <summary>
        /// При виведенні курсора з поля кнопки для закриття.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void X_MouseLeave(object sender, EventArgs e)
        {
            X.BackColor = clr;
        }

        /// <summary>
        /// Кнопка для зменшення форми.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// При наведенні на кнопку зменшення форми.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHide_MouseEnter(object sender, EventArgs e)
        {
            clrh = X.BackColor;
            X.BackColor = Color.DarkGray;
        }
        /// <summary>
        /// При виведенні курсора з поля кнопки для зменшення форми.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHide_MouseLeave(object sender, EventArgs e)
        {
            X.BackColor = clrh;
        }

        /// <summary>
        /// При натисканні на панель.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            int x = -e.X - SystemInformation.FrameBorderSize.Width;
            int y = -e.Y - SystemInformation.FrameBorderSize.Height;
            FormCoords = new Point(x, y);
            IsClicked = true;
        }
        /// <summary>
        /// При перетягуванні.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked == true)
            {
                Point MousePosition = Control.MousePosition;
                MousePosition.Offset(FormCoords.X, FormCoords.Y);
                Location = new Point(MousePosition.X, MousePosition.Y);
            }
        }
        /// <summary>
        /// При "відтисненні" панелі.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelMain_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
        }
        /// <summary>
        /// При натисканні двічі на панель.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelMain_DoubleClick(object sender, EventArgs e)
        {
            ToRight();
        }

        FNoteEdit fnt;

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
                panelMain.Width = width;
                X.Location = new Point(xX, yX);
                H.Location = new Point(xH, yH);
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                yX = X.Location.Y;
                yH = H.Location.Y;
                xX = X.Location.X;
                xH = H.Location.X;
                width = panelMain.Width;
                panelMain.Width = Width;
                X.Location = new Point(Width - X.Width, yX);
                H.Location = new Point(Width - X.Width - H.Width, yH);
            }
        }

        public void OpenComposition()
        {
            try
            {

                using (FileStream fs = new FileStream("Composition.xml", FileMode.Open))
                {
                    XmlDictionaryReader xmldr = XmlDictionaryReader.CreateTextReader(fs, Encoding.UTF8, new XmlDictionaryReaderQuotas(), null);
                    DataContractSerializer ser = new DataContractSerializer(typeof(Dictionary<Guid, Composition>));
                    Composition.Items = (Dictionary<Guid, Composition>)ser.ReadObject(xmldr);
                }
            }
            catch { }

        }
        public void SaveComposition()
        {
            try
            {
                XmlTextWriter xw = new XmlTextWriter("Composition.xml", Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                XmlDictionaryWriter xmldw = XmlDictionaryWriter.CreateDictionaryWriter(xw);
                DataContractSerializer ser = new DataContractSerializer(typeof(Dictionary<Guid, Composition>));
                ser.WriteObject(xmldw, Composition.Items);
                xmldw.Close();
                xw.Close();
            }
            catch { }
        }
        public void SavePerformers()
        {
            try
            {
                XmlTextWriter xw = new XmlTextWriter("Performer.xml", Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                XmlDictionaryWriter xmldw = XmlDictionaryWriter.CreateDictionaryWriter(xw);
                DataContractSerializer ser = new DataContractSerializer(typeof(Dictionary<Guid, Performer>));
                ser.WriteObject(xmldw, Performer.Items);
                xmldw.Close();
                xw.Close();
            }
            catch { }
        }
        public void OpenPerformers()
        {
            try
            {

                using (FileStream fs = new FileStream("Performer.xml", FileMode.Open))
                {
                    XmlDictionaryReader xmldr = XmlDictionaryReader.CreateTextReader(fs, Encoding.UTF8, new XmlDictionaryReaderQuotas(), null);
                    DataContractSerializer ser = new DataContractSerializer(typeof(Dictionary<Guid, Performer>));
                    Performer.Items = (Dictionary<Guid, Performer>)ser.ReadObject(xmldr);
                }
            }
            catch { }
        }
        public void OpenCompositionPerformer()
        {
            try
            {
                DataContractSerializer xmls = new DataContractSerializer(typeof(List<CompositionPerformer>));
                XmlReader xmlr = XmlReader.Create("CompositionPerformer.xml");
                CompositionPerformer.Items = (List<CompositionPerformer>)xmls.ReadObject(xmlr);
                xmlr.Close();
            }
            catch { }
        }
        public void SaveCompositionPerformer()
        {
            try
            {
                DataContractSerializer xmls = new DataContractSerializer(typeof(List<CompositionPerformer>));
                XmlWriter xmlw = XmlWriter.Create("CompositionPerformer.xml");
                xmls.WriteObject(xmlw, CompositionPerformer.Items);
                xmlw.Close();
            }
            catch { }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveCompositionPerformer();
            SavePerformers();
            SaveComposition();
        }
        FAbout fa;
        private void lblAbout_MouseEnter(object sender, EventArgs e)
        {
            fa = new FAbout();
            fa.ShowDialog(this);
        }
        private void lblNoteEditorStart_Click(object sender, EventArgs e)
        {
            fnt = new FNoteEdit();
            fnt.ShowDialog();
        }
        private void lblChoose_Click(object sender, EventArgs e)
        {
            FC = new FChoicecs();
            FC.ShowDialog(this);
        }
        BorderStyle bs;
        private void lblChoose_MouseEnter(object sender, EventArgs e)
        {
            bs = lblChoose.BorderStyle;
            lblChoose.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lblChoose_MouseLeave(object sender, EventArgs e)
        {
            lblChoose.BorderStyle = bs;
        }
    }
}