using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp
{
    class StrongTower : Tower
    {
        protected override int Power { get; } = 2;
        public StrongTower(MapLocation location) : base(location)
        { }
    }
}
