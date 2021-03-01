using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Cabare_Charlotte.Helper
{
    public static class PlayerHelper
    {
        public static List<string> GetDirectory()
        {
            var directories = Directory.GetDirectories(Constant.Constant.Directory).ToList();

            return directories;
        }

        public static List<string> GetSongs(List<string> directores)
        {
            List<string> files = new List<string>();

            foreach (var item in directores)
            {
                files.AddRange(Directory.GetFiles($"{Constant.Constant.Directory + @"\"}{item}", "*.mp3").ToList());
            }

            return files;
        }
    }
}
