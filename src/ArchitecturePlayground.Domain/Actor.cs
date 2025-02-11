﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePlayground.Domain
{
    public class Actor
    {
        protected Actor() { }

        public Actor(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<VideoActor>? Videos { get; set; }
    }
}
