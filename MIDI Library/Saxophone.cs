using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MIDI_Library
{
    [DataContract(Name = "Saxophone")]
    public class Saxophone  :Instrument
    {
        public override string ImageName()
        {
            return ".\\images\\instruments\\sax.gif";

        }
        [DataMember]
        public TypeInstrument Type
        {
            get
            {
                return base.TypeInstrument;
            }
            set
            {
                base.TypeInstrument = MIDI_Library.TypeInstrument.Wind;
            }
        }
        public override string PathAudio()
        {
            return base.PathAudio() + "Sax\\";
        }
        public override string ToString()
        {
            return "Sax";
        }
    }
}
