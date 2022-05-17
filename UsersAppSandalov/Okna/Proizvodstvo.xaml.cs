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

namespace UsersAppSandalov.Okna
{
    /// <summary>
    /// Логика взаимодействия для Proizvodstvo.xaml
    /// </summary>
    public partial class Proizvodstvo : Window
    {
        ApplicationContext db = new ApplicationContext();
        public Proizvodstvo()
        {
            InitializeComponent();
            List<Beer> users = db.Beers.ToList();
            InfoSklad.ItemsSource = users;
            string Name = Pod.Text;
            string Price = Pod.Text;
            string Color_ID = Pod.Text;
            string Filter_ID = Pod.Text;
            Beer bera = new Beer(Name, Price, Color_ID, Filter_ID);
            db.Beers.Add(bera);
            db.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Name = Pod.Text;
            string Price = Pod.Text;
            string Color_ID = Pod.Text;
            string Filter_ID = Pod.Text;
            Beer bera = new Beer(Name, Price, Color_ID, Filter_ID);
            db.Beers.Add(bera);
            db.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }
    }
}
