using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Monopoly
{
    /// <summary>
    /// Interaktionslogik für Spiel.xaml
    /// </summary>
    public partial class Spiel : Window
    {
        Spielfeld Spielbrett = new Spielfeld();
        Spieler A = new Spieler(1);
        Spieler B = new Spieler(0);
        Spieler C = new Spieler(0);
        Spieler D = new Spieler(0);
        ImageBrush start = new ImageBrush();
        ImageBrush jailvisiting = new ImageBrush();
        ImageBrush freeparking = new ImageBrush();
        ImageBrush gotojail = new ImageBrush();
        ImageBrush station = new ImageBrush();
        ImageBrush ereignis = new ImageBrush();
        ImageBrush deadstreet = new ImageBrush();
        ImageBrush biohazard = new ImageBrush();
        ImageBrush cthulhu = new ImageBrush();
        ImageBrush caduceus = new ImageBrush();
        ImageBrush eye = new ImageBrush();
        ImageBrush flare = new ImageBrush();
        int zahl;
        Random wuerfel = new Random();
        public Spiel(int zahl)
        {
            InitializeComponent();
            playertest(zahl);
            spielfelderzeugen();
            coinaktuell();
        }
        public void playertest(int zahl)
        {
            if (2 <= zahl)
            {
                B = new Spieler(1);
                Spieler2.Content = "Spieler 2";
            }
            if (3 <= zahl)
            {
                C = new Spieler(1);
                Spieler3.Content = "Spieler 3";
            }
            if (4 <= zahl)
            {
                D = new Spieler(1);
                Spieler4.Content = "Spieler 3";
            }
        }
        public void coinaktuell()
        {
            Coin1.Content = A.getcoin();
            Coin2.Content = B.getcoin();
            Coin3.Content = C.getcoin();
            Coin4.Content = D.getcoin();
        }
        public void spielfelderzeugen()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i > 0)
                {
                    Rectangle spielfeld = new Rectangle();
                    spielfeld.Width = 100;
                    spielfeld.Height = 125;
                    spielfeld.Stroke = new SolidColorBrush(Colors.Black);
                    spielfeld.Margin = new Thickness(1000 - i * 200, 594, 0, 0);
                    MyGrid.Children.Add(spielfeld);
                    Spielbrett.feld.Add(spielfeld);
                    if (i == 5)
                    {
                        station.ImageSource = new BitmapImage(new Uri(@"../../img/station.jpg", UriKind.Relative));
                        spielfeld.Fill = station;
                    }
                    if (i == 3 || i == 7)
                    {
                        ereignis.ImageSource = new BitmapImage(new Uri(@"../../img/ereignis.png", UriKind.Relative));
                        spielfeld.Fill = ereignis;
                    }
                    else if(i > 0 && i < 5)
                    {
                        deadstreet.ImageSource = new BitmapImage(new Uri(@"../../img/deadstreet.png", UriKind.Relative));
                        spielfeld.Fill = deadstreet;
                    }
                    else if (i > 5)
                    {
                        biohazard.ImageSource = new BitmapImage(new Uri(@"../../img/biohazard.png", UriKind.Relative));
                        spielfeld.Fill = biohazard;
                    }
                }
                else
                {
                    Rectangle spielfeld = new Rectangle();
                    spielfeld.Width = 130;
                    spielfeld.Height = 125;
                    spielfeld.Stroke = new SolidColorBrush(Colors.Black);
                    spielfeld.Margin = new Thickness(1030, 594, 0, 0);
                    MyGrid.Children.Add(spielfeld);
                    start.ImageSource = new BitmapImage(new Uri(@"../../img/start.png", UriKind.Relative));
                    spielfeld.Fill = start;
                    Spielbrett.feld.Add(spielfeld);
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (i > 0)
                {
                    Rectangle spielfeld = new Rectangle();
                    spielfeld.Width = 130;
                    spielfeld.Height = 90;
                    spielfeld.Stroke = new SolidColorBrush(Colors.Black);
                    spielfeld.Margin = new Thickness(-1029, 560 - 180 * i, 0, 0);
                    MyGrid.Children.Add(spielfeld);
                    Spielbrett.feld.Add(spielfeld);
                    if (i == 3)
                    {
                        spielfeld.Fill = station;
                    }
                    else if (i == 4)
                    {
                        spielfeld.Fill = ereignis;
                    }
                    else
                    {
                        cthulhu.ImageSource = new BitmapImage(new Uri(@"../../img/cthulhu.png", UriKind.Relative));
                        spielfeld.Fill = cthulhu;
                    }
                }
                else
                {
                    Rectangle spielfeld = new Rectangle();
                    spielfeld.Width = 130;
                    spielfeld.Height = 125;
                    spielfeld.Stroke = new SolidColorBrush(Colors.Black);
                    spielfeld.Margin = new Thickness(-1029, 594, 0, 0);
                    MyGrid.Children.Add(spielfeld);
                    Spielbrett.feld.Add(spielfeld);
                    jailvisiting.ImageSource = new BitmapImage(new Uri(@"../../img/jailvisiting.jpg", UriKind.Relative));
                    spielfeld.Fill = jailvisiting;
                } 
            }
            for (int i = 0; i < 10; i++)
            {
                if (i > 0)
                {
                    Rectangle spielfeld = new Rectangle();
                    spielfeld.Width = 100;
                    spielfeld.Height = 125;
                    spielfeld.Stroke = new SolidColorBrush(Colors.Black);
                    spielfeld.Margin = new Thickness(-1000 + i * 200, -555, 0, 0);
                    MyGrid.Children.Add(spielfeld);
                    Spielbrett.feld.Add(spielfeld);
                    if (i == 5)
                    {
                        station.ImageSource = new BitmapImage(new Uri(@"../../img/station.jpg", UriKind.Relative));
                        spielfeld.Fill = station;
                    }
                    if (i == 2 || i == 8)
                    {
                        ereignis.ImageSource = new BitmapImage(new Uri(@"../../img/ereignis.png", UriKind.Relative));
                        spielfeld.Fill = ereignis;
                    }
                    else if (i > 0 && i < 5)
                    {
                        caduceus.ImageSource = new BitmapImage(new Uri(@"../../img/caduceus.png", UriKind.Relative));
                        spielfeld.Fill = caduceus;
                    }
                    else if (i > 5)
                    {
                        flare.ImageSource = new BitmapImage(new Uri(@"../../img/flare.png", UriKind.Relative));
                        spielfeld.Fill = flare;
                    }
                }
                else
                {
                    Rectangle spielfeld = new Rectangle();
                    spielfeld.Width = 130;
                    spielfeld.Height = 125;
                    spielfeld.Stroke = new SolidColorBrush(Colors.Black);
                    spielfeld.Margin = new Thickness(-1029, -555, 0, 0);
                    MyGrid.Children.Add(spielfeld);
                    Spielbrett.feld.Add(spielfeld);
                    freeparking.ImageSource = new BitmapImage(new Uri(@"../../img/freeparking.jpg", UriKind.Relative));
                    spielfeld.Fill = freeparking;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (i > 0)
                {
                    Rectangle spielfeld = new Rectangle();
                    spielfeld.Width = 130;
                    spielfeld.Height = 90;
                    spielfeld.Stroke = new SolidColorBrush(Colors.Black);
                    spielfeld.Margin = new Thickness(1030, -520 + 180 * i, 0, 0);
                    MyGrid.Children.Add(spielfeld);
                    Spielbrett.feld.Add(spielfeld);
                    if (i == 3)
                    {
                        spielfeld.Fill = station;
                    }
                    else if (i == 4)
                    {
                        spielfeld.Fill = ereignis;
                    }
                    else
                    {
                        eye.ImageSource = new BitmapImage(new Uri(@"../../img/eye.png", UriKind.Relative));
                        spielfeld.Fill = eye;
                    }
                }
                else
                {
                    Rectangle spielfeld = new Rectangle();
                    spielfeld.Width = 130;
                    spielfeld.Height = 125;
                    spielfeld.Stroke = new SolidColorBrush(Colors.Black);
                    spielfeld.Margin = new Thickness(1030, -555, 0, 0);
                    MyGrid.Children.Add(spielfeld);
                    Spielbrett.feld.Add(spielfeld);
                    gotojail.ImageSource = new BitmapImage(new Uri(@"../../img/gotojail.jpg", UriKind.Relative));
                    spielfeld.Fill = gotojail;
                }
            }
        }

        private void Spieler1btnw_Click(object sender, RoutedEventArgs e)
        {
            zahl = A.pedometer(wuerfel.Next(1, 7));
            for (int i = 0; i < Spielbrett.feld.Count; i++)
            {
                if (zahl == i)
                {
                    Player1.Margin = Spielbrett.feld[i].Margin;
                }
            }
            Spieler1btnw.Visibility = Visibility.Hidden;
            Spieler1btnende.Visibility = Visibility.Visible;
        }
        private void Spieler2btnw_Click(object sender, RoutedEventArgs e)
        {
            zahl = B.pedometer(wuerfel.Next(1, 7));
            for (int i = 0; i < Spielbrett.feld.Count; i++)
            {
                if (zahl == i)
                {
                    Player2.Margin = Spielbrett.feld[i].Margin;
                }
            }
            Spieler2btnw.Visibility = Visibility.Hidden;
            Spieler2btnende.Visibility = Visibility.Visible;
        }
        private void Spieler3btnw_Click(object sender, RoutedEventArgs e)
        {
            zahl = C.pedometer(wuerfel.Next(1, 7));
            for (int i = 0; i < Spielbrett.feld.Count; i++)
            {
                if (zahl == i)
                {
                    Player3.Margin = Spielbrett.feld[i].Margin;
                }
            }
            Spieler3btnw.Visibility = Visibility.Hidden;
            Spieler3btnende.Visibility = Visibility.Visible;
        }
        private void Spieler4btnw_Click(object sender, RoutedEventArgs e)
        {
            zahl = D.pedometer(wuerfel.Next(1, 7));
            for (int i = 0; i < Spielbrett.feld.Count; i++)
            {
                if (zahl == i)
                {
                    Player4.Margin = Spielbrett.feld[i].Margin;
                }
            }
            Spieler4btnw.Visibility = Visibility.Hidden;
            Spieler4btnende.Visibility = Visibility.Visible;
            D.coinsub();
        }
        private void ende_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if(button.Name == "Spieler1btnende")
            {
                Spieler2btnw.Visibility = Visibility.Visible;
                Spieler1btnende.Visibility = Visibility.Hidden;
            }
            if (button.Name == "Spieler2btnende")
            {
                Spieler3btnw.Visibility = Visibility.Visible;
                Spieler2btnende.Visibility = Visibility.Hidden;
            }
            if (button.Name == "Spieler3btnende")
            {
                Spieler4btnw.Visibility = Visibility.Visible;
                Spieler3btnende.Visibility = Visibility.Hidden;
            }
            if (button.Name == "Spieler4btnende")
            {
                Spieler1btnw.Visibility = Visibility.Visible;
                Spieler4btnende.Visibility = Visibility.Hidden;
            }
        }
    }
}
