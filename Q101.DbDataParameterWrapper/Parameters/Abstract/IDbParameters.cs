using System.Collections.Generic;
using System.Data;

namespace Q101.DbDataParameterWrapper.Parameters.Abstract
{
    /// <summary>
    /// Параметры Оракл
    /// </summary>
    public interface IDbParameters
    {
        /// <summary>
        /// Входящие параметры
        /// </summary>
        IDbParameterDirectionCreator Input { get; }

        /// <summary>
        /// Исходящие параметры
        /// </summary>
        IDbParameterDirectionCreator Output { get; }

        /// <summary>
        /// Параметры
        /// </summary>
        IEnumerable<IDbDataParameter> Parameters { get; set; }
    }
}
