namespace Playaorientacio2024Season01
{
    public class ElsoFeladat
    {
        // Az egész fálj tartalma soronként beolvasva
        double[] Sorok = File.ReadAllLines(Directory.GetCurrentDirectory() + "../../../../szamok.txt").ToList().Select(double.Parse).ToArray();
        double AKeresettSzam = 1310438493;

        public ElsoFeladat()
        {
            aFeladatMegoldasa();
            bFeladatMegoldasa();
            cFeladatMegoldasa();
        }

        void aFeladatMegoldasa()
        {
            // Ide tudod megcsinálni az első feladat A megoldását



            Console.WriteLine();
        }

        void bFeladatMegoldasa()
        {
            // Ide tudod megcsinálni az első feladat B megoldását



            Console.WriteLine();
        }

        void cFeladatMegoldasa()
        {
            // Ide tudod megcsinálni az első feladat C megoldását



            Console.WriteLine();
        }

        // Visszadja a szám prím osztóit
        // Nem kell vele különösebben foglalkozni (lopott kód)
        double[] primeFactors(double n)
        {
            List<double> primes = new List<double>();

            // Prdouble the number of 2s that divide n 
            while (n % 2 == 0)
            {
                primes.Add(2);
                n /= 2;
            }

            // n must be odd at this podouble. So we can skip 
            // one element (Note i = i + 2) 
            for (double i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, prdouble i and divide n 
                while (n % i == 0)
                {
                    primes.Add(i);
                    n /= i;
                }
            }

            // This condition is to handle the case when n 
            // is a prime number greater than 2 
            if (n > 2)
            {
                primes.Add(n);
            }

            return primes.ToArray().Distinct().ToArray();
        }
    }
}
