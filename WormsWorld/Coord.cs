using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormsWorld
{
    class Coord
    {
        private int x;
        private int y;      

        public Coord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Coord(Coord coord)
        {
            x = coord.x;
            y = coord.y;
        }

        public static Coord operator +(Coord a, Coord b) => new Coord(a.x + b.x, a.y + b.y);
        public static Coord operator -(Coord a, Coord b) => new Coord(a.x - b.x, a.y - b.y);

        public override bool Equals(object obj)
        {
            return obj is Coord coord &&
                   x == coord.x &&
                   y == coord.y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
