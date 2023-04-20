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
using Ycebnaia.Pages;

namespace Ycebnaia
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool _admin = false;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Page1());
        }

        private void Adminpanel_Click(object sender, RoutedEventArgs e)
        {
            if (_admin)
            {
                MessageBoxResult x = MessageBox.Show("Вы действительно хотите выйти из режима администратора", "Выйти", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if(x == MessageBoxResult.OK)
                {
                    _admin = false;
                    MainFrame.Refresh();
                    return;
                }
            }
            AdminPage passwordWindow = new AdminPage();
            if(passwordWindow.ShowDialog()== true)
            {
                if (passwordWindow.Password == "0000")
                {
                    MessageBox.Show("Авторизация пройдена");
                    _admin = true;
                    MainFrame.Refresh();
                }
                else
                    MessageBox.Show("Неверный пароль");
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
        }

        private void btnUsl_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new UslugiStr());
        }

        private void btnZap_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ZapisiStr());
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            
            if (MainFrame.CanGoBack)
            {
                if (_admin)
                {

                    btnBack.Visibility = Visibility.Visible;
                    btnZap.Visibility = Visibility.Visible;
                    btnUsl.Visibility = Visibility.Visible;
                    Adminpanel.Visibility = Visibility.Visible;
                }
                else
                {
                    btnBack.Visibility = Visibility.Visible;
                    btnUsl.Visibility = Visibility.Collapsed;
                    btnZap.Visibility = Visibility.Collapsed;
                    Adminpanel.Visibility = Visibility.Visible;
                }
            }
            else
            {
                if (_admin)
                {
                    btnBack.Visibility = Visibility.Collapsed;
                    btnZap.Visibility = Visibility.Visible;
                    btnUsl.Visibility = Visibility.Visible;
                    Adminpanel.Visibility = Visibility.Visible;
                }
                else
                {
                    btnBack.Visibility = Visibility.Collapsed;
                    btnUsl.Visibility = Visibility.Collapsed;
                    btnZap.Visibility = Visibility.Collapsed;
                    Adminpanel.Visibility = Visibility.Visible;
                }
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack) { MainFrame.GoBack();}
        }
    }
}
