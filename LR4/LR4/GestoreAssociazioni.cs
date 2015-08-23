using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class GestoreAssociazioni
    {
        public List<Associazione> l = new List<Associazione>();

        public void AddWithoutDuplicates(Associazione a)
        {
            if(l.Find(x => x.Value==a.Value) == null)
                l.Add(a);
        }


        
    }
}
