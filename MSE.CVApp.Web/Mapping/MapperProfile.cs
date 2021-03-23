using AutoMapper;
using MSE.CVApp.DTO.DTOs.AppUserDTOs;
using MSE.CVApp.DTO.DTOs.CertificationDTOs;
using MSE.CVApp.DTO.DTOs.EducationDTOs;
using MSE.CVApp.DTO.DTOs.ExperienceDTOs;
using MSE.CVApp.DTO.DTOs.InterestDTOs;
using MSE.CVApp.DTO.DTOs.SkillDTOs;
using MSE.CVApp.DTO.DTOs.SocialMediaDTOs;
using MSE.CVApp.Entities.Concrete;

namespace MSE.CVApp.Web.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, AppUserListDTO>();
            CreateMap<AppUserListDTO, AppUser>();

            CreateMap<Certification, CertificationListDTO>();
            CreateMap<CertificationListDTO, Certification>();
            CreateMap<CertificationAddDTO, Certification>();
            CreateMap<Certification, CertificationAddDTO>();
            CreateMap<CertificationUpdateDTO, Certification>();
            CreateMap<Certification, CertificationUpdateDTO>();


            CreateMap<Education, EducationListDTO>();
            CreateMap<EducationListDTO, Education>();
            CreateMap<EducationAddDTO, Education>();
            CreateMap<Education, EducationAddDTO>();
            CreateMap<Education, EducationUpdateDTO>();
            CreateMap<EducationUpdateDTO, Education>();


            CreateMap<Experience, ExperienceListDTO>();
            CreateMap<ExperienceListDTO, Experience>();
            CreateMap<Experience, ExperienceAddDTO>();
            CreateMap<ExperienceAddDTO, Experience>();
            CreateMap<Experience, ExperienceUpdateDTO>();
            CreateMap<ExperienceUpdateDTO, Experience>();


            CreateMap<Interest, InterestListDTO>();
            CreateMap<InterestListDTO, Interest>();
            CreateMap<Interest, InterestAddDTO>();
            CreateMap<InterestAddDTO, Interest>();
            CreateMap<Interest, InterestUpdateDTO>();
            CreateMap<InterestUpdateDTO, Interest>();


            CreateMap<Skill, SkillListDTO>();
            CreateMap<SkillListDTO, Skill>();
            CreateMap<Skill, SkillAddDTO>();
            CreateMap<SkillAddDTO, Skill>();
            CreateMap<Skill, SkillUpdateDTO>();
            CreateMap<SkillUpdateDTO, Skill>();


            CreateMap<SocialMediaIcon, SocialMediaListDTO>();
            CreateMap<SocialMediaListDTO, SocialMediaIcon>();
            CreateMap<SocialMediaIcon, SocialMediaAddDTO>();
            CreateMap<SocialMediaAddDTO, SocialMediaIcon>();
            CreateMap<SocialMediaIcon, SocialMediaUpdateDTO>();
            CreateMap<SocialMediaUpdateDTO, SocialMediaIcon>();
        }
    }
}
