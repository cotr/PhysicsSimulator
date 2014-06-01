using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotr.Physics.Simulator.Classes
{
    class Accelerated_Speed : Vector
    {
        public Accelerated_Speed(double value, double angle)
            : base(value, angle)
        {

        }
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="vs">所有矢量的列表</param>
        /// <returns>结果矢量</returns>
        public static Accelerated_Speed Sum(List<Accelerated_Speed> vs)
        {
            double vx = 0, vy = 0;
            for (int i = 0; i <= vs.Count - 1; i++)
            {
                Vector[] vtmp = vs[i].Separate();
                vx += vtmp[0].ToDouble(0);
                vy += vtmp[1].ToDouble(90);
            }
            return new Accelerated_Speed(Math.Sqrt(vx * vx + vy * vy), Math.Atan2(vx, vy));
        }
        public static explicit operator Speed(Accelerated_Speed a)
        {
            return new Speed(a.Value, a.Angle);
        }
    }
}
