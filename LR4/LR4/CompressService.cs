using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class CompressService
    {
        String _Stringa;
        public String Stringa
        {
            get { return _Stringa; }
            set { _Stringa = value; }
        }
        int BaseLengthAssociazione = 4;

        GestoreAssociazioni ga;


        public CompressService(String Stringa)
        {
            this.Stringa = Stringa;
        }
        public CompressedString Comprimi()
        {
            CompressedString cs = new CompressedString();
            char SpecialChar = FindSpecialChar();

            return cs;
        }

        private List<Where> Occurrences(String Stringa, String DaCercare)
        {
            //Index Of Any
            Stringa.IndexOf()
            String NewStringa = Stringa.Replace(DaCercare, "");
            return (Stringa.Length - NewStringa.Length) / DaCercare.Length;
        }

        private GestoreAssociazioni Analizza(String s)
        {
            GestoreAssociazioni g = new GestoreAssociazioni();
            for (int i = BaseLengthAssociazione; i < s.Length / 2; i++)
            {
                for (int j = 0; j < s.Length - i; j++)
                {
                    string Pattern = s.Substring(j, i);
                    List<Where> l = Occurrences(s, Pattern);
                    if (l.Count > 1)
                    {
                        g.AddWithoutDuplicates(new Associazione("", Pattern,l));
                    }
                }
            }
            return g;
        }

        public char FindSpecialChar()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();

            for (int i = 0; i < _Stringa.Length; i++)
            {
                if (d[_Stringa[i]] == null)
                    d[_Stringa[i]] = 1;
                else
                    d[_Stringa[i]]++;

            }

            return 'a';
        }
    }
}
