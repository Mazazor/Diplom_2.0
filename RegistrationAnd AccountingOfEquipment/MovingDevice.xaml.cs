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
    /// Логика взаимодействия для MovingDevice.xaml
    /// </summary>
    public partial class MovingDevice : Window
    {
        private DeviceMovement _moving = new DeviceMovement();
        public MovingDevice(DeviceMovement moving)
        {
            InitializeComponent();
            if (moving != null)
                _moving = moving;

            DataContext = _moving;
            datagrid1.ItemsSource = Equipment_accountingEntities.GetContext().DeviceMovement.ToList();
            datagrid2.ItemsSource = Equipment_accountingEntities.GetContext().Employee.ToList();

        }
    }
}
