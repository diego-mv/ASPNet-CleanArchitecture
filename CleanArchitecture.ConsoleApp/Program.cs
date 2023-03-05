using CleanArchitecture.Data;
using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;
using System.Windows.Markup;

StreamerDbContext dbContext = new StreamerDbContext();


await MultipleEntitiesQuery();



///////////////////////////////////////////////////////////

async Task AddStreamerWithVideo()
{
    var pantalla = new Streamer()
    {
        Name = "Pantalla"
    };

    var hungerGames = new Video
    {
        Name = "Hunger Games",
        Streamer = pantalla,
    };

    await dbContext.AddAsync(hungerGames);
    await dbContext.SaveChangesAsync();


}

async Task ActorWithVideo()
{
    var actor = new Actor
    {
        Name = "Brad",
        Surname = "Pitt"
    };
    await dbContext.AddAsync<Actor>(actor);
    await dbContext.SaveChangesAsync();

    var VideoActor = new VideoActor
    {
        ActorId = actor.Id,
        VideoId = 1
    };

    await dbContext.AddAsync<VideoActor>(VideoActor);
    await dbContext.SaveChangesAsync();
}

async Task AddNewDirectorWithVideo()
{
    var director = new Director { 
        Name = "Lorenzo",
        Surname = "Basteri",
        VideoId = 1
    };

    await dbContext.AddAsync(director);
    await dbContext.SaveChangesAsync();
}

async Task MultipleEntitiesQuery()
{
    var videoWithActors = await dbContext.Videos!.Include(x => x.Actors).FirstOrDefaultAsync(q => q.Id == 1);

    var actor = await dbContext.Actors!.Select(q => q.Name).ToListAsync();
}