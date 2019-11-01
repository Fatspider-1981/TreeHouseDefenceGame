using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp
{
    interface IMappable
    {
        MapLocation Location
        {
            get;
        }
    }

    interface IMovable
    {
        void Move();
    }

    interface IInvader : IMappable, IMovable
    {
       

        int Health
        {
            get;
        }

        bool HasScored
        {
            get;
        }

        //bool HasScored {
        //    get 
        //    {
        //        return _pathStep >= _path.Length;
        //    } 

        //}
        bool IsNeutralized
        {
            get;
        }
        bool IsActice
        {
            get;
        }


        void DecreaseHealth(int factor);
    }
}
