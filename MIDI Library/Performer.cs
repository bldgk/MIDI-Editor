using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MIDI_Library
{
    /// <summary>
    /// Класс Виконувач. Наслідується від Base.
    /// </summary>
    [DataContract]
    public class Performer :Base<Performer>
    {  
        /// <summary>
        /// Ім'я композитора та виконавця.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Зображення. Шлях до зображення.
        /// </summary>
        [DataMember]
        public string ImageName { get; set; }
        /// <summary>
        /// Дата заснування групи, день народження виконавця, тощо.
        /// </summary>
        [DataMember]
        public DateTime Date_foundation { get; set; }
        /// <summary>
        /// Список композицій, які виконує даний комаозитор.
        /// </summary>
        public List<Composition> Compositions
        {
            get
            {
                var comps = new List<Composition>();
                foreach(var pc in CompositionPerformer.Items)
                    if (pc.Performer == this)
                        comps.Add(pc.Composition);
                return comps;
            }
        }
        /// <summary>
        /// Список об'єктів зв'язного класу.
        /// </summary>
        public List<CompositionPerformer> CompositionPerformers
        {
            get
            {
                var compperfs = new List<CompositionPerformer>();
                foreach (var cp in CompositionPerformer.Items)
                    if (cp.Performer == this)
                        compperfs.Add(cp);
                return compperfs;
            }
        }
        /// <summary>
        /// Конструктор за замовчуванням.
        /// </summary>
        public Performer() : this("", "",DateTime.Now) { }
        /// <summary>
        /// Конструктор з параметрами, де _Name - Ім'я виконавця або композитора, _ImageName - шлях до зображення, _DateTime - дата заснування)
        /// </summary>
        /// <param name="_Name"></param>
        /// <param name="_ImageName"></param>
        /// <param name="_DateTime"></param>
        public Performer(string _Name, string _ImageName, DateTime _DateTime)
        {
            this.Name = _Name;
            this.ImageName = _ImageName;
            this.Date_foundation = _DateTime;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
                         