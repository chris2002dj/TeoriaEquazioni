using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double x, bool Risultato)
        {
            if (x != 0) Risultato = true;

            return Risultato;
        }

        public static bool IsInconsisted(double x, bool Risultato)
        {
            if (x == 0) Risultato = true;
        
            return Risultato;
        }

        public static bool IsDegree2(double x, double y, double c, bool Risultato)
        {
            if (x == 0 && y == 0 && c == 0) Risultato = true;

            return Risultato;
        }

        public static double Delta(double a, double b, double c, double Risultato)
        {
            Risultato = b * b - 4 * a * c;

            return Risultato;
        }


        public static string EquationDegree1(double a, double b, double x, string Risultato)
        {
            if (a == 0 && b == 0) Risultato = "Indeterminato";
            if (a != 0 && b != 0) Risultato = "Impossibile";
            if (a != 0 && b != 0 && x != 0) Risultato = "Detrminato";

            return Risultato;
        }
    }
}
