using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace MIDI_Library
{
    /// <summary>
    /// Базовий клас для наслідування. Для зберігання ID.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [DataContract]
    public class Base<T> where T : Base<T>
    {
        /// <summary>
        /// Словник для зберігання об'єктів наслідуваних класів.
        /// </summary>
        public static Dictionary<Guid, T> Items = new Dictionary<Guid, T>();
        /// <summary>
        /// ID об'єкту наслідуваного класу.
        /// </summary>
        [DataMember]
        public Guid ID { get; private set; }
        /// <summary>
        /// Конструктор базового класу. По замовчуванням.
        /// </summary>
        public Base()
        {
            ID = Guid.NewGuid();
            Items.Add(ID, (T)this);
        }
    }
}