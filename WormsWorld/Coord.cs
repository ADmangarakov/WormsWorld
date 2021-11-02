using System;

namespace WormsWorld
{
    class Coord
    {
        private readonly int _x;
        private readonly int _y;

        public Coord(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Coord(Coord coord)
        {
            _x = coord._x;
            _y = coord._y;
        }

        public static Coord operator +(Coord a, Coord b) => new(a._x + b._x, a._y + b._y);
        public static Coord operator -(Coord a, Coord b) => new(a._x - b._x, a._y - b._y);

        public override bool Equals(object obj)
        {
            return obj is Coord coord &&
                   _x == coord._x &&
                   _y == coord._y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y);
        }

        public override string ToString()
        {
            return $"({_x}, {_y})";
        }
    }
}