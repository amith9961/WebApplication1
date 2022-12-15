using ProductionForum.DataAccess.PostgreSQL.ConnectionFactory;
using ProductionForum.DataAccess.PostgreSQL.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1;
using WebApplication1.Models;

public interface IGetRepository
{
    Task<IEnumerable<Article>> GetArticles();
}
public class GetRepository : BaseRepository, IGetRepository
{
    #region CONSTRUCTOR

    public GetRepository(IPostgreSqlDatabaseConnectionFactory connectionFactory) : base(connectionFactory)
    {

    }
    public async Task<IEnumerable<Article>> GetArticles()
    {
        var result = await this.QueryAsync("SELECT * FROM article");
        return result;
    }
    #endregion
}