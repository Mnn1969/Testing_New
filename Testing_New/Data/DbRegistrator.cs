using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Testing.DAL.Context;

namespace Testing_New.Data
{
    static class DbRegistrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration Configuration) =>
            services 
                .AddDbContext<TestingDB>(opt =>
                {
                    var type = Configuration["Type"];

                    switch (type)
                    {
                        case null: throw new InvalidOperationException("Не определён тип БД");
                        default: throw new InvalidOperationException($"Тип подключения {type} не поддерживается");

                        case "SQLite":
                            opt.UseSqlite(Configuration.GetConnectionString(type));
                            break;
                        case "InMemory":
                            opt.UseInMemoryDatabase("Testing.db");
                            break;
                    }
                });
    }
}
