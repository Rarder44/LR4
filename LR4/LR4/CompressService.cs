using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendCSharp;
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

        public CompressService()
        {
            this.Stringa = "";
        }
        public CompressService(String Stringa)
        {
            this.Stringa = Stringa;
        }
        public CompressedString Comprimi()
        {
            CompressedString cs = new CompressedString();
            char SpecialChar = FindSpecialChar();
            GestoreAssociazioni ga = Analizza(Stringa);
            /*
            TODO: 

            - controllo se una stringa non si ripete all'interno di un altra
            - cerco la soluzione migliore per poter ottimizzare la compressione

            */      



            return cs;
        }

        private List<Where> Occurrences(String Stringa, String DaCercare)
        {
            List<int> l=Stringa.AllIndexesOf(DaCercare);
            List<Where> lw = new List<Where>();
            foreach(int i in l)
                lw.Add(new Where(i, i + DaCercare.Length));

            return lw;
        }

        private GestoreAssociazioni Analizza(String s)
        {
            GestoreAssociazioni g = new GestoreAssociazioni();
            List<String> GiaEsaminate = new List<string>();
            for (int i = BaseLengthAssociazione; i < s.Length / 2; i++)
            {
                for (int j = 0; j < s.Length - i; j++)
                {
                    string Pattern = s.Substring(j, i);
                    if (GiaEsaminate.Find(x => x == Pattern)==null)
                    {
                        GiaEsaminate.Add(Pattern);
                        List<Where> l = Occurrences(s, Pattern);
                        if (l.Count > 1)
                        {
                            g.AddWithoutDuplicates(new Associazione("", Pattern, l));
                        }
                    }
                        
                }
            }
            return g;
        }

        private char FindSpecialChar()
        {
            Dictionary<char, int> d = GetAllKeys();

            for (int i = 0; i < _Stringa.Length; i++)
            {
                if (!d.ContainsKey(_Stringa[i]))
                    d.Add(_Stringa[i], 1);
                else
                    d[_Stringa[i]]++;
            }
            char? c = null;

            foreach(KeyValuePair<char,int> k in d)
            {
                if (k.Value == 0)
                    return k.Key;
                else if (c == null)
                    c = k.Key;
                else if (k.Value < d[c.Cast<char>()])
                    c = k.Key;
            }

            return 'a';
        }

        private Dictionary<char, int> GetAllKeys()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            for (int i = 1; i < 255; i++)
                d.Add((char)i,0);
            return d;
        }

    }
}
