using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotr.Physics.Simulator.Classes
{
    class Point
    {
        private double m_x { get; set; }
        private double m_y { get; set; }
        private double m_m { get; set; }
        /// <summary>
        /// 横坐标
        /// </summary>
        public double X
        {
            get
            {
                return this.m_x;
            }
            set
            {
                if (value >= 0)
                {
                    this.m_x = value;
                }
                else
                {
                    throw new Exception("X out of range");
                }
            }
        }
        /// <summary>
        /// 纵坐标
        /// </summary>
        public double Y
        {
            get
            {
                return this.m_y;
            }
            set
            {
                if (value >= 0)
                {
                    this.m_y = value;
                }
                else
                {
                    throw new Exception("Y out of range");
                }
            }
        }
        /// <summary>
        /// 质量
        /// </summary>
        public double m
        {
            get
            {
                return this.m_m;
            }
            set
            {
                if (value >= 0)
                {
                    this.m_m = value;
                }
                else
                {
                    throw new Exception("m out of range.");
                }
            }
        }
        public List<Force> Forces { get; set; }
        private Speed m_speed { get; set; }
        public Speed Speed
        {
            get
            {
                return m_speed;
            }
            internal set
            {
                this.m_speed = value;
            }
        }
        public Accelerated_Speed a
        {
            get
            {
                return Force.Sum(Forces).GetAcceleratedSpeed(this.m);
            }
        }
    }
}
