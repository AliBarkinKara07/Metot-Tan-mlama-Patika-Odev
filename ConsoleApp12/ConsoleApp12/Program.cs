using System;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));


            Console.WriteLine(a+b);
            int sonuc2 = ornek.ArttırVeTopla(a, b);

        }
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);

        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(int deger1, int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
