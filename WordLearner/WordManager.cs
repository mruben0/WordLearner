using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLearner
{
    public class WordList
    {
        public int ID { get; set; }
        public string Gender { get; set; }
        public string Word { get; set; }
        public string Plural { get; set; }
        public string Translation { get; set; }
     //   public List<WordList> wordList { get; set; }

        public WordList(int id, string gender, string word, string plural, string translation)
        {
            ID = id;
            Gender = gender;
            Word = word;
            Plural = plural;
            Translation = translation;
        }
    }
}
