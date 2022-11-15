//using Dapper;
//using ProductionForum.DataAccess.PostgreSQL.ConnectionFactory;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using WebApplication1;
//using WebApplication1.Models;

//namespace ProductionForum.DataAccess.PostgreSQL.Repository
//{
//    public class BaseRepository
//    {
//        private readonly IPostgreSqlDatabaseConnectionFactory _connectionFactory;

//        public BaseRepository(IPostgreSqlDatabaseConnectionFactory connectionFactory)
//        {
//            _connectionFactory = connectionFactory;
//        }

//        public async Task<int> ExecuteAsync(string sqlString, object parameter)
//        {
//            return await _connectionFactory.Connection.ExecuteAsync(sqlString, parameter);
//        } 
//        public async Task<IEnumerable<Article>> QueryAsync(string sqlString)
//        {
//            return await _connectionFactory.Connection.QueryAsync<Article>(sqlString);
//        }
//    }
//}
