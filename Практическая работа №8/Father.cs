using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__8
{
    internal class Father : IPerson, IComparable, ICloneable
    {
        /// <summary>
        /// Объявление публичного свойства Фамилии
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Объявление публичного свойства Имени
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Конструктор, инициализирующий фамилию и имя
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        public Father(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        /// <summary>
        /// Метод возвращающий строку с информацией об отце(Фамилия и Имя)
        /// </summary>
        /// <returns>Возвращается строка с Фамилией и Именем</returns>
        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }

        /// <summary>
        /// Метод возвращающий строку "Отец семейства"
        /// </summary>
        /// <returns>Возвращаетс строка "отец семейства"</returns>
        public string Role()
        {
            return "Отец семейства";
        }

        /// <summary>
        /// Метод производящий сравнение
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Возвращает 0, если фамилии одинаковые, иначе -1</returns>
        public int CompareTo(object obj)
        {
            Father worker = (Father)obj;
            if (worker.LastName == this.LastName) { return 0; }
            else return -1;
        }

        /// <summary>
        /// Создает копию объекта
        /// </summary>
        /// <returns>Возвращает копию объекта</returns>
        public object Clone()
        {
            return new Father(LastName, FirstName);
        }
    }
}
