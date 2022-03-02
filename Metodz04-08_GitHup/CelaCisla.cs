using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodz04_08_GitHup
{
    class CelaCisla
    {
        public static double Mocnina(int a, int exp)
        {
            int mocnina = 1;
            double vysledek = 0;
            if (exp < 0)
            {
                for (int i = 0; i < -exp; ++i)
                {
                    mocnina *= a;
                }
                vysledek = 1 / (double)mocnina;
                return vysledek;
            }
            else
            {
                for (int i = 0; i < exp; ++i)
                {
                    mocnina *= a;
                }
                return mocnina;
            }
        }

    }
}
