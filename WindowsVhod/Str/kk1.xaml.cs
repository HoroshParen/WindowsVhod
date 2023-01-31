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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsVhod.Str
{
    /// <summary>
    /// Логика взаимодействия для kk1.xaml
    /// </summary>
    public partial class kk1 : Page
    {
        public kk1()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, RoutedEventArgs e)
        {
            userdemoEntities db = new userdemoEntities();
            Users users= db.Users.AsNoTracking().FirstOrDefault(u => u.Login == login.Text && u.Password == password.Password);
            if (users != null)
            {
                MessageBox.Show("Вход выполнен");
                NavigationService.Navigate(new kk2());
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

    }
}
