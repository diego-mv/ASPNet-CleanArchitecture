using MediatR;

namespace CleanArchitecture.Application.Features.Videos.Queries.GetVideosList
{
    public class GetVideosListQuery : IRequest<List<VideosVm>>
    {
        public string _Username { get; set; } = string.Empty;
        public GetVideosListQuery(string username)
        {
            username = _Username ?? throw new ArgumentNullException(nameof(username));
        }


    }
}
