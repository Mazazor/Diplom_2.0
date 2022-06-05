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
    /// Логика взаимодействия для DeviceRepair.xaml
    /// </summary>
    public partial class DeviceRepair : Window
    {
        private RepairWork _repairwork = new RepairWork();
        public DeviceRepair( RepairWork repairwork)
        {
            InitializeComponent();
            if (repairwork != null)
                _repairwork = repairwork;

            DataContext = _repairwork;
            DataGrid1.ItemsSource = Equipment_accountingEntities.GetContext().RepairWork.ToList();
            DataGrid2.ItemsSource = Equipment_accountingEntities.GetContext().Employee.ToList();
            combobox.ItemsSource = Equipment_accountingEntities.GetContext().DeviceStatus.ToList();
        }
    }
}
