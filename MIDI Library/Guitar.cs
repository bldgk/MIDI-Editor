using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MIDI_Library
{
    [DataContract(Name = "Guitar")]
   // [KnownType(typeof(Instrument))]
    public class Guitar:Instrument
    {
        [DataMember]
        public TypeInstrument Type
        {
            get
            {
                return base.TypeInstrument;
            }
            set
            {
                base.TypeInstrument = TypeInstrument.String;
            }
        }
        public Guitar()
        {
            
        }
        public override string PathAudio()
        {
            return base.PathAudio() + "Guitar\\";
        }
        public  override string ToString()
        {
            return "Guitar";
        }
    }
}
