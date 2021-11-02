using System;
using System.Collections.Generic;
using System.IO;

namespace WormsWorld
{
    class FileUtil
    {
        private static string path = @"test.txt";

        public static void ClearLog()
        {
            File.Delete(path);
        }

        public static void Log(List<Worm> worms)
        {
            var wormsStringList = new List<string>();
            foreach (var worm in worms)
            {
                wormsStringList.Add(worm.ToString());
            }

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Start\n");
            }

            var wormString = $"Worms: [{String.Join(", ", wormsStringList.ToArray())}]\n";
            File.AppendAllText(path, wormString);
        }
    }
}