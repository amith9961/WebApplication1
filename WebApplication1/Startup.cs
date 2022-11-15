using HotChocolate;
using HotChocolate.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductionForum.DataAccess.PostgreSQL.ConnectionFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            //services.AddDbContext<DbContext, postgresContext>();
            services.AddPooledDbContextFactory<postgresContext>(p => p.UseNpgsql("User ID=postgres;Password=postgrespassword;Host=localhost;Port=5432;Database=postgres;"));
           // services.AddDbContext<postgresContext>(options => options.UseNpgsql("User ID=postgres;Password=postgrespassword;Host=localhost;Port=5432;Database=postgres;"));
            services
                .AddGraphQLServer()
                .RegisterDbContext<postgresContext>(DbContextKind.Pooled)
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .AddFiltering();
            services.AddScoped<IPostgreSqlDatabaseConnectionFactory, PostgreSqlDatabaseConnectionFactory>();
            //services.AddScoped<IGetRepository, GetRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
    public class Query
    {
        //IGetRepository getRepository;

        public Query()
        {
            //this.getRepository = getRepository;
        }

        [UseDbContext(typeof(postgresContext))]
        [UseFiltering]
        public IQueryable<Article> GetArticles(postgresContext dbContext)
        => dbContext.Articles;
        [UseDbContext(typeof(postgresContext))]
        [UseFiltering]
        public IQueryable<ArticleJob> GetArticleJobs(postgresContext dbContext)
        => dbContext.ArticleJobs;
    }
    public class Mutation
    {
        public Mutation()
        {

        }
        [UseDbContext(typeof(postgresContext))]
        public async Task<int> ArticleMutation(postgresContext dbContext, Article article)
        {
            dbContext.Articles.Add(article);
            await dbContext.SaveChangesAsync();
            return article.Id;
        }
    }
}
