using System.Collections.Generic;
using AutoMapper;
using Infrastructure.Data.Dtos;
using Infrastructure.Data.Models;

namespace Infrastructure.Data
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.FName, opt => opt.MapFrom(src => src.FName))
                .ForMember(dest => dest.LName, opt => opt.MapFrom(src => src.LName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));

            CreateMap<UserDto, User>()
                .ForMember(dest => dest.FName, opt => opt.MapFrom(src => src.FName))
                .ForMember(dest => dest.LName, opt => opt.MapFrom(src => src.LName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));

            CreateMap<Status, StatusDto>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
            
            CreateMap<StatusDto, Status>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<Problem, ProblemDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.StatusId, opt => opt.MapFrom(src => src.StatusId));

            CreateMap<ProblemDto, Problem>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.StatusId, opt => opt.MapFrom(src => src.StatusId));

            CreateMap<History, HistoryDto>()
                .ForMember(dest => dest.Action, opt => opt.MapFrom(src => src.Action))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.ProblemId, opt => opt.MapFrom(src => src.ProblemId));
            
            CreateMap<HistoryDto, History>()
                .ForMember(dest => dest.Action, opt => opt.MapFrom(src => src.Action))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.ProblemId, opt => opt.MapFrom(src => src.ProblemId));

        }
    }
}