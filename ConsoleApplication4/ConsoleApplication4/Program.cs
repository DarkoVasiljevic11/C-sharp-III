using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int unosBroja()
        {
            Console.WriteLine("Molimo unesite ceo broj picko");
            int broj = Convert.ToInt32(Console.ReadLine());
            return broj;
        }
        public static double[] unosNiza(int N)
        {
            double[] niz = new double[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Unesite odgovarajuci clan niza");
                niz[i] = Convert.ToDouble(Console.ReadLine());
            }
            return niz;
        }
        public static double najveciPrilog(double[]niz)
        {
            double max=niz[0];
            for( int i=0; i<niz.Length; i++)
            
                if (niz[i]>max)
                    max=niz[i];
            }
            return max;
        }
        public static void poziv()
        {
            int N=unosBroja();
            Console.WriteLine("Sledi unos" + N + " iznosa dobrovoljnih novcanih priloga");
            double[]niz = unosNiza(N);
            double max1 = najveciPrilog(niz);
            Console.WriteLine("Ponavlja se ceo postupak");
            Console.WriteLine("Sledi unos" + N + " iznosa dobrovoljnih novcanih priloga");
            double[]niz1 = unosNiza(N);
            double max2 = najveciPrilog(niz1);
            Console.WriteLine("Najveci prilog prvog niza je" + max1 + " dinara.");
            Console.WriteLine("Njaveci prilog drugog niza je" + max2 + " dinara.");
            if (max1 > max2)
                Console.WriteLine("Maksimalni novcani prilog u prvom nizu je veci od maksimalnog novcanog priloga u drugom nizu.");
            else if (max2 > max1)
                Console.WriteLine("Maksimalni novcani prilog u drugom nizu je veci opd maksimalnog novcanog priloga u prvom nizu.");
            else
                Console.WriteLine("Maksimalni novcani prilozi i prvom i drugom nizu su jednaki.");




        }
        static void Main(string[] args)
        {
            poziv();
        }
    }
}
