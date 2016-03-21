using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MIDI_Library
{
    /// <summary>
    /// Зв'язний клас, що зв'язує об'єкти класів Composition та Performer
    /// </summary>
    [DataContract]
    public class CompositionPerformer
    {
        /// <summary>
        /// Список об'єктів зв'язного класу.
        /// </summary>
        static public List<CompositionPerformer> Items = new List<CompositionPerformer>();
        /// <summary>
        /// Id, яким об'єкт зв'язаний з об'єктом класу Composition.
        /// </summary>
        [DataMember]
        private Guid _compositionId;
        /// <summary>
        /// Id, яким об'єкт зв'язаний з об'єктом класу Performer
        /// </summary>
        [DataMember]
        private Guid _performerId;
        /// <summary>
        /// Об'єкт класу Composition, з яким зв'язаний даний клас.
        /// </summary>
        public Composition Composition
        {                       
            get
            {
                return Composition.Items[_compositionId];
            }
            set
            {
                _compositionId = value.ID;
            }
        }
        /// <summary>
        /// Об'єкт класу Performer, з яким зв'язаний даний клас.
        /// </summary>
        public Performer Performer
        {
            get
            {
                return Performer.Items[_performerId];
            }
            set
            {
                _performerId = value.ID;
            }
        }
        /// <summary>
        /// Конструктор з параметрами, де c - об'єкт класу Composition, а p- Performer.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        public CompositionPerformer(Composition c, Performer p)
        {
            Composition = c;
            Performer = p;
            Items.Add(this);
        }
    }
}