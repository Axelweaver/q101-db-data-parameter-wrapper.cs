using System.Data;

namespace Q101.DbDataParameterWrapper.Parameters.Abstract
{
    /// <summary>
    /// Создатель параметров определённого направления
    /// </summary>
    public interface IDbParameterDirectionCreator
    {
        /// <summary>
        /// Создать параметр типа Date
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение параметра</param>
        /// <returns></returns>
        IDbDataParameter Date(string name, object value = null);

        /// <summary>
        /// Добавить параметр даты в общий список параметров
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение параметра</param>
        /// <returns></returns>
        IDbParameters AddDate(string name, object value = null);

        /// <summary>
        /// Создать параметр типа Varchar2
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение</param>
        /// <param name="size">Размер</param>
        /// <returns></returns>
        IDbDataParameter Varchar2(string name, object value = null, int? size = null);

        /// <summary>
        /// Добавить текстовый параметра в общий список параметров
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение</param>
        /// <param name="size">Размер</param>
        /// <returns></returns>
        IDbParameters AddVarchar2(string name, object value = null, int? size = null);

        /// <summary>
        /// Создать параметр типа Number (Int32)
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение</param>
        /// <param name="size">Размер</param>
        /// <returns></returns>
        IDbDataParameter Number(string name, object value = null, int? size = null);

        /// <summary>
        /// Добавить числовый (32 разряда) параметр в общий список параметров
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение</param>
        /// <param name="size">Размер</param>
        /// <returns></returns>
        IDbParameters AddNumber(string name, object value = null, int? size = null);

        /// <summary>
        /// Установить направление параметра (входящий/исходящий)
        /// </summary>
        /// <param name="direction">Направление</param>
        /// <param name="oracleParameters">Создатель параметров</param>
        void SetDirection(ParameterDirection direction, IDbParameters oracleParameters);
    }
}
