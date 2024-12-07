using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__8
{
    internal class Worker : Father, IPerson, IComparable, ICloneable
    {
        /// <summary>
        /// Объявление публичного свойства Должности
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Конструктор, инициализирующий фамилию, имя и должность
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="position"></param>
        public Worker(string lastName, string firstName, string position) : base(lastName, firstName)
        {
            Position = position;
        }

        /// <summary>
        /// Метод возвращающий строку с информацией о работнике(Фамилия, Имя и Должность)
        /// </summary>
        /// <returns>Возвращается строка с Фамилией, Именем и Должностью</returns>
        public new string GetInfo()
        {
            return $"{FirstName} {LastName}, {Position}";
        }

        /// <summary>
        /// Метод возвращающий строку "Работник"
        /// </summary>
        /// <returns></returns>
        public new string Role()
        {
            return "Работник";
        }

        /// <summary>
        /// Метод сравнивающий фамилию работника с фамилией отца
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Возвращает 0, если фамилии одинаковые, иначе -1</returns>
        public new int CompareTo(object obj)
        {
            Father father = (Father)obj;
            if (father.LastName == this.LastName) { return 0; }
            else return -1;
        }

        /// <summary>
        /// Создает копию объекта
        /// </summary>
        /// <returns>Возвращает копию объекта</returns>
        public new object Clone()
        {
            return new Worker(LastName, FirstName, Position);
        }
    }
}
