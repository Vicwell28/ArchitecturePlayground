using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePlayground.Domain
{
    public class VideoActor
    {
        public int VideoId { get; set; }
        public Video Video { get; set; } = null!;

        public int ActorId { get; set; }
        public Actor Actor { get; set; } = null!;
    }
}
