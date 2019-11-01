using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp
{
    abstract class InvaderBase : IInvader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        protected virtual int StepSize { get; } = 1;
        public MapLocation Location
        { 
            get 
            {
                return _path.GetLocationAt(_pathStep);
            } 
        }

        public abstract int Health { get; protected set; }

        public bool HasScored => _pathStep >= _path.Length;

        //public bool HasScored {
        //    get 
        //    {
        //        return _pathStep >= _path.Length;
        //    } 

        //}
        public bool IsNeutralized => Health <= 0;
        public bool IsActice => !(IsNeutralized || HasScored);
        public InvaderBase(Path path)
        {
            _path = path;
        }

        public void Move()
        {
            _pathStep += StepSize;          
        }

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
    }
}
