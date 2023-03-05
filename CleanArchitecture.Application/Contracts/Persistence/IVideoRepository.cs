using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface IVideoRepository : IAsyncRepository<Video>
    {
        Task<Video> GetByName(string name);
        Task<IEnumerable<Video>> GetByUsername(string username);
    }
}
