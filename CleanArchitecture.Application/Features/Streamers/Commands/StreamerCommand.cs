using MediatR;

namespace CleanArchitecture.Application.Features.Streamers.Commands
{
    public class StreamerCommand : IRequest<int>
    {
        public string _Name { get; set; } = string.Empty;   
        public string _Url { get; set; } = string.Empty;

        public StreamerCommand(string name, string url)
        {
            _Name = name;
            _Url = url;
        }
    }
}