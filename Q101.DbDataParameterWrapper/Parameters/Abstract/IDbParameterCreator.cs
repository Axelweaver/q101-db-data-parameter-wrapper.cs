using System.Data;
using Q101.DbDataParameterWrapper.Enums;

namespace Q101.DbDataParameterWrapper.Parameters.Abstract
{
    /// <summary>
    /// Создатель параметра Oracle
    /// </summary>
    public interface IDbParameterCreator
    {
        /// <summary>
        /// Создать параметер
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="type">Тип параметра</param>
        /// <param name="value">Значеие</param>
        /// <param name="direction">Направление</param>
        /// <param name="size">Размер параметра</param>
        /// <returns></returns>
        IDbDataParameter Create(string name, ParameterDbType type, object value, ParameterDirection direction, int? size = null);
    }
}
