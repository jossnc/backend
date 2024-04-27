using AutoMapper;
using BackendApi.Core.Dtos.Candidate;
using BackendApi.Core.Dtos.Company;
using BackendApi.Core.Dtos.Job;
using BackendApi.Core.Entities;

namespace BackendApi.Core.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {
            #region CompanyMap

            CreateMap<CompanyCreateDto, Company>();
            CreateMap<Company, CompanyGetDto>();


            #endregion

            #region JobMap

            CreateMap<JobCreateDto, Job>();
            CreateMap<Job, JobGetDto>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name));


            #endregion

            #region CandidateMap

            CreateMap<CandidateCreateDto, Candidate>();
            CreateMap<Candidate, CandidateGetDto>()
                .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.Job.Title));

            #endregion

            //
        }
    }
}
