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

namespace RegistrationAnd_AccountingOfEquipment
{
    /// <summary>
    /// Логика взаимодействия для AutharizationWindow.xaml
    /// </summary>
    public partial class AutharizationWindow : Window
    {
        public AutharizationWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          try
          {
                var userObj = Equipment_accountingEntities.GetContext().User.FirstOrDefault(x => x.Login == LoginBox.Text && x.Password == PasswordBox.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нет!", "Ошибка при авторизации",
                        MessageBoxButton.OK, MessageBoxImage.Error);                                          
                }
                else
                {
                    switch (userObj.IdRole)
                    {
                        case 1:MessageBox.Show("Здравствуйте, Администратор !",
                            "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.Show();
                            Close();
                            break;

                        case 2:
                            MessageBox.Show("Здравствуйте, Работник !",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;

                        default: MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
           }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + " Критическая работа приложения",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            CreateAccWindow createAcc = new CreateAccWindow();
            createAcc.Show();
            Close();
        }
       
    }
}
