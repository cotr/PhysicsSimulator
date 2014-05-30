using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotr.Physics.Simulator.Classes
{
    class Speed : Vector
    {
        public Speed(double value, double angle)
            : base(value, angle)
        {

        }
        public static implicit operator Vector(Speed a)
        {
            return new Vector(a.Value, a.Angle);
        }
    }
}
