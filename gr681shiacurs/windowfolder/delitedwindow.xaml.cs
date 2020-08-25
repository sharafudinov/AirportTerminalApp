using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace gr681shiacurs.windowfolder
{
    /// <summary>
    /// Логика взаимодействия для delitedwindow.xaml
    /// </summary>
    public partial class delitedwindow : Window
    {
        public delitedwindow()
        {
            InitializeComponent();
        }

        private void registationof_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void registationup_Click(object sender, RoutedEventArgs e)
        {
            AirportSHIAEntities aor = new AirportSHIAEntities();
            var test = aor.Client.Where(x => x.FirstName == familiyaе.Text && x.LastName == Otchestvoе.Text && x.MiddleName == nameе.Text).Select(u => u.idClient).FirstOrDefault();
            if (test != -1 && test != 0)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show("Удалить пользователя?", "Подтверждение", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    var dlee = aor.Client.Where(w => w.idClient == test).FirstOrDefault();
                    aor.Client.Remove(dlee);
                    aor.SaveChanges();
                    System.Windows.MessageBox.Show("Пользователь удален");
                    this.Close();

                }
                else if (result == MessageBoxResult.No)
                {
                    System.Windows.MessageBox.Show("Пользовтель не удален");
                    this.Close();
                }
                else
                {

                }
            }
        }
    }
}
