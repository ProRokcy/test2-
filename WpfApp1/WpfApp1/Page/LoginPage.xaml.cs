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
using WpfApp1.Page;
using WpfApp1.Classes;

namespace WpfApp1.Page
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage 
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (TxbLogin.Text != null &&
                     PsbPass.Password != null)
                {
                    var user = OdbConnectHelpercs.diaryEnt.Users.FirstOrDefault(x => x.Login == TxbLogin.Text && x.Password == PsbPass.Password);
                    if (user == null)
                    {
                        MessageBox.Show("Такого пользователя нету!", "Уведомление",
                                                  MessageBoxButton.OK,
                                                  MessageBoxImage.Warning);
                        PsbPass.BorderBrush = new SolidColorBrush(Colors.Red);
                        TxbLogin.BorderBrush = new SolidColorBrush(Colors.Red);
                    }

                    else
                    {
                        UserControlClass.UserId = user.Id;
                        switch (user.IdRole)
                        {
                            case 1:
                                FrameApp.frameObj.Navigate(new MainAbminPage());
                                break;
                            case 2:
                                FrameApp.frameObj.Navigate(new TeamLedPage());

                                break;
                            case 3:
                                FrameApp.frameObj.Navigate(new TeamLedPage());

                                break;
                        }
                    }
                }

                else
                {
                    MessageBox.Show("заполните все поля","Умедлвлени",
                                                     MessageBoxButton.OK,
                                                     MessageBoxImage.Warning);
                    PsbPass.BorderBrush = new SolidColorBrush(Colors.Red);
                    TxbLogin.BorderBrush = new SolidColorBrush(Colors.Red);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Уведомление:" + ex.Message.ToString(), "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
    }
}
