using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__8
{
    /// <summary>
    /// Интерфейс IPerson
    /// </summary>
    internal interface IPerson
    {
        /// <summary>
        /// Публичное свойство Фамилии
        /// </summary>
        string LastName { get; set; }


        /// <summary>
        /// Публичное свойство Имени
        /// </summary>
        string FirstName { get; set; }


        /// <summary>
        /// Метод содержащий информацию об объекте
        /// </summary>
        /// <returns>Возврат информации об объекте</returns>
        string GetInfo();

        /// <summary>
        /// Метод содержащий информацию о роли объекта
        /// </summary>
        /// <returns>Возврат информации о роли объекта</returns>
        string Role();
    }
}
