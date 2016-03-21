using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MIDI_Library
{
    [DataContract(Name = "BassGuitar")]
    public class BassGuitar:Guitar
    {
        public override string ImageName ()
        {
            return ".\\images\\instruments\\bassguitar.gif";
        }
        public BassGuitar()
        {
        }
        public override string PathAudio()
        {
            return base.PathAudio() + "BassGuitar\\";
        }
        public  override string ToString()
        {
            return "BassGuitar";
        }
    }
}
