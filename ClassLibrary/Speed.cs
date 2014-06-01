using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotr.Physics.Simulator.Classes
{
    public class Speed : Vector
    {
        public Speed(double value, double angle)
            : base(value, angle)
        {

        }
        public static explicit operator Accelerated_Speed(Speed v)
        {
            return new Accelerated_Speed(v.Value, v.Angle);
        }
    }
}
