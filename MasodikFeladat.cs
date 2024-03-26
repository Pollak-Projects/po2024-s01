namespace Playaorientacio2024Season01
{
    public class MegyeAdat
    {
        // Példa (csak ezt kell átnevezni, illetve a típusát átállítani pl.: string, int, float, double, stb.)
        public int Rovidetese { get; set; }
    }

    public class TelepulesAdat
    {
        // Példa (csak ezt kell átnevezni, illetve a típusát átállítani pl.: string, int, float, double, stb.)
        public int IranyitoSzam { get; set; }
    }

    public class MasodikFeladat
    {
        // Érdemes őket átváltani classokra, hogy könnyebben kezelhetőek legyenek
        string[] TelepulesSorok = File.ReadAllLines(Directory.GetCurrentDirectory() + "../../../../telepules.txt");
        string[] MegyeSorok = File.ReadAllLines(Directory.GetCurrentDirectory() + "../../../../megyek.txt");

        public MasodikFeladat()
        {
            aFeladatMegoldasa();
            bFeladatMegoldasa();
            cFeladatMegoldasa();
            dFeladatMegoldasa();
            eFeladatMegoldasa();
            fFeladatMegoldasa();
        }

        void aFeladatMegoldasa()
        {
            // Ide tudod megcsinálni a második feladat A megoldását



            Console.WriteLine();
        }

        void bFeladatMegoldasa()
        {
            // Ide tudod megcsinálni a második feladat B megoldását



            Console.WriteLine();
        }

        void cFeladatMegoldasa()
        {
            // Ide tudod megcsinálni a második feladat C megoldását



            Console.WriteLine();
        }

        void dFeladatMegoldasa()
        {
            // Ide tudod megcsinálni a második feladat D megoldását



            Console.WriteLine();
        }

        void eFeladatMegoldasa()
        {
            // Ide tudod megcsinálni a második feladat E megoldását



            Console.WriteLine();
        }

        void fFeladatMegoldasa()
        {
            // Ide tudod megcsinálni a második feladat F megoldását



            Console.WriteLine();
        }
    }
}
