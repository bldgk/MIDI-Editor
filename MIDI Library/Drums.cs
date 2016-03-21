using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace MIDI_Library
{
    [DataContract(Name = "Drums")]
    public class Drums     :Instrument
    {
        public override string ImageName()
        {
            return ".\\images\\instruments\\drums.gif";
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
                base.TypeInstrument = MIDI_Library.TypeInstrument.Drums;
            }
        }
        public override string PathAudio()
        {
            return base.PathAudio() + "Drum\\";
        }
        public  override string ToString()
        {
            return "Drums";
        }
    }
}
