using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace попытка_редактора___1
{
    [Serializable]
   public class Words
    {
        public Words() { }
        public List<Word> WordsList { get; set; } = new List<Word>();
    }
    

    [Serializable]
    public class Word
    {
        public string TheWord { get; set; }
        public string Translation { get; set; }
        public string Example { get; set; }

        public Word() { }

        public Word(string TheWord, string Translation, string Example)
        {
            this.TheWord = TheWord;
            this.Translation = Translation;
            this.Example = Example;
        }

    }
}
