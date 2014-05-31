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
        public Vector SetVector()
        {
            return new Vector(this.Value, this.Angle);
        }
    }
}
