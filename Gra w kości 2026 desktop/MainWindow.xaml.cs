using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Gra_w_kości_2026_desktop
{
    public partial class MainWindow : Window
    {
        Kosc[] kosci = new Kosc[5];
        Image[] obrazy;

        public MainWindow()
        {
            InitializeComponent();

            obrazy = new Image[] { obraz0, obraz1, obraz2, obraz3, obraz4 };
            for (int i = 0; i < 5; i++)
            {
                kosci[i] = new Kosc(0);
                PokazObraz(i);
            }
        }
        private void Rzut_Click(object sender, RoutedEventArgs e)
        {
            int suma = 0;

            for (int i = 0; i < 5; i++)
            {
                kosci[i].Rzut();
                PokazObraz(i);
                suma = suma + kosci[i].liczbaOczek;
            }

            wynik.Text = suma.ToString();
        }
        private void Kosc_Click(object sender, MouseButtonEventArgs e)
        {
            Image obraz = (Image)sender;
            int i = int.Parse(obraz.Tag.ToString());

            if (kosci[i].dostepna)
            {
                kosci[i].Zablokuj();
                obraz.Opacity = 0.5;
            }
            else
            {
                kosci[i].dostepna = true;
                obraz.Opacity = 1;
            }
        }
        private void PokazObraz(int i)
        {
            string plik = kosci[i].nazwyPlikow[kosci[i].idPliku];
            obrazy[i].Source = new BitmapImage(new Uri("Images/" + plik, UriKind.Relative));
        }
    }
}