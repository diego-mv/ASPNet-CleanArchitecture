using AutoMapper;
using CleanArchitecture.Application.Features.Directors.Commands.CreateDirector;
using CleanArchitecture.Application.Features.Streamers.Commands.CreateStreamer;
using CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer;
using CleanArchitecture.Application.Features.Videos.Queries.GetVideosList;
using CleanArchitecture.Domain;


namespace CleanArchitecture.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Video
            CreateMap<Video, VideosVm>().ReverseMap();
            
            //Streamer
            CreateMap<Streamer, CreateStreamerCommand>().ReverseMap();
            CreateMap<Streamer, UpdateStreamerCommand>().ReverseMap();

            //Director
            CreateMap<Director, CreateDirectorCommand>().ReverseMap();
        }
    }
}
