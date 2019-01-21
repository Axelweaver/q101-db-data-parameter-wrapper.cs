using Oracle.ManagedDataAccess.Client;
using Q101.DbDataParameterWrapper.Enums;

namespace Q101.DbDataParameterWrapper.Converters
{
    /// <summary>
    /// Конвертор типов данных БД
    /// </summary>
    public interface IOracleDbTypesConverter
    {
        /// <summary>
        /// Конвертировать
        /// </summary>
        /// <param name="paramType"></param>
        /// <returns></returns>
        OracleDbType Convert(ParameterDbType paramType);
    }
}
