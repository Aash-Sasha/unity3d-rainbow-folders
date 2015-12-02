using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Borodar.RainbowFolders.Utils
{
    public static class RainbowUtils
    {
        public static bool IsNullOrEmpty(this ICollection collection)
        {
            return collection == null || (collection.Count == 0);
        }

        public static IEnumerable<string> GetSubdirectories(string path)
        {
            var directories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories).ToList();
            directories = directories.ConvertAll(d => d.Replace(@"\", @"/"));
            return directories;
        }
    }
}