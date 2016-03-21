using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDI_Editor_V2._0
{
    public partial class FAbout : Form
    {
        public FAbout()
        {
            InitializeComponent();
        }
        bool IsClicked = false;
        Point FormCoords = new Point();
        BorderStyle bs;
        private void lblform_MouseDown(object sender, MouseEventArgs e)
        {
            int x = -e.X - SystemInformation.FrameBorderSize.Width;
            int y = -e.Y - SystemInformation.FrameBorderSize.Height;
            FormCoords = new Point(x, y);
            IsClicked = true;
        }

        private void lblform_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked == true)
            {
                Point MousePosition = Control.MousePosition;
                MousePosition.Offset(FormCoords.X, FormCoords.Y);
                Location = new Point(MousePosition.X, MousePosition.Y);
            }
        }

        private void lblform_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
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

        private void panelClose_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void labelRun_Click(object sender, EventArgs e)
        {
            bs = labelRun.BorderStyle;
            labelRun.BorderStyle = BorderStyle.Fixed3D;
            labelRun.BorderStyle = bs;
            MessageBox.Show("Після запуску програми відкривається головна форма. Кнопки « Нотний редактор» та «Перегляд вже існуючих пісень та композиторів» дають можливість перейти до самої програми.  Очевидно, що при натисненні кнопки “Нотний редактор” користувач буде працювати з Нотним редактором, а при «Перегляд вже існуючих пісень та композиторів » - переглядати вже існуючих композицій, авторів. Кнопка «Про програму » визиває форму, про інформацію про програму.", "Управління програмою");
        }
    }
}