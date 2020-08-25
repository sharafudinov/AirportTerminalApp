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
    /// Логика взаимодействия для orderedwindow.xaml
    /// </summary>
    public partial class orderedwindow : Window
    {
        public orderedwindow()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            if (comboclass.Text == null && combodate.Text == null && combodepart.Text == null && comboland.Text == null)
            {
                MessageBox.Show("Нужно выбрать все элементы");
            }
            else
            {
                var aero = new AirportSHIAEntities();
                gridtable.ItemsSource = aero.FlightTicket.Include(x => x.Ticket).Include(u => u.Flight).Where(x=>x.Ticket.ClassTicket == comboclass.Text&& x.Flight.LandingPoint == comboland.Text && x.Flight.PointOfDeparture == combodepart.Text && x.Flight.DateFlight == combodate.Text).ToList();
            }
        }

        private void order_Click(object sender, RoutedEventArgs e)
        {
            if(orderconnetctor.id == 0 && orderconnetctor.id == -1)
            {
                MessageBox.Show("нужно выбрать рейс");
            }
            else
            {
                ticketord a = new ticketord();
                this.Hide();
                a.ShowDialog();
                this.Show();
            }
        }

        private void gridtable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FlightTicket fticket = gridtable.SelectedItem as FlightTicket;

            if (fticket != null)
            {
                var aero = new AirportSHIAEntities();
                orderconnetctor.id = aero.FlightTicket.Include(x => x.Ticket).Include(u => u.Flight).Where(x => x.Ticket.ClassTicket == fticket.Ticket.ClassTicket && x.Flight.LandingPoint == fticket.Flight.LandingPoint && x.Flight.PointOfDeparture == fticket.Flight.PointOfDeparture && x.Flight.DateFlight == fticket.Flight.DateFlight).Select(x=>x.idFlightTicket).FirstOrDefault(); 
            }
            else
            {
                return;
            }
        }
    }
}
