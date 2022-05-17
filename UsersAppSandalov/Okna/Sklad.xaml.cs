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

namespace UsersAppSandalov
{
    /// <summary>
    /// Логика взаимодействия для Sklad.xaml
    /// </summary>
    public partial class Sklad : Window
    {
        ApplicationContext db = new ApplicationContext();
        public Sklad()
        {
            InitializeComponent();
            List<Slkad> slkads = db.Sklads.ToList();
            InfoSklad.ItemsSource = slkads;

            string Mesto = Pod.Text;
            string Pivo_ID = Pod.Text;



            Slkad slkad = new Slkad (Mesto, Pivo_ID);
            db.Sklads.Add(slkad);
            db.SaveChanges();
            db.Sklads.Remove(slkad);
        }

            private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Mesto = Pod.Text;
            string Pivo_ID = Pod.Text;



            Slkad slkad = new Slkad(Mesto, Pivo_ID);
            db.Sklads.Add(slkad);
            db.SaveChanges();
            if (Mesto == null)
            db.Sklads.Remove(slkad);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }
        
    }
}
