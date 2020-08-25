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
    /// Логика взаимодействия для secondwindow.xaml
    /// </summary>
    public partial class secondwindow : Window
    {
        public secondwindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void thiload(object sender, RoutedEventArgs e)
        {
            var aero = new AirportSHIAEntities();
            gridtable.ItemsSource = aero.FlightTicket.Include(x => x.Ticket).Include(u => u.Flight).ToList();
            
        }

        private void orderbutton_Click(object sender, RoutedEventArgs e)
        {
            orderedwindow a = new orderedwindow();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }
    }
}
