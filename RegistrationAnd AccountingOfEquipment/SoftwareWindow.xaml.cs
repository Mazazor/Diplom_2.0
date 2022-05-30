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
    /// Логика взаимодействия для Software.xaml
    /// </summary>
    public partial class SoftwareWindow : Window
    {
        private Software _software = new Software();
        public SoftwareWindow(Software software)
        {
            InitializeComponent();

            if (software != null)
                _software = software;

            DataContext = _software;
            combobox1.ItemsSource = Equipment_accountingEntities.GetContext().SoftwareType.ToList();
        }

        private void softwaretypeadd_Click(object sender, RoutedEventArgs e)
        {
            AddingType addingType = new AddingType();
            addingType.Show();
        }
    }
}
