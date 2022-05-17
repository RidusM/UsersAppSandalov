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
using System.Data.Entity.Core.Objects;
using UsersAppSandalov.Okna;

namespace UsersAppSandalov
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        MainWindow mWind = new MainWindow();
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void AuthWindow_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void toSklad_Click(object sender, RoutedEventArgs e)
        {
            Sklad sklaD = new Sklad();
            sklaD.Show();
            Hide();
        }

        private void toProd_Click(object sender, RoutedEventArgs e)
        {
            Prodaji prod = new Prodaji();
            prod.Show();
            Hide();
        }

        private void toFactor_Click(object sender, RoutedEventArgs e)
        {
            Proizvodstvo proizvod = new Proizvodstvo();
            proizvod.Show();
            Hide();
        }

        private void toOK_Click(object sender, RoutedEventArgs e)
        {
            OtdelKadrov OK = new OtdelKadrov();
            OK.Show();
            Hide();
        }
    }
}
