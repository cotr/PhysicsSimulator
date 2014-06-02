using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotr.Physics.Simulator.Classes
{
    public class Point
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
                this.m_x = value;
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
                this.m_y = value;
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
            set
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
        public Point()
        {
            this.Forces = new List<Force>();
            this.Speed = new Speed(0, 0);
        }
    }
}
