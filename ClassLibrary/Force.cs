﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotr.Physics.Simulator.Classes
{
    public class Force : Vector
    {
        public Accelerated_Speed GetAcceleratedSpeed(double m)
        {
            if (m != 0)
            {
                return new Accelerated_Speed(this.Value / m, this.Angle);
            }
            else
            {
                throw new Exception("m cannot be 0!");
            }
        }
        public Force(double value, double angle)
            : base(value, angle)
        {

        }
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="vs">所有矢量的列表</param>
        /// <returns>结果矢量</returns>
        public static Force Sum(List<Force> vs)
        {
            double vx = 0, vy = 0;
            for (int i = 0; i <= vs.Count - 1; i++)
            {
                Vector[] vtmp = vs[i].Separate();
                vx += vtmp[0].ToDouble(0);
                vy += vtmp[1].ToDouble(90);
            }
            return new Force(Math.Sqrt(vx * vx + vy * vy), Math.Atan2(vy, vx) / Math.PI * 180);
        }
    }
}
