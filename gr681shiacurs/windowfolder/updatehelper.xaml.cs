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

namespace gr681shiacurs.windowfolder
{
    /// <summary>
    /// Логика взаимодействия для updatehelper.xaml
    /// </summary>
    public partial class updatehelper : Window
    {
        public updatehelper()
        {
            InitializeComponent();
        }


        private void registationof_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void registationup_Click(object sender, RoutedEventArgs e)
        {
            AirportSHIAEntities airport = new AirportSHIAEntities();
            var test = airport.Client.Where(x => x.FirstName == familiyaе.Text && x.LastName == Otchestvoе.Text && x.MiddleName == nameе.Text).Select(u => u.idClient).FirstOrDefault();
            if (test != -1 && test !=0)
            {
                MessageBox.Show("Пользователь найден переходим к коректировки данных");
                updatehelpeforwpfr.one = test;
                update a = new update();
                this.Hide();
                a.ShowDialog();

            }
        }
    }
}
