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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        int _itemcount = 0; // переменная для подсчета записей
        public Page1()
        {
            InitializeComponent();
            ListAvto.ItemsSource = BdpracticEntities1.GetContext().yslygi.ToList();// вывод данных из бд
            //_itemcount = ListAvto.Items.Count;
            //TxtCount.Text = $"Результат запроса: {_itemcount} записей из {_itemcount}";
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)// вывод бд
        {
            if (Visibility == Visibility.Visible)
                BdpracticEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            ListAvto.ItemsSource = BdpracticEntities1.GetContext().yslygi.OrderBy(p => p.naimenovanue).ToList();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();// данные из класса
        }

        private void CmbSort_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();// данные из класса
        }

        private void UpdateData()
        {
            var Uslugicurrent = BdpracticEntities1.GetContext().yslygi.OrderBy(p => p.naimenovanue).ToList();// присвоение бд
            _itemcount = ListAvto.Items.Count;// подсчет записей
            Uslugicurrent = Uslugicurrent.Where(p => p.naimenovanue.ToLower().Contains(TxtSearch.Text.ToLower())).ToList();// поиск по названию
            ListAvto.ItemsSource = Uslugicurrent; // вывод результат поиска
            // сортировка
            if (CmbSort.SelectedIndex >= 0)
            {
                // сортировка по возрастанию цены
                if (CmbSort.SelectedIndex == 0)
                    Uslugicurrent = Uslugicurrent.OrderBy(p => p.tcena).ToList();
                // сортировка по убыванию цены
                if (CmbSort.SelectedIndex == 1)
                    Uslugicurrent = Uslugicurrent.OrderByDescending(p => p.tcena).ToList();
                // В качестве источника данных присваиваем список данных
                ListAvto.ItemsSource = Uslugicurrent;
            }
            if (SortSale.SelectedIndex >= 0) // сортировка по скидке
            { 
                int a = 0;
                int b = 0;
                switch (SortSale.SelectedIndex) // свитч для процент скидок
                {
                    case 0:
                        a = 0;
                        b = 5;
                        break;
                    case 1:
                        a = 5;
                        b = 15;
                        break;
                    case 2:
                        a = 15;
                        b = 30;
                        break;
                    case 3:
                        a = 30;
                        b = 70;
                        break;
                    case 4:
                        a = 70;
                        b = 100;
                        break;
                    case 5:
                        a = 0;
                        b = 100;
                        break;
                }
                Uslugicurrent = Uslugicurrent.Where(p => p.skidka >= a && p.skidka < b).ToList(); // промежуток скидки
            }
            ListAvto.ItemsSource = Uslugicurrent; // вывод сортировки
            TxtCount.Text = $"Результат запроса: {Uslugicurrent.Count} записей из {_itemcount}"; // вывод кол-ва записей
        }
        private void SortSale_SelectionChanged(object sender, SelectionChangedEventArgs e) // сортировка скидки
        {
            UpdateData();
        }
    }
}
