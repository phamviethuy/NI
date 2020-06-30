using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows;

namespace NationalInstruments.Examples.CoercionModes
{
    /// <summary>
    /// This class allows for conversion of Boolean values into System.Windows.Visibility values.
    /// This conversion can be used in Bindings from Boolean controls to the visibility of another
    /// control within the XAML for a UI.
    /// </summary>
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanToVisibilityConverter : System.Windows.Data.IValueConverter
    {
        public BooleanToVisibilityConverter()
        {
        }

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool? isVisible = (bool?)value;
            if (isVisible.HasValue)
            {
                bool visible = isVisible.Value;
                if (visible)
                {
                    return Visibility.Visible;
                }
                else
                {
                    return Visibility.Collapsed;
                }
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            if (visibility == Visibility.Visible)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
