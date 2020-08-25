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
    /// Логика взаимодействия для regisration.xaml
    /// </summary>
    public partial class regisration : Window
    {
        public regisration()
        {
            InitializeComponent();
        }

        private void registationof_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void registationup_Click(object sender, RoutedEventArgs e)
        {   /**/
            
            AirportSHIAEntities a = new AirportSHIAEntities();
            var me = a.Document.Where(er=>er.DateOfIssue == Class1.docend && er.TypeDocument== Class1.typedoc).Select(x => x.idDocument).First();
            int minimi = Convert.ToInt32(me);
            
            Client newuser = new Client()
            {
                FirstName = firstname.Text,
                MiddleName = Middlename.Text,
                LastName = lastname.Text,
                PhoneNumber = Phonenumber.Text,
                Email = Email.Text,
                idDocument = minimi
                
            };
            a.Client.Add(newuser);
            a.SaveChanges();
            this.Close();
            //MessageBox.Show(""+ minimi);
        }
    }
}
