using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormsWorld
{
    class FileUtil
    {
        private static string path = @"test.txt";

        public static void clearLog()
        {
            File.Delete(path);
        }
        public static void log(List<Worm> worms)
        {
            var wormsStringList = new List<string>();
            foreach(Worm worm in worms)
            {
                wormsStringList.Add(worm.ToString());
            }
            if(!File.Exists(path))
            {
                File.WriteAllText(path, "Start\n");
            }
            var wormString = $"Worms: [{String.Join(", ", wormsStringList.ToArray())}]\n";
            File.AppendAllText(path, wormString);
        }
    }
}
