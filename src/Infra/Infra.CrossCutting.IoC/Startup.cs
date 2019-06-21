using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCutting.IoC
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<IBaseAppService<Team>, BaseAppService<Team>>();
            //services.AddTransient<ITeamAppService, TeamAppService>();

            //services.AddTransient<IBaseService<Team>, BaseService<Team>>();
            //services.AddTransient<ITeamService, TeamService>();

            //services.AddTransient<IBaseRepository<Team>, BaseRepository<Team>>();
            //services.AddTransient<ITeamRepository, TeamRepository>();


        }        
    }
}
