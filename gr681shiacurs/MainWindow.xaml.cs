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

namespace gr681shiacurs
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

        private void autorizate_Click(object sender, RoutedEventArgs e)
        {
            AirportSHIAEntities aero = new AirportSHIAEntities();
            if (Login.Text == "" && Password.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else if (Login.Text == "")
            {
                MessageBox.Show("Введите логин");
            }
            else if (Password.Text == "")
            {
                MessageBox.Show("Введите пароль");
            }
            else
            {
                if (!aero.Usersystem.Select(i => i.UserLogin + " " + i.UserPassword).Contains(Login.Text + " " + Password.Text)){
                    MessageBox.Show("Пользователя не существует");
                }
                else
                {
                    usersys.id = aero.Usersystem.Where(x => x.UserLogin == Login.Text && x.UserPassword == Password.Text).Select(s => s.idUser).FirstOrDefault();
                    windowfolder.Window1 a = new windowfolder.Window1();
                    a.Show();
                    this.Close();
                } 
            }
        }
    }
}
