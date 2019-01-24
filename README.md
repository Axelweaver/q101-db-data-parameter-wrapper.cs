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

            }
'''
