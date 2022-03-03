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
        public static int Faktorial(int a)
        {
            int faktorial = 1;
            for (int i = 1; i <= a; ++i)
            {
                faktorial *= i;
            }
            return faktorial;
        }


        public static int CifSoucet(int a)
        {
            int Lichcifra = 0;

            while (a > 0)
            {
                int cifra = a % 10;
                
                if (cifra % 2 != 0)
                {
                    Lichcifra += cifra;

                }
                a = a / 10;

            }

            return Lichcifra;

        }
        public static bool JePrvocislo(int x)
        {
            bool jePrvocislo = x != 1;
            for (int delitel = 2; delitel <= Math.Sqrt(x) && jePrvocislo; ++delitel)
            {
                if (x % delitel == 0) jePrvocislo = false;
            }

            return jePrvocislo;
        }
        public  int PocetSudDelitelu(int x)
        {
            int pocetSudDelitelu = 0;
            for (int i = 1; i <= x; ++i)
            {
                if (x % i == 0)
                {
                    if (i % 2 == 0) ++pocetSudDelitelu;
                }
            }

            return pocetSudDelitelu;
        }


    }
}
