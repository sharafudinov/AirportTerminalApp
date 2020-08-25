using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для ticketord.xaml
    /// </summary>
    public partial class ticketord : Window
    {
        public ticketord()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, RoutedEventArgs e)
        {
            if (lastname.Text == "" && firstname.Text == "" && middlename.Text == "" && phonenumber.Text == "" && orderday.Text == "" && numberorder.Text == "" && status.Text == "")
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                AirportSHIAEntities air = new AirportSHIAEntities();
                int clients = air.Client.
                    Where(w => w.LastName == lastname.Text && w.FirstName == firstname.Text && w.MiddleName == middlename.Text && w.PhoneNumber == phonenumber.Text).
                    Select(s => s.idClient).
                    FirstOrDefault();
                OrderTIcket newuser = new OrderTIcket()
                {
                    idClient = clients,
                    idUserSystem = usersys.id,
                    idFlightTicket = orderconnetctor.id,
                    Dateorder = orderday.Text,
                    StatusOrder = status.Text,
                    NumberOrder = numberorder.Text,
                    idcustomers = 1
                    
                };
                air.OrderTIcket.Add(newuser);
                air.SaveChanges();
                
            }
        }
    }
}
