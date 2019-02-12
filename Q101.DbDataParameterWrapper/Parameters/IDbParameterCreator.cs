using System.Data;
using Q101.DbDataParameterWrapper.Enums;

namespace Q101.DbDataParameterWrapper.Parameters
{
    /// <summary>
    /// Database parameter creator
    /// </summary>
    public interface IDbParameterCreator
    {
        /// <summary>
        /// Create DB parameter
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="type">Parameter type</param>
        /// <param name="value">Parameter value</param>
        /// <param name="direction">Parameter direction</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbDataParameter Create(string name, ParameterDbType type, object value, ParameterDirection direction, int? size = null);
    }
}
