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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        AirportSHIAEntities aero = new AirportSHIAEntities();
        public Window1()
        {
           
            InitializeComponent();
        }
        public void take (string a, string b)
        {
            MessageBox.Show(" " + a + " " + b);
        }

        private void registation_Click(object sender, RoutedEventArgs e)
        {


            /**/
            /*
            AirportSHIAEntities ar = new AirportSHIAEntities();
            string a = "UT523", b = "Boeing-757";
            var testsql = gridtable.ItemsSource = aero.Flight.Include(c => c.Ticket.PriceTicket).ToList() ;
            MessageBox.Show(a + " " + b +  " "+ testsql);
            */
            //regisration page = new regisration();
            //page.ShowDialog();
            windowfolder.registrationfirst f = new registrationfirst();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var aero = new AirportSHIAEntities();
            gridtable.ItemsSource =  aero.FlightTicket.Include(x => x.Ticket).Include(u=>u.Flight).ToList();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            updatehelper a = new updatehelper();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void delited_Click(object sender, RoutedEventArgs e)
        {
            windowfolder.delitedwindow a = new delitedwindow();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void infoaboutticket_Click(object sender, RoutedEventArgs e)
        {
           custom a = new custom();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        /*
        private void dasdasd_Click(object sender, RoutedEventArgs e)
        {
            AirportSHIAEntities context = new AirportSHIAEntities();
            var asd = context.Client.SingleOrDefault(x => x.idClient == 1);
            MessageBox.Show("" + asd.LastName + asd.MiddleName + asd.PhoneNumber);
            
        <Button x:Name="dasdasd" Content="Обновление данных" Grid.Column="1" Width="140" Height="30" VerticalAlignment="Stretch" Margin="5,284,5,105" Click="dasdasd_Click"  />
        }*/
    }
}
