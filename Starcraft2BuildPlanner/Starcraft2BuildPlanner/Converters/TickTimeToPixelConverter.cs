using System;
using System.Globalization;
using System.Windows.Data;

namespace Starcraft2BuildPlanner
{
    // Each tick should map to 2 pixels
    class TickTimeToPixelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value * 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value / 2;
        }
    }
}
