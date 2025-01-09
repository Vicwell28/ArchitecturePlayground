using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePlayground.Domain
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Url { get; set; } = null!;

        public int? StreamerId { get; set; }
        public Streamer? Streamer { get; set; }

        public List<VideoActor>? Actors { get; set; }

        public int? DirectorId { get; set; }
        public Director? Director { get; set; }
    }
}
