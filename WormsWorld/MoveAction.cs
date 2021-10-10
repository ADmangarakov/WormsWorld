using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormsWorld
{
    class MoveAction : Action
    {
        public static readonly MoveAction RIGHT = new(1, 0);
        public static readonly MoveAction LEFT = new(-1, 0);
        public static readonly MoveAction UP = new(0, 1);
        public static readonly MoveAction DOWN = new(0, -1);

        private readonly Coord _move;

        public Coord move { get; }

        private MoveAction(int x, int y)
        {
            _move = new Coord(x, y);
        }

        public Coord getAction()
        {
            return _move;
        }
    }
}
