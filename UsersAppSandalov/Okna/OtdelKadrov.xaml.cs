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
    /// Логика взаимодействия для OtdelKadrov.xaml
    /// </summary>
    public partial class OtdelKadrov : Window
    {
        ApplicationContext db = new ApplicationContext();
        public OtdelKadrov()
        {
            InitializeComponent();
            List<WorkerUser> users = db.WorkersUsers.ToList();
            InfoOK.ItemsSource = users;
            string Login = Pod.Text;
            string Pass = Pod.Text;
            string FullName = Pod.Text;
            string Obrazovanie = Pod.Text; 
            string Graph = Pod.Text;
            string Payment = Pod.Text;
            WorkerUser workerUser = new WorkerUser (Login, Pass, FullName, Obrazovanie, Graph, Payment);
            db.WorkersUsers.Add(workerUser);
            db.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Login = Pod.Text;
            string Pass = Pod.Text;
            string FullName = Pod.Text;
            string Obrazovanie = Pod.Text;
            string Graph = Pod.Text;
            string Payment = Pod.Text;
            WorkerUser workerUser = new WorkerUser(Login, Pass, FullName, Obrazovanie, Graph, Payment);
            db.WorkersUsers.Add(workerUser);
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
