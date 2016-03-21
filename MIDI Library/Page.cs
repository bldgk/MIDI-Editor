using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MIDI_Library
{
    public class Page
    {
        public int AmountOfStaffsOnPage = 8;
        public List<Staff> Staffs = new List<Staff>();

        public Page()
        {
            this.AmountOfStaffsOnPage = 8;
            for (int i = 0; i < AmountOfStaffsOnPage; i++)
            {
                Staff staff = new Staff();
                AddStaffToPage(staff);
            }
        }

        public void AddStaffToPage(Staff staff)
        {
            Staffs.Add(staff);
        }

        public void Draw(BufferedGraphics g)
        {
            for (int i = 0; i < Staffs.Count; i++)
            {
                Staff staff = (Staff)Staffs[i];
                try
                {
                    staff.Draw(g, i);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
