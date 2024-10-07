using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace LAB2.Converters
{
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Dictionary<Status, BitmapImage> cache = new Dictionary<Status, BitmapImage>();

            var status = (Status)value;

            if (!cache.ContainsKey(status))
            {
                var Uri = new Uri(String.Format(@"../Images/ClientStatus/status_{0}.png", status), UriKind.Relative);
                cache.Add(status, new BitmapImage(Uri));
            }

            return cache[status];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
