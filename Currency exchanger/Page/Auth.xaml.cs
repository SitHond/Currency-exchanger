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

namespace Currency_exchanger.Page
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.db.logins.FirstOrDefault(l => l.login1 == loginBtn.Text && l.pass == passBtn.Text);
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
