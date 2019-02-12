using System.Collections.Generic;
using System.Data;

namespace Q101.DbDataParameterWrapper.Parameters
{
    /// <summary>
    /// Database parameters creator
    /// </summary>
    public interface IDbParameters
    {
        /// <summary>
        /// Input Parameters creator
        /// </summary>
        IDbParameterDirectionCreator Input { get; }

        /// <summary>
        /// Output parameters creator
        /// </summary>
        IDbParameterDirectionCreator Output { get; }

        /// <summary>
        /// Input-output parameters creator
        /// </summary>
        IDbParameterDirectionCreator InputOutput { get; }

        /// <summary>
        /// Return-value parameters creator
        /// </summary>
        IDbParameterDirectionCreator ReturnValue { get; }

        /// <summary>
        /// Parameters collection list
        /// </summary>
        IEnumerable<IDbDataParameter> Parameters { get; set; }
    }
}
