using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp
{
    class Tower : ITower
    {
        private readonly MapLocation _location;

        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfullShot()
        {
            return Random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(IInvader[] invaders)
        {

            foreach (IInvader invader in invaders)
            {
                if (invader.IsActice && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfullShot())
                    {
                        invader.DecreaseHealth(Power);
                        Console.WriteLine("Shot at and hit an invader ");

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Invader is neutralized at" + invader.Location + "!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and MISS an invader ");
                    }
                    break;

                }
            }
        }


    }
}
