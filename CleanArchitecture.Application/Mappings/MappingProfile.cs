using AutoMapper;
using CleanArchitecture.Application.Features.Videos.Queries.GetVideosList;
using CleanArchitecture.Domain;


namespace CleanArchitecture.Application.Mappings
{
    public class MappingProfile : Profile
    {
        MappingProfile()
        {
            CreateMap<Video, VideosVm>();
        }
    }
}
