using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UWPXamlConverters.Converters
{
    public class StringToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value != null ? ((string)value).Contains((string)(parameter)) : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return parameter;
        }
    }
}
