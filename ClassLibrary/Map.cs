using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotr.Physics.Simulator.Classes
{
    class Map
    {
        public List<Point> Points { get; set; }
        public void Tick()
        {
            foreach(Point p in Points)
            {
                Speed v0 = p.Speed;
                p.Speed = Vector.Sum(new List<Vector> { p.Speed, p.a });
                Speed v1 = p.Speed;
                p.X = p.X + (v0.Separate()[0].Value + v1.Separate()[0].Value) / 2;
                p.Y = p.Y + (v0.Separate()[1].Value + v1.Separate()[1].Value) / 2;
            }
        }
    }
}
