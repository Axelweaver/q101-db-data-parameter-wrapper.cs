using System.Collections.Generic;
using System.Data;
using Q101.DbDataParameterWrapper.Parameters.Abstract;

namespace Q101.DbDataParameterWrapper.Parameters.Concrete.Oracle
{
    /// <inheritdoc />
    public class OracleParameters : IDbParameters
    {
        /// <inheritdoc />
        public IDbParameterDirectionCreator Input { get; }

        /// <inheritdoc />
        public IDbParameterDirectionCreator Output { get; }

        private IEnumerable<IDbDataParameter> _parameters;

        /// <inheritdoc />
        public IEnumerable<IDbDataParameter> Parameters
        {
            get
            {
                _parameters = _parameters ?? new List<IDbDataParameter>();
                return _parameters;
            }
            set { _parameters = value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="inputOracleParameterDirectionCreator"></param>
        /// <param name="outputOracleParameterDirectionCreator"></param>
        public OracleParameters(IDbParameterDirectionCreator inputOracleParameterDirectionCreator,
            IDbParameterDirectionCreator outputOracleParameterDirectionCreator)
        {
            Input = inputOracleParameterDirectionCreator;

            Input.SetDirection(ParameterDirection.Input, this);

            Output = outputOracleParameterDirectionCreator;

            Output.SetDirection(ParameterDirection.Output, this);
        }
    }
}
