using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePlayground.Domain
{
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Video>? Videos { get; set; }
    }
}
