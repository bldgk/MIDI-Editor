using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MIDI_Library
{
    [DataContract]
    public class Instrument
    {
        public virtual string ImageName()
        {
            return "..\\images\\instruments\\";
        }
        [DataMember]
        public TypeInstrument TypeInstrument { get; set; }
        public  virtual string PathAudio()
        {
            return "..\\SoundBanks\\";
        }
        public  override string ToString()
        {
            return "Instrument";
        }
    }
    public enum TypeInstrument { String, Wind, Drums, Keyboard, Electronic }
}
