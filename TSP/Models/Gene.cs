using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.Models
{
    public class Gene
    {
        public int X { get; }
        public int Y { get; }
        public string Name { get; }
        public int Position { get; }

        public Gene(int x, int y, string name, int position)
        {
            X = x;
            Y = y;
            Name = name;
            Position = position;
        }

        public static int CalculateDistance(Gene a, Gene b)
        {
            int dx = a.X - b.X;
            int dy = a.Y - b.Y;
            return (int)Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
