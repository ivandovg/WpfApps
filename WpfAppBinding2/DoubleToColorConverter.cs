using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfAppBinding2
{
    [ValueConversion(typeof(double), typeof(Brush))]
    public class DoubleToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return ((double)value < 5) ? Brushes.Red : Brushes.Green;
            }
            catch
            {
                return Brushes.Gray;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // однонаправленный конвертер
            //return null;


            Brush brush = value as Brush;
            if (brush == null)
                return null;

            return brush.Equals(Brushes.Red) ? 0 : 10;
        }
    }
}
