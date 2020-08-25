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
    /// Логика взаимодействия для update.xaml
    /// </summary>
    public partial class update : Window
    {
        public update()
        {
            InitializeComponent();
        }

        private void registationof_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void registationup_Click(object sender, RoutedEventArgs e)
        {
            AirportSHIAEntities air = new AirportSHIAEntities();
            if (updatehelpeforwpfr.one == -1 && updatehelpeforwpfr.one == 0)
            {
                MessageBox.Show("" + updatehelpeforwpfr.one);
            }
            else
            {
                var myupdate = air.Client.Where(w => w.idClient == updatehelpeforwpfr.one).FirstOrDefault();
                MessageBox.Show("" +myupdate.LastName + myupdate.PhoneNumber);
                myupdate.FirstName = firstname.Text;
                myupdate.MiddleName = Middlename.Text;
                myupdate.LastName = lastname.Text;
                myupdate.PhoneNumber = Phonenumber.Text;
                myupdate.Email = Email.Text;
                air.SaveChanges();
            }
        }
    }
}
