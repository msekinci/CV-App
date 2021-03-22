using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MSE.CVApp.Business.Concrete;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.Business.ValidationRules;
using MSE.CVApp.DataAccess.Concrete.Dapper;
using MSE.CVApp.DataAccess.Interfaces;
using MSE.CVApp.DTO.DTOs.AppUserDTOs;
using MSE.CVApp.DTO.DTOs.CertificationDTOs;
using MSE.CVApp.DTO.DTOs.EducationDTOs;
using MSE.CVApp.DTO.DTOs.ExperienceDTOs;
using MSE.CVApp.DTO.DTOs.InterestDTOs;
using MSE.CVApp.DTO.DTOs.SkillDTOs;
using MSE.CVApp.DTO.DTOs.SocialMediaDTOs;
using System.Data;
using System.Data.SqlClient;

namespace MSE.CVApp.Business.IoC.Microsoft
{
    public static class MicrosoftDependencies
    {
        public static void AddCustomDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(con => new SqlConnection(configuration.GetConnectionString("connectionMssql")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(DPGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped<IAppUserRepository, DpAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddTransient<IValidator<AppUserUpdateDTO>, AppUserUpdateValidator>();
            services.AddTransient<IValidator<CertificationAddDTO>, CertificationAddValidator>();
            services.AddTransient<IValidator<CertificationUpdateDTO>, CertificationUpdateValidator>();
            services.AddTransient<IValidator<EducationAddDTO>, EducationAddValidator>();
            services.AddTransient<IValidator<EducationUpdateDTO>, EducationUpdateValidator>();
            services.AddTransient<IValidator<ExperienceAddDTO>, ExperienceAddValidator>();
            services.AddTransient<IValidator<ExperienceUpdateDTO>, ExperienceUpdateValidator>();
            services.AddTransient<IValidator<InterestAddDTO>, InterestAddValidator>();
            services.AddTransient<IValidator<InterestUpdateDTO>, InterestUpdateValidator>();
            services.AddTransient<IValidator<SkillAddDTO>, SkillAddValidator>();
            services.AddTransient<IValidator<SkillUpdateDTO>, SkillUpdateValidator>();
            services.AddTransient<IValidator<SocialMediaAddDTO>, SocialMediaAddValidator>();
            services.AddTransient<IValidator<SocialMediaUpdateDTO>, SocialMediaUpdateValidator>();
        }
    }
}
