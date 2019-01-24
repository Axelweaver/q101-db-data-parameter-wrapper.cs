# q101-db-data-parameter-wrapper.cs
wrapper that simplifies working with parameters passed to the database

### Nuget package link:
[https://www.nuget.org/packages/Q101.DbDataParameterWrapper](https://www.nuget.org/packages/Q101.DbDataParameterWrapper/ "Nuget package link")

If you need to pass parameters to database with SQL query you use this syntax:

```cs
            var query = 
                @"SELECT Id, Name, Age  
                    FROM Students 
                    WHERE City = :cityParameter
                        AND Age = :ageParameter
                        AND Faculty = :facultyParameter
                        AND Name = :nameParameter";

            var cityParameter = 
                new OracleParameter(
                    "cityParameter", 
                    OracleDbType.NVarchar2, 
                    "New York", 
                    ParameterDirection.Input);

            var ageParameter =
                new OracleParameter(
                    "ageParameter",
                    OracleDbType.Int32,
                    18,
                    ParameterDirection.Input);

            var facultyParameter =
                new OracleParameter(
                    "facultyParameter",
                    OracleDbType.NVarchar2,
                    "Maths",
                    ParameterDirection.Input);

            var nameParameter =
                new OracleParameter(
                    "nameParameter",
                    OracleDbType.NVarchar2,
                    "Alex",
                    ParameterDirection.Input);

            var queryParameters = new IDbDataParameter[]
            {
                cityParameter,
                ageParameter,
                facultyParameter,
                nameParameter
            };

            using (var connection = new OracleConnection("Connection string..."))
            {
                var dbEntries = connection.Query(query, queryParameters);
                
                   . . .
            }
```

**But using this library you can do so**

```cs
using System.Collections.Generic;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using Q101.DbDataParameterWrapper.Parameters.Abstract;

namespace ConsoleAppDbDataBaaseDataParamsWrapper
{
    /// <summary>
    /// Some repository
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// Parameters creator
        /// </summary>
        private readonly IDbParameters _dbParameters;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbParameters">Parameters creator</param>
        public Repository(IDbParameters dbParameters)
        {
            _dbParameters = dbParameters;
        }

        /// <summary>
        /// Get students list
        /// </summary>
        /// <param name="city">City</param>
        /// <param name="age">Age</param>
        /// <param name="faculty">Faculty</param>
        /// <param name="name">Name</param>
        /// <returns></returns>
        public IEnumerable<Student> GetStudents(string city, int age, string faculty, string name)
        {
            var query =
                @"SELECT Id, Name, Age  
                    FROM Students 
                    WHERE City = :cityParameter
                        AND Age = :ageParameter
                        AND Faculty = :facultyParameter
                        AND Name = :nameParameter";

            _dbParameters
                .Input.AddVarchar2("cityParameter", city)
                .Input.AddNumber("ageParameter", age)
                .Input.AddVarchar2("facultyParameter", faculty)
                .Input.AddVarchar2("nameParameter", name);

            using (var connection = new OracleConnection("Connection string..."))
            {
                var dbEntries = connection.Query<Student>(query, _dbParameters.Parameters);

                return dbEntries;
            }

        }
    }
}

```

