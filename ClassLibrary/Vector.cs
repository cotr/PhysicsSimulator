using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotr.Physics.Simulator.Classes
{
    class Vector
    {
        private double m_value { get; set; }
        private double m_angle { get; set; }
        /// <summary>
        /// 矢量的数值
        /// </summary>
        public double Value
        {
            get
            {
                return this.m_value;
            }
            set
            {
                if (value >= 0)
                {
                    this.m_value = value;
                }
                else
                {
                    this.m_value=-value;
                    if (this.Angle < 180)
                    {
                        this.Angle = this.Angle + 180;
                    }
                    else
                    {
                        this.Angle = this.Angle - 180;
                    }
                }
            }
        }
        /// <summary>
        /// 矢量的方向，按角度制表示
        /// </summary>
        public double Angle
        {
            get
            {
                return this.m_angle;
            }
            set
            {
                if (value >= 0 && value < 360)
                {
                    this.m_angle = value;
                }
                else
                {
                    throw new Exception("Angle out of range.");
                }
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="value">数值</param>
        /// <param name="angle">方向，按角度制表示</param>
        public Vector(double value, double angle)
        {
            this.Value = value;
            this.Angle = angle;
        }
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="v1">第一个矢量</param>
        /// <param name="v2">第二个矢量</param>
        /// <returns></returns>
        public static Vector operator +(Vector v1, Vector v2)
        {
            return Sum(new List<Vector> { v1, v2 });
        }
        /// <summary>
        /// 获取本对象在X,Y轴上的分量
        /// </summary>
        /// <returns>数组，0为在X轴分量，1为在Y轴分量</returns>
        public Vector[] Separate()
        {
            Vector[] vecR = new Vector[2];
            vecR[0] = new Vector(Math.Cos(this.Angle) * this.Value, 0);
            vecR[1] = new Vector(Math.Sin(this.Angle) * this.Value, 90);
            return vecR;
        }
        /// <summary>
        /// 获取本对象对于某角度的以正负表示方向的值
        /// </summary>
        /// <param name="angle">对应角度</param>
        /// <returns>double</returns>
        public double ToDouble(double angle)
        {
            if (this.Angle == angle)
            {
                return this.Value;
            }
            else if (this.Angle == angle + 180 || this.Angle == angle - 180)
            {
                return -this.Value;
            }
            else
            {
                throw new Exception("Invaid angle");
            }
        }
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="vs">所有矢量的列表</param>
        /// <returns>结果矢量</returns>
        public static Vector Sum(List<Vector> vs)
        {
            double vx = 0, vy = 0;
            for (int i = 0; i <= vs.Count - 1; i++)
            {
                Vector[] vtmp = vs[i].Separate();
                vx += vtmp[0].ToDouble(0);
                vy += vtmp[1].ToDouble(90);
            }
            return new Vector(Math.Sqrt(vx * vx + vy * vy), Math.Atan2(vx, vy));
        }
        public Speed GetSpeed()
        {
            return new Speed(this.Value, this.Angle);
        }
        public Force GetForce()
        {
            return new Force(this.Value, this.Angle);
        }
        public  Accelerated_Speed GetAcceleratedSpeed()
        {
            return new Accelerated_Speed(this.Value, this.Angle);
        }
    }
}
