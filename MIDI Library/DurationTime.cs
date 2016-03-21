using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDI_Library
{
    public class DurationTime
    {
        double DurationSeconds { get; set; }
        double DurationMinutes { get; set; }
        public DurationTime(double DS, double DM)
        {
            this.DurationSeconds = DS;
            this.DurationMinutes = DM;
        }
        public double GetMinutes()
        {
            return DurationMinutes;
        }
        public double GetSeconds()
        {
            return DurationSeconds;
        }
        public double InMSC()
        {
            return (DurationSeconds - (DurationMinutes * 60)) * 1000;
        }
        public override string ToString()
        {
            return DurationMinutes.ToString() + DurationSeconds.ToString();
        }
    }
}
