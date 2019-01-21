using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Q101.DbDataParameterWrapper.Enums;

namespace Q101.DbDataParameterWrapper.Converters
{
    /// <summary>
    /// Конвертор типов данных БД
    /// </summary>
    public class OracleDbTypesConverter : IOracleDbTypesConverter
    {
        /// <summary>
        /// Справочник для конвертации
        /// </summary>
        private readonly Dictionary<ParameterDbType, OracleDbType> _convertDictionary
            = new Dictionary<ParameterDbType, OracleDbType>()
            {
                { ParameterDbType.Varchar2, OracleDbType.Varchar2 },
                { ParameterDbType.Number, OracleDbType.Int32 },
                { ParameterDbType.Date, OracleDbType.Date }
            };

        /// <summary>
        /// Конвертировать в тип данных параметра Oracle
        /// </summary>
        /// <param name="paramType"></param>
        /// <returns></returns>
        public OracleDbType Convert(ParameterDbType paramType)
        {
            var oracleType = _convertDictionary[paramType];

            return oracleType;
        }
    }
}
