using Bussiness.IService;
using Bussiness.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using UnitOfWork.Dapper;
using UnitOfWork.Mongo.IRepository;
using UnitOfWork.Mongo.Repository;
using UnitOfWork.UnitOfWork;
using UnitOfWork.UnitOfWork.Interface;

namespace BCDT.Api.System.Installer
{
    public class CServiceInstaller : IInstaller
    {
        public void InstallerService(IServiceCollection services, IConfiguration configuration)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(typeof(IUnitOfWorkDapper<>), typeof(UnitOfWorkDapper<>));
            services.AddScoped(typeof(IUnitOfWorkEF<>), typeof(UnitOfWorkEF<>));
            services.AddScoped(typeof(IUnitOfWorkMongo<>), typeof(UnitOfWorkMongo<>));
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IBaoCaoService, BaoCaoService>();
        }
    }
}
