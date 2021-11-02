using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormsWorld
{
    class MoveAction : IAction
    {
        public static readonly MoveAction Right = new(1, 0);
        public static readonly MoveAction Left = new(-1, 0);
        public static readonly MoveAction Up = new(0, 1);
        public static readonly MoveAction Down = new(0, -1);

        private readonly Coord _move;

        public Coord move { get; }

        private MoveAction(int x, int y)
        {
            _move = new Coord(x, y);
        }

        public Coord GetAction()
        {
            return _move;
        }
    }
}
