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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Monopoly
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Single(object sender, RoutedEventArgs e)
        {
            Spiel subWindow = new Spiel(1);
            subWindow.Show();
            this.Close();
        }
        private void Multi(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int zahl = Convert.ToInt16(button.Content);
            Spiel subWindow = new Spiel(zahl);
            subWindow.Show();
            this.Close();
        }
    }
}
