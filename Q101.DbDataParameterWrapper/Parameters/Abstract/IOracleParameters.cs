using System.Collections.Generic;
using System.Data;

namespace Q101.DbDataParameterWrapper.Parameters.Abstract
{
    /// <summary>
    /// Параметры Оракл
    /// </summary>
    public interface IOracleParameters
    {
        /// <summary>
        /// Входящие параметры
        /// </summary>
        IOracleParameterDirectionCreator Input { get; }

        /// <summary>
        /// Исходящие параметры
        /// </summary>
        IOracleParameterDirectionCreator Output { get; }

        /// <summary>
        /// Параметры
        /// </summary>
        IEnumerable<IDbDataParameter> Parameters { get; set; }

        /// <summary>
        /// Добавить входящий параметр типа Varchar2
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение параметра</param>
        /// <param name="size">Размер параметра</param>
        /// <returns></returns>
        IOracleParameters AddInputVarchar2(string name, object value = null, int? size = null);

        /// <summary>
        /// Добавить входящих параметр тип Date
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение параметра</param>
        /// <returns></returns>
        IOracleParameters AddInputDate(string name, object value = null);

        /// <summary>
        /// Добавить входящий параметр типа Number
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение параметра</param>
        /// <param name="size">Размер параметра</param>
        /// <returns></returns>
        IOracleParameters AddInputNumber(string name, object value = null, int? size = null);

        /// <summary>
        /// Добавить исходящий параметр типа Varchar2
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение параметра</param>
        /// <param name="size">Размер параметра</param>
        /// <returns></returns>
        IOracleParameters AddOutputVarchar2(string name, object value = null, int? size = null);

        /// <summary>
        /// Добавить исходящий параметр типа Date
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение параметра</param>
        /// <returns></returns>
        IOracleParameters AddOutputDate(string name, object value = null);

        /// <summary>
        /// Добавить исходящий параметр типа Number
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение параметра</param>
        /// <param name="size">Размер параметра</param>
        /// <returns></returns>
        IOracleParameters AddOutputNumber(string name, object value = null, int? size = null);

    }
}
