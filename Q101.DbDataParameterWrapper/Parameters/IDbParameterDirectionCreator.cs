using System.Data;

namespace Q101.DbDataParameterWrapper.Parameters
{
    /// <summary>
    /// Database parameters creator for selected direction
    /// </summary>
    public interface IDbParameterDirectionCreator
    {
        /// <summary>
        /// Create DB parameter Date type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <returns></returns>
        IDbDataParameter Date(string name, object value = null);

        /// <summary>
        /// Create Db parameter Date type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <returns></returns>
        IDbParameters AddDate(string name, object value = null);

        /// <summary>
        /// Create DB parameter DateTime type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <returns></returns>
        IDbDataParameter DateTime(string name, object value = null);

        /// <summary>
        /// Create Db parameter DateTime type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <returns></returns>
        IDbParameters AddDateTime(string name, object value = null);

        /// <summary>
        /// Create DB parameter TimeStamp type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <returns></returns>
        IDbDataParameter TimeStamp(string name, object value = null);

        /// <summary>
        /// Create Db parameter TimeStamp type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <returns></returns>
        IDbParameters AddTimeStamp(string name, object value = null);

        /// <summary>
        /// Create DB parameter Varchar2 type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbDataParameter Varchar2(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Varchar2 type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbParameters AddVarchar2(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Varchar type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbDataParameter Varchar(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Varchar type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbParameters AddVarchar(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter NVarchar type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbDataParameter NVarchar(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter NVarchar type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbParameters AddNVarchar(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Bool type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbDataParameter Bool(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Bool type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbParameters AddBool(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Number type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbDataParameter Number(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Number type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbParameters AddNumber(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Int(32) type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbDataParameter Int(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Int(32) type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbParameters AddInt(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Int64 type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbDataParameter Int64(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Int64 type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbParameters AddInt64(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Decimal type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbDataParameter Decimal(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Decimal type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbParameters AddDecimal(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Byte type
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbDataParameter Byte(string name, object value = null, int? size = null);

        /// <summary>
        /// Create DB parameter Byte type and add to collection list
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        /// <param name="size">Parameter size</param>
        /// <returns></returns>
        IDbParameters AddByte(string name, object value = null, int? size = null);

        /// <summary>
        /// Set direction for this creator
        /// </summary>
        /// <param name="direction">Direction</param>
        /// <param name="oracleParameters">Db params creator</param>
        void SetDirection(ParameterDirection direction, IDbParameters oracleParameters);
    }
}
