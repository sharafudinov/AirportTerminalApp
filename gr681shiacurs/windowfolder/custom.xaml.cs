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
    /// Логика взаимодействия для custom.xaml
    /// </summary>
    public partial class custom : Window
    {
        public custom()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, RoutedEventArgs e)
        {
            AirportSHIAEntities air = new AirportSHIAEntities();
            int clients = air.Client.
                Where(w => w.LastName == lastname.Text && w.FirstName == firstname.Text && w.MiddleName == middlename.Text).
                Select(s => s.idClient).
                FirstOrDefault();
            var ordtic = air.OrderTIcket.Where(x => x.idClient == clients && x.idUserSystem == usersys.id && x.NumberOrder == numberorder.Text).FirstOrDefault();
            int abc = Convert.ToInt32(weight.Text);
            customs newuser = new customs()
            {
                Baggage = typebaggage.Text,
                Weight = abc,
                Cost = cost.Text
            };
            air.customs.Add(newuser);
            air.SaveChanges();
            int id = air.customs.Where(x => x.Weight == abc && x.Cost == cost.Text && x.Baggage == typebaggage.Text).Select(s => s.idcustoms).FirstOrDefault();
            ordtic.idcustomers = id;
            air.SaveChanges();
        }
    }
}
