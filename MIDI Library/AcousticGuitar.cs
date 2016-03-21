using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MIDI_Library
{
    [DataContract(Name = "AcousticGuitar")]
    public class AcousticGuitar : Guitar
    {
        [DataMember]
        public string name { get; set; }
        public override string ImageName()
        {
            return ".\\images\\instruments\\acousticguitar.gif";
        }
        public AcousticGuitar()
        {
            name = "";
        }
        public override string PathAudio()
        {
            return base.PathAudio() + "AcousticGuitar\\";
        }
        public override string ToString()
        {
            return "AcousticGuitar";
        }
    }
}