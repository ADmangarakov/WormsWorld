using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormsWorld
{
    class World
    {
        private static readonly List<Worm> worms = new();
        private static int step = 0;
        public static void start()
        {
            var worm = new Worm("John", new Coord(0, 0));
            worms.Add(worm);
            FileUtil.clearLog();
            runLife();
        }

        private static void runLife()
        {
            while (step < 20)
            {
                foreach (Worm worm in worms)
                {
                    Action action = worm.getAction(step);
                    if(validateAction(action))
                    {
                        worm.makeAction(action);
                    }
                }
                FileUtil.log(worms);
                step++;
            }
        }

        private static bool validateAction(Action action)
        {
            return true;
        }

    }
}
