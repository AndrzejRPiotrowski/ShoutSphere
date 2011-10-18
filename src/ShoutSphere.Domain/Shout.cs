using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoutSphere.Domain
{
    public class Shout
    {
        public Guid Id { get; set; }
        public DateTime CratedAt { get; set; }
        public string ShoutSentence { get; set; }
    }
}
