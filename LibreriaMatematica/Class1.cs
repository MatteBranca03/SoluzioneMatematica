using System;

namespace LibreriaMatematica
{
    public class Operazioni
    {
        public static int Somma(int n1, int n2)
        {
            int s = n1 + n2;
            return s;
        }
        public static int Differenza(int n1, int n2)
        {
            int d = n1 - n2;
            return d;
        }
        public static int Prodotto(int n1, int n2)
        {
            int p = n1 * n2;
            return p;
        }
        public static double Divisione(int n1, int n2)
        {
            if (n2 == 0)
            {
                throw new Exception("n2 = 0");
            }
            double q = n1 / n2;
            return q;
        }
        public static double Massimo(int n1, int n2)
        {
            if (n1 > n2)
            {
                double max = n1;
                return max;
            }
            else
            {
                double max = n2;
                return max;
            }
        }
        public static double Minimo(int n1, int n2)
        {
            if (n1 < n2)
            {
                double min = n1;
                return min;
            }
            else
            {
                double min = n2;
                return min;
            }
        }
        public static double Potenza(int n1, int n2)
        {
            int c = 0;
            int p = 1;
            while (n2 < c)
            {
                p = p * n1;
                c = c + 1;
            }
            return p;
        }
    }
}
