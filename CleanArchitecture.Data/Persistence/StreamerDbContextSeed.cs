using CleanArchitecture.Domain;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class StreamerDbContextSeed
    {
        public static async Task SeedAsync(StreamerDbContext context, ILogger<StreamerDbContextSeed> logger)
        {
            if (!context.Streamers!.Any())
            {
                context.Streamers!.AddRange(GetPreconfiguredStreamer());

                await context.SaveChangesAsync();

                logger.LogInformation("Insertando records iniciales al db {context}", typeof(StreamerDbContext).Name);
            }

        }

        private static IEnumerable<Streamer> GetPreconfiguredStreamer()
        {
            return new List<Streamer>()
            {
                new Streamer
                {
                    Name = "Star +",
                    Url = "https://www.starplus.com",
                    CreatedBy = "Diego M"
                },
                new Streamer
                {
                    Name = "Neverland",
                    Url = "https://www.estudiosneverland.com",
                    CreatedBy = "Diego M"
                }
            };
        }
    }
}
