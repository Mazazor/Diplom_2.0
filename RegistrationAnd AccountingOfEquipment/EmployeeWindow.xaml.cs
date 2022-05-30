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
    /// Логика взаимодействия для staff.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        private Employee _employee = new Employee();
        public EmployeeWindow(Employee employee)
        {
            InitializeComponent();

            if (employee != null)
                _employee = employee;

            DataContext = _employee;
            combobox1.ItemsSource = Equipment_accountingEntities.GetContext().Post.ToList();
            combobox2.ItemsSource = Equipment_accountingEntities.GetContext().Department.ToList();
        }
    }
}
