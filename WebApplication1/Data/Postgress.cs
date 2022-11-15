using Npgsql;
using System.Data;

namespace ProductionForum.DataAccess.PostgreSQL.ConnectionFactory
{
    public interface IPostgreSqlDatabaseConnectionFactory
    {
        IDbConnection Connection { get; }
    }
    public class PostgreSqlDatabaseConnectionFactory : IPostgreSqlDatabaseConnectionFactory
    {
        private IDbConnection _dbConnection;
        private  string _connectionString => "User ID=postgres;Password=postgrespassword;Host=localhost;Port=5432;Database=postgres;";
        public PostgreSqlDatabaseConnectionFactory()
        {
        }
        public IDbConnection Connection
        {

            get
            {
                if (_dbConnection == null || _dbConnection.State != ConnectionState.Open)
                {

                    _dbConnection = new NpgsqlConnection(_connectionString);

                }
                return _dbConnection;
            }
        }

        public void Dispose()
        {
            if (_dbConnection != null)
            {
                _dbConnection.Dispose();
            }
        }
    }
}
