using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace MIDI_Library
{
    /// <summary>
    /// Клас Композиція. Наслідується від Base. 
    /// </summary>
    [DataContract]
    public class Composition : Base<Composition>
    {
        /// <summary>
        /// Назва композиції.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Постер, тобто шлях до зображення.
        /// </summary>
        [DataMember]
        public string Imagename { get; set; }
        /// <summary>
        /// Албом.
        /// </summary>
        [DataMember]
        public string Album { get; set; }
        /// <summary>
        /// Нотний документ, тобто шлях до файду з нотами.
        /// </summary>
        [DataMember]
        public string DocName { get; set; }
        /// <summary>
        /// Дата створення композиції.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }
        /// <summary>
        /// Клас Song, який належить ції композиції.
        /// </summary>
        public Song song { get; set; }
        // [DataMember]
        /// <summary>
        /// Список виконувачів або композиторів цієї композиції.
        /// </summary>
        public List<Performer> Performers
        {
            get
            {
                List<Performer> perfs = new List<Performer>();
                foreach (var cp in CompositionPerformer.Items)
                    if (cp.Composition == this)
                        perfs.Add(cp.Performer);
                return perfs;
            }
        }
        //[DataMember]
        /// <summary>
        /// Список об'єктів зв'язного класу.
        /// </summary>
        public List<CompositionPerformer> CompositionPerformers
        {
            get
            {
                List<CompositionPerformer> compperf = new List<CompositionPerformer>();
                foreach (var cp in CompositionPerformer.Items)
                    if (cp.Composition == this)
                        compperf.Add(cp);
                return compperf;
            }
        }
        /// <summary>
        /// Констуктор за замовчуванням.
        /// </summary>
        public Composition()
        {
            this.Name = "";
            this.Imagename = "";
            this.Album = "";
        }
        /// <summary>
        /// Конструктор з параметрами, де name - назва композиції, album - альбом, imagename - шлях зображення.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="album"></param>
        /// <param name="imagename"></param>
        public Composition(string name, string album, string imagename)
        {
            this.Name = name;
            this.Imagename = imagename;
            this.Album = album;
        }
        public string IfHasAFile()
        {
            if (this.DocName != null)
            {
                if (File.Exists(".\\Songs\\" + this.DocName + ".nt"))
                    return " \\\u2713\n";
                else
                    return "";
            }
            else
                return "";
        }
        public override string ToString()
        {
            return Name + IfHasAFile();
        }
    }
}