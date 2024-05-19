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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage 
    {
        public AddPage()
        {
            InitializeComponent();
            CmbRole.ItemsSource = OdbConnectHelpercs.diaryEnt.Role.ToList();
            CmbRole.DisplayMemberPath = "Title";
            CmbRole.SelectedValuePath = "Id";
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CmbRole.SelectedValue != null &&
                    PsbPass.Password != null &&
                    TxbFio.Text != null &&
                    TxbLogin.Text != null)
                {
                    Users user = new Users()
                    {
                       IdRole = Convert.ToInt32(CmbRole.SelectedValue),
                       FIO = TxbFio.Text,
                       Login = TxbLogin.Text,
                       Password = PsbPass.Password,
                       DateLastLogin = DateTime.Now,
                       IdTypeLogin = 1
                    };
                    OdbConnectHelpercs.diaryEnt.Users.Add(user);
                    OdbConnectHelpercs.diaryEnt.SaveChanges();
                    MessageBox.Show("Умедовление: Успешно добавлено", "Умедовление", MessageBoxButton.OK, MessageBoxImage.Information);
                    FrameApp.frameObj.Navigate(new MainAbminPage());
                }
                else
                {
                    MessageBox.Show("Заполните поля", "Умедовление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибюка:" + ex.Message, "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
