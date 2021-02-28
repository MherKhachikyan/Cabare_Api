using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Cabare_Charlotte.Helper
{
    public static class PlayerHelper
    {
        public static string[] GetDirectory()
        {
            var directories = Directory.GetDirectories(Constant.Constant.Directory);

            return directories;
        }

        public static string[] GetSongs(string path)
        {
            var files = Directory.GetFiles(path, "*.mp3");

            return files;
        }
    }
}
