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

namespace OAiP_14._06
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] login = new string[3] { "Admin", "Smena", "Prodavec" };
            string[] password = new string[3] { "Admin123", "Smena456", "Prodavec789" };

            if (box_log.Text.Equals(login[0]) & box_pass.Text.Equals(password[0]) | box_log.Text.Equals(login[1]) & box_pass.Text.Equals(password[1]) | box_log.Text.Equals(login[2]) & box_pass.Text.Equals(password[2]))
            {
                Window1 taskWindow = new Window1();

                taskWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Введен неправильно пароль или логин", "Ошибка ");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пароли для работников\n1.Администратор (Логин - Admin; Пароль - Admin123)\n2.Старший смены (Логин - Smena; Пароль - Smena456)\n3.Продавец (Логин - Prodavec; Пароль - Prodavec789)", "Справка");
        }
    }
}
