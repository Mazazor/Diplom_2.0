using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RegistrationAnd_AccountingOfEquipment
{
    public static class ConvertImage
    {
        public static BitmapImage ToBitImage(this Bitmap bitmap)
        {
            using (var memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Png);
                memory.Position = 0;
                var bitMapImage = new BitmapImage();
                bitMapImage.BeginInit();
                bitMapImage.StreamSource = memory;
                bitMapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitMapImage.EndInit();
                bitMapImage.Freeze();
                return bitMapImage;
            }
        }
    }
}
