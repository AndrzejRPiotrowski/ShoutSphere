using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoutSphere.Domain
{
    public class Sphere
    {
        public string SphereTitle { get; set; }
        public IList<Shout> Shouts { get; set; }
    }
}
