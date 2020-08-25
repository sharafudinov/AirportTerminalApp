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
    /// Логика взаимодействия для registrationfirst.xaml
    /// </summary>
    public partial class registrationfirst : Window
    {
        public registrationfirst()
        {
            InitializeComponent();
        }

        private void registationof_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void registationup_Click(object sender, RoutedEventArgs e)
        {
           
                AirportSHIAEntities a = new AirportSHIAEntities();
                Document newuser = new Document()
                {
                    TypeDocument = Typedocumentе.Text,
                    NumberDocument = Numberdocе.Text,
                    DateOfIssue = dateofendе.Text
                };
                a.Document.Add(newuser);
                a.SaveChanges();
            Class1.docend = dateofendе.Text;
            Class1.typedoc = Typedocumentе.Text;
            Class1.numberdoc = Numberdocе.Text;
            regisration abc = new regisration();
            this.Hide();
            abc.ShowDialog();
            

        }
    }
}
