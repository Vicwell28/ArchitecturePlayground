using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePlayground.Domain
{
    public class Streamer
    {
        protected Streamer() { }

        public Streamer(string name, string channel)
        {
            Name = name;
            Channel = channel;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Channel { get; set; } = null!;
        public List<Video>? Videos { get; set; }
    }
}
