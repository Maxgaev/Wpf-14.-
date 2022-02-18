using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows;

namespace WpfЗадание_14.Шаблоны_данных
{
    internal class Convert
    {
        class ProdImageConvert : IValueConvert
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if (((ProductTypes)value) == ProductTypes.Food)
                {
                    return "Data";
                }
                return "Appliance";
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return DependencyProperty.UnsetValue;
            }


        }
    }
}
