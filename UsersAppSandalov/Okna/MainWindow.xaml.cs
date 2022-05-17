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
using System.Data.Entity;

namespace UsersAppSandalov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        public void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string Login = textBoxLogin.Text.Trim();
            string Pass = passBox.Password.Trim();

            if (Login.Length < 3)
            {
                textBoxLogin.ToolTip = "Это поле введено не корректно";
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if (Pass.Length < 3)
            {
                passBox.ToolTip = "Это поле введено не корректно";
                passBox.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;

                WorkerUser authUser = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.WorkersUsers.Where(b => b.login == Login && b.pass == Pass).FirstOrDefault();
                }

                if (authUser != null)
                {
                    MessageBox.Show($"Добро пожаловать {Login}");
                    AuthWindow authWindow = new AuthWindow();
                    authWindow.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Вы ввели что-то некорректно");
            }

        }
    }
}
