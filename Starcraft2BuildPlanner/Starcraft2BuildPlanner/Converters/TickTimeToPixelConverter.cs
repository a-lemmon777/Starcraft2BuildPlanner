using System;
using System.Globalization;
using System.Windows.Data;

namespace Starcraft2BuildPlanner
{
    // Each tick should map to 4 pixels
    class TickTimeToPixelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (uint)value * 4;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToUInt32(value) / 4;
        }
    }
}
