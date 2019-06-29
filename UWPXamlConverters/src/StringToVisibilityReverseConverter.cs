using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace UWPXamlConverters.Converters
{
    public class StringToVisibilityReverseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, string language)
        {
            return value == null || !(value.ToString().Equals(parameter.ToString())) ? Visibility.Visible : Visibility.Collapsed;
        }
        // ConvertBack is not implemented for a OneWay binding.
        public object ConvertBack(object value, Type targetType,
            object parameter, string language)
        {
            return value;
        }
    }
}
