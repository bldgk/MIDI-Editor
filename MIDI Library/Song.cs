using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;

namespace MIDI_Library
{
    [DataContract]
    public class Song
    {
        [DataMember]
        public Dictionary<Guid, Track> Tracks = new Dictionary<Guid, Track>();

        [DataMember]
        public string Title
        {
            get;
            set;
        }
    }
}