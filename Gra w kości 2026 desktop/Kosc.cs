using System;

namespace Gra_w_kości_2026_desktop
{
    class Kosc
    {
        public static int liczbaInstancji = 0;

        public string[] nazwyPlikow = { "kosc0.png", "kosc1.png", "kosc2.png",
                                        "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png" };

        public int liczbaOczek;
        public int idPliku;
        public bool dostepna;

        static Random losowy = new Random();
        public Kosc(int wartosc)
        {
            if (wartosc < 1 || wartosc > 6)
                wartosc = 0;

            liczbaOczek = wartosc;
            idPliku = wartosc;
            dostepna = true;
            liczbaInstancji++;
        }
        public Kosc()
        {
            int wartosc = losowy.Next(1, 7);

            liczbaOczek = wartosc;
            idPliku = wartosc;
            dostepna = true;
            liczbaInstancji++;
        }
        public void Rzut()
        {
            if (dostepna)
            {
                int wartosc = losowy.Next(1, 7);
                liczbaOczek = wartosc;
                idPliku = wartosc;
            }
        }
        public void Zablokuj()
        {
            dostepna = false;
        }
    }
}