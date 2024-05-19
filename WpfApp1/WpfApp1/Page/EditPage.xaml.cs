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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    
    public partial class EditPage 
    {
        int Idt;
        public EditPage(Users users)
        {
            InitializeComponent();
            CmbRole.ItemsSource = OdbConnectHelpercs.diaryEnt.Role.ToList();
            CmbRole.DisplayMemberPath = "Title";
            CmbRole.SelectedValuePath = "Id";
            Idt = users.Id;
            CmbRole.SelectedValue = users.IdRole;
            TxbFio.Text = users.FIO;
            TxbLogin.Text = users.Login;
            PsbPass.Password = users.Password;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var editUser = OdbConnectHelpercs.diaryEnt.Users.FirstOrDefault(u => u.Id == Idt);
                if (CmbRole.SelectedValue != null &&
                    PsbPass.Password != null &&
                    TxbFio.Text != null &&
                    TxbLogin.Text != null)
                {

                    editUser.IdRole = Convert.ToInt32(CmbRole.SelectedValue);
                       editUser.FIO = TxbFio.Text;
                       editUser.Login = TxbLogin.Text;
                       editUser.Password = PsbPass.Password;
                       editUser.DateLastLogin = DateTime.Now;
                       editUser.IdTypeLogin = 1;
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

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var delUser = OdbConnectHelpercs.diaryEnt.Users.FirstOrDefault(u => u.Id == Idt);
                    OdbConnectHelpercs.diaryEnt.Users.Remove(delUser);

                    OdbConnectHelpercs.diaryEnt.SaveChanges();
                    MessageBox.Show("Умедовление: Успешно elfktyj", "Умедовление", MessageBoxButton.OK, MessageBoxImage.Information);
                    FrameApp.frameObj.Navigate(new MainAbminPage());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибюка:" + ex.Message, "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
