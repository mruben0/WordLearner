using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordLearner
{
    class PathManager
    {
        public string Path { get; set; }
     

        public bool checkPath(string path)
        {

            path = Path;
            string pathFormat = path.Substring(path.Length - 5, 5);
            if (pathFormat == "․xlsx")
            {
                return true;
            } else { return false; }
        }
       
    }
}
