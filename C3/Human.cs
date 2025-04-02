using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    abstract class Human : ITransportable
    {
        public abstract double VisitPort();
        public abstract double Volume { get; set; }
        public abstract double Weight { get; set; }
    }
}
