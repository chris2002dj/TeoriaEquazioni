using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(int x, bool Risultato)
        {
            if (x != 0) Risultato = true;

            return Risultato;
        }

        public static bool IsInconsisted(int x, bool Risultato)
        {
            if (x == 0) Risultato = true;
        
            return Risultato;
        }
    }
}
