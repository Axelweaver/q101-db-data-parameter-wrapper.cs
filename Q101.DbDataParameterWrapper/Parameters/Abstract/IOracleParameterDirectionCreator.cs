using System.Collections.Generic;
using System.Data;

namespace Q101.DbDataParameterWrapper.Parameters.Abstract
{
    /// <summary>
    /// Создатель параметров определённого направления
    /// </summary>
    public interface IOracleParameterDirectionCreator
    {
        /// <summary>
        /// Создать параметр типа Date
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение параметра</param>
        /// <returns></returns>
        IDbDataParameter Date(string name, object value = null);

        /// <summary>
        /// Создать параметр типа Varchar2
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение</param>
        /// <param name="size">Размер</param>
        /// <returns></returns>
        IDbDataParameter Varchar2(string name, object value = null, int? size = null);

        /// <summary>
        /// Создать массив параметров Varchar2
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        IDbDataParameter[] Varchar2(object[] values);

        /// <summary>
        /// Создать параметр типа Number (Int32)
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение</param>
        /// <param name="size">Размер</param>
        /// <returns></returns>
        IDbDataParameter Number(string name, object value = null, int? size = null);

        /// <summary>
        /// Список int
        /// </summary>
        /// <param name="name"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        IDbDataParameter ListNumber(string name, IEnumerable<int> values);
    }
}
