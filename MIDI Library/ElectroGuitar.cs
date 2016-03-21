using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MIDI_Library
{
    [DataContract(Name = "ElectroGuitar")]
    public class ElectroGuitar  :Guitar
    {
        public override string ImageName()
        {
            return ".\\images\\instruments\\electorguitar.gif";
        }
        public override string PathAudio()
        {
            return base.PathAudio() + "ElectroGuitar\\";
        }
        public  override string ToString()
        {
            return "ElectroGuitar";
        }
    }
}
