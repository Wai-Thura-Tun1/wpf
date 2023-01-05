using Microsoft.Extensions.DependencyInjection;
using WpfOJT.DAO.IRepositories;
using WpfOJT.DAO.Repositories;
using WpfOJT.Services.IServices;
using WpfOJT.Services.Services;

namespace WpfOJT.Services.IOC
{
    /// <summary>
    /// Define the <see cref="DependencyInjection"/>
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Register service using addscoped
        /// </summary>
        /// <param name="services"></param>
        /// <param name="connectionString"></param>
        public static void InjectDependencies(this IServiceCollection services,string connectionString)
        {
            services.AddScoped<IAuthRepository,AuthRepository>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IPostService, PostService>();
        }
    }
}
