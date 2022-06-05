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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing;
using Microsoft.Win32;
using System.Drawing.Imaging;

namespace RegistrationAnd_AccountingOfEquipment
{
    /// <summary>
    /// Логика взаимодействия для Device.xaml
    /// </summary>
    public partial class DeviceWindow : Window
    {
        private Device _device = new Device();
        Bitmap bitmap;
        SaveFileDialog saveFile = new SaveFileDialog();
        public DeviceWindow(Device device)
        {
            InitializeComponent();

            if (device != null)
                _device = device;

            DataContext = _device;
            combobox1.ItemsSource = Equipment_accountingEntities.GetContext().DeviceType.ToList();
            combobox2.ItemsSource = Equipment_accountingEntities.GetContext().DeviceStatus.ToList();
            combobox3.ItemsSource = Equipment_accountingEntities.GetContext().Employee.ToList();
            DataGridCharacteristic.ItemsSource = Equipment_accountingEntities.GetContext().Characteristic.ToList();

        }


        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            string qrText = NameBox.Text;
            QRCodeEncoder encoder = new QRCodeEncoder();
            encoder.QRCodeScale = 8;
            bitmap = encoder.Encode(qrText);
            QrImage.Source = ConvertImage.ToBitImage(bitmap);
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            saveFile.Filter = "PNG|*.png";
            saveFile.FileName = NameBox.Text;
            if (saveFile.ShowDialog() == true)
            {
                if(bitmap != null)
                {
                    bitmap.Save(string.Concat(saveFile.FileName, ".png"), ImageFormat.Png);
                }
            }
        }

        private void devisetabadd_Click(object sender, RoutedEventArgs e)
        {
            AddingType addingType = new AddingType();
            addingType.Show();
            
        }

        private void devicestatusadd_Click(object sender, RoutedEventArgs e)
        {
            AddingType addingStatus = new AddingType();
            addingStatus.Show();
        }

        private void employeeadd_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeeWindow = new EmployeeWindow(null);
            employeeWindow.Show();
        }
    }
}
