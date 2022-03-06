using AutoMapper;
using TopTenPresidents.Data.Entities;
using TopTenPresidents.Shared.TransferDtos;

namespace TopTenPresidents.Profiles;

public class NameProfile : Profile
{
     public NameProfile()
     {
          CreateMap<Task<List<Name>>, Task<List<PresidentTransferDto>>>();
          CreateMap<Name, PresidentTransferDto>()
                .ForMember
                (
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => src.FirstName)
                )
                .ForMember
                (
                    dest => dest.MiddleName,
                    opt => opt.MapFrom(src => src.MiddleName)
                )
                .ForMember
                (
                    dest => dest.LastName,
                    opt => opt.MapFrom(src => src.LastName)
                )
               .ForMember
               (
                   dest => dest.DateOfBirth,
                   opt => opt.MapFrom(src => src.DateOfBirth.ToDateTime(TimeOnly.MinValue))
               )
               .ForMember
               (
                   dest => dest.DateOfDeath,
                   opt => opt.MapFrom(src => GetDateTimeByDateOnly(src.DateOfDeath))
               );
     }

     private static DateTime? GetDateTimeByDateOnly(DateOnly? date) => date?.ToDateTime(TimeOnly.MinValue);
}
