using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePlayground.Domain
{
    public class VideoActor
    {
        protected VideoActor() { }

        public VideoActor(int videoId, int actorId)
        {
            VideoId = videoId;
            ActorId = actorId;
        }

        public int VideoId { get; set; }
        public Video Video { get; set; } = null!;

        public int ActorId { get; set; }
        public Actor Actor { get; set; } = null!;
    }
}
