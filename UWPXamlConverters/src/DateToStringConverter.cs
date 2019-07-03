using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UWPXamlConverters.Converters
{
    public class DateToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
              object parameter, string language)
        {
            if (value == null)
            {
                return null;
            }
            else
            {
                DateTime d = DateTime.Now;
                try
                {

                    string date = (string)value;
                    d = System.Convert.ToDateTime(date);
                    d = DateTime.SpecifyKind(d, DateTimeKind.Local);
                }
                catch (Exception e)
                {
                    return null;
                }
                return (DateTimeOffset)d;
            }

        }
        public object ConvertBack(object value, Type targetType,
            object parameter, string language)
        {
            string Data = string.Empty;
            if (value == null)
            {
                return Data;
            }
            else
            {
                DateTime d = new DateTime();
                d = ((DateTimeOffset)value).LocalDateTime;
                Data = d.Date.ToString("yyyy-MM-dd");
            }
            return Data;
        }


    }
}
