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
using UsersAppSandalov.Scripts;

namespace UsersAppSandalov.Okna
{
    /// <summary>
    /// Логика взаимодействия для Prodaji.xaml
    /// </summary>
    public partial class Prodaji : Window
    {
        ApplicationContext db = new ApplicationContext();
        public Prodaji()
        {
            InitializeComponent();
            List<Order> users = db.Orders.ToList();
            InfoSklad.ItemsSource = users;
            string Number = Pod.Text;
            string Status = Pod.Text;
            string PaymentStatus = Pod.Text;
            Order prod = new Order(Status, PaymentStatus, Number);
            db.Orders.Add(prod);
            db.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Number = Pod.Text;
            string Status = Pod.Text;
            string PaymentStatus = Pod.Text;
            Order prod = new Order(Status, PaymentStatus, Number);
            db.Orders.Add(prod);
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
