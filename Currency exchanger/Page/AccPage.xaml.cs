using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Currency_exchanger.Page
{
    /// <summary>
    /// Логика взаимодействия для AccPage.xaml
    /// </summary>
    public partial class AccPage
    {     
        public AccPage()
        {
            InitializeComponent();          
        }

        private void accBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.db.logins.FirstOrDefault(l => l.login1 == textBox_login.Text && l.pass == password.Text);
            if (CurrentUser != null)
            {
                MessageBox.Show("Норм!");
            }
            else
            {
                MessageBox.Show("Плохо!");
            }
        }

    }
}
