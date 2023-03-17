using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class VideoRepository : RepositoryBase<Video>, IVideoRepository
    {
        private readonly StreamerDbContext _context;
        public VideoRepository(StreamerDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Video> GetByName(string name)
        {
            return await _context.Videos!.FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<IEnumerable<Video>> GetByUsername(string username)
        {
            return await _context.Videos!.Where(x => x.CreatedBy == username).ToListAsync();
        }
    }
}
