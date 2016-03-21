using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MIDI_Library
{
    [DataContract(Name = "Piano")]
    public class Piano  :Instrument
    {
        public override string ImageName()
        {
            return ".\\images\\instruments\\piano.gif";     
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
                base.TypeInstrument = TypeInstrument.Keyboard;
            }
        }
        public override string PathAudio()
        {
            return base.PathAudio() + "Piano\\";
        }
        public override string ToString()
        {
            return "Piano";
        }
    }
}
