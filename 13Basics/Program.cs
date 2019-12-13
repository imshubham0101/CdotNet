using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellCheckerFactory scf = new SpellCheckerFactory();
            Console.WriteLine("eng | hindi");
            string lang = Console.ReadLine();
            ISpellChecker someChecker = scf.GetSpellChecker(lang);

            //Editor editor = new Editor(null);
            //Editor editor = new Editor(someChecker);
            Editor editor = new Editor(new AfrikanChecker());
            editor.Check("abc");
            Console.ReadLine();
        }
    }

    public interface ISpellChecker
    {
        void SpellCheck(string word);
    }

    public class EnglishSpellChecker:ISpellChecker
    {
        public void SpellCheck(string word)
        {
              Console.WriteLine("English Spell Check Done!");
        }
     
    }

    public class HindiSpellChecker:ISpellChecker
    {
        public void SpellCheck(string word)
        {
            Console.WriteLine("Hindi Spell Check Done!");
        }
    }

    public class AfrikanChecker : ISpellChecker
    {
        public void SpellCheck(string word)
        {
            Console.WriteLine("AF spell check done!");
        }
    }
    public class SpellCheckerFactory
    {
        public ISpellChecker GetSpellChecker(string lang)
        {
            if (lang == "hindi")
            {
                return new HindiSpellChecker();
            }
            else 
            {
                return new EnglishSpellChecker();
            }
        }
    }


    public class Editor
    {
        private ISpellChecker checker;

        public Editor(ISpellChecker _checker)
        {
            if (_checker == null)
            {
                checker = new EnglishSpellChecker();
            }
            else
            {
                this.checker = _checker;
            }
        }
        public void Cut()
        {
            Console.WriteLine("Cut done");
        }

        public void Copy()
        {
            Console.WriteLine("Copy done");
        }

        public void Paste()
        {
            Console.WriteLine("Paste done");
        }

        public void Check(string word)
        {
            checker.SpellCheck(word);
        }
       
    }
}
