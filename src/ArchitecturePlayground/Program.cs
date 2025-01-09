using ArchitecturePlayground;
using ArchitecturePlayground.Data;
using ArchitecturePlayground.Domain;

ArchitecturePlaygroundDbContext dbContext = new();

QueryStreamers();
QueryVideos();
QueryFilteredStreamers("Streamer 1");
QueryFilteredVideos("Video 1");

void QueryVideos()
{
    var videos = dbContext.Videos.ToList();
    foreach (var video in videos)
    {
        ConsoleHelper.WriteJson(video, false, false, false, true);
    }
}

void QueryStreamers()
{
    var streamers = dbContext.Streamers.ToList();
    foreach (var streamer in streamers)
    {
        ConsoleHelper.WriteJson(streamer, false, false, false, true);
    }
}

void QueryFilteredVideos(string title)
{
    var videos = dbContext.Videos.Where(v => v.Title == title).ToList();
    foreach (var video in videos)
    {
        ConsoleHelper.WriteJson(video, false, false, false, true);
    }
}

void QueryFilteredStreamers(string name)
{
    var streamers = dbContext.Streamers.Where(s => s.Name == name).ToList();
    foreach (var streamer in streamers)
    {
        ConsoleHelper.WriteJson(streamer, false, false, false, true);
    }
}

void QueryWithLinq()
{
    var videos = from v in dbContext.Videos
                 join s in dbContext.Streamers on v.StreamerId equals s.Id
                 select new
                 {
                     v.Title,
                     v.Description,
                     v.Url,
                     Streamer = s.Name
                 };

    foreach (var video in videos)
    {
        ConsoleHelper.WriteJson(video, false, false, false, true);
    }
}