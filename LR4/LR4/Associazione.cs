using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class Associazione
    {

        String _Key;
        public String Key
        {
            get { return _Key; }
            set { _Key = value; }
        }
        String _Value;
        public String Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        public int Occorrenze
        {
            get { return _ListWhere.Count; }
        }
        List<Where> _ListWhere = new List<Where>();
        public List<Where> ListWhere
        {
            get { return _ListWhere; }
            set { _ListWhere = value; }
        }


        public Associazione(String Key,String Value, List<Where> ListWhere)
        {
            this.Value = Value;
            this.Key = Key;
            this.ListWhere = ListWhere;
        }
        public Associazione( String Value)
        {
            this.Value = Value;
            this.Key = "";
        }

    }

    class Where
    {
        int _From;
        public int From
        {
            get { return _From; }
            set { _From = value; }
        }
        int _To;
        public int To
        {
            get { return _To; }
            set { _To = value; }
        }
        public Where(int From,int To)
        {
            this.From = From;
            this.To = To;
        }

    }

}
