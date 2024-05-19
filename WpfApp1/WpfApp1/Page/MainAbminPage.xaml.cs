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
using WpfApp1.Classes;

namespace WpfApp1.Page
{
    /// <summary>
    /// Логика взаимодействия для MainAbminPage.xaml
    /// </summary>
    public partial class MainAbminPage 
    {
        void Update()
        {
            MyDataGrid.ItemsSource = OdbConnectHelpercs.diaryEnt.Users.ToList();
            var sort = OdbConnectHelpercs.diaryEnt.Users.ToList();
             if (CmbRole.SelectedIndex == 0)
            {
                sort = OdbConnectHelpercs.diaryEnt.Users.ToList();
            }
            else if (CmbRole.SelectedIndex == 1) 
            {
                sort = OdbConnectHelpercs.diaryEnt.Users.Where(x=> x.IdRole == 1).ToList();
            }
            else if (CmbRole.SelectedIndex == 2)
            {
                sort = OdbConnectHelpercs.diaryEnt.Users.Where(x => x.IdRole == 2).ToList();
            }
            else if (CmbRole.SelectedIndex == 3)
            {
                sort = OdbConnectHelpercs.diaryEnt.Users.Where(x => x.IdRole == 3).ToList();
            }
            var serch = sort.Where(x => x.FIO.Contains(SerchTxb.Text)).ToList();
            MyDataGrid.ItemsSource = serch.ToList();

        }
        public MainAbminPage()
        {
            InitializeComponent();
            Update(); 
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            dynamic k = (sender as Button).DataContext;
            FrameApp.frameObj.Navigate(new EditPage(k));
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frameObj.Navigate(new AddPage());
        }

        private void SerchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void CmbRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }
    }
}
