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
    /// Логика взаимодействия для CreateAccWindow.xaml
    /// </summary>
    public partial class CreateAccWindow : Window
    {     
        public CreateAccWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            AutharizationWindow authWindow = new AutharizationWindow();
            authWindow.Show();
            Close();
        }

       

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (Equipment_accountingEntities.GetContext().User.Count(x => x.Login == LoginBox.Text)>0)
            {
                MessageBox.Show("Пользователь с таким логином есть!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                User userObj = new User()
                {
                    Login = LoginBox.Text,
                    Password = PassBox.Text,
                    IdRole = 2
                };
                Equipment_accountingEntities.context.User.Add(userObj);
                Equipment_accountingEntities.context.SaveChanges();
                MessageBox.Show("Данные успешно добавлены!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
                
        }
    }
}
