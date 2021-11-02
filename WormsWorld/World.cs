using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormsWorld
{
    class World
    {
        private static readonly List<Worm> Worms = new();
        private static int _step;

        public static void Start()
        {
            var worm = new Worm("John", new Coord(0, 0));
            Worms.Add(worm);
            FileUtil.ClearLog();
            RunLife();
        }

        private static void RunLife()
        {
            while (_step < 20)
            {
                foreach (var worm in Worms)
                {
                    var action = worm.GetAction(_step);
                    if (ValidateAction(action))
                    {
                        worm.MakeAction(action);
                    }
                }

                FileUtil.Log(Worms);
                _step++;
            }
        }

        private static bool ValidateAction(IAction action)
        {
            return true;
        }
    }
}