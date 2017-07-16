using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLearner
{
    class GameManager
    {
        public string Ask { get; set; }
        public string Answ { get; set; }

        public GameManager(string ask, string answ)
        {
            Ask = ask;
            Answ = answ;
        }

        public bool WordChecker( string ask, string answ) {
            ask = Ask;
            answ = Answ;
            if (ask == answ) { return true; } else { return false; }
            
        }

    }
}
