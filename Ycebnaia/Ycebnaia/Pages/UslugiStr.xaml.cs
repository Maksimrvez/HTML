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
using Ycebnaia.Bd;

namespace Ycebnaia.Pages
{
    /// <summary>
    /// Логика взаимодействия для UslugiStr.xaml
    /// </summary>
    public partial class UslugiStr : Page
    {
        public UslugiStr()
        {
            InitializeComponent();
            ListAvto.ItemsSource = BdpracticEntities1.GetContext().yslygi.ToList();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
