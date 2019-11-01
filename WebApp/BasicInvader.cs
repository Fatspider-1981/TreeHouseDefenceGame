using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp
{
    class BasicInvader : InvaderBase
    {
        public BasicInvader(Path path) : base(path)
        {

        }
        public override int Health { get; protected set; } = 2;

    }
}
