﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace KeyboardSplitter.Converters
{
    public class GameItemStatusToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (targetType == typeof(Brush) && value.GetType() == typeof(Enums.GameItemStatus))
            {
                var status = (Enums.GameItemStatus)value;
                switch (status)
                {
                    case KeyboardSplitter.Enums.GameItemStatus.None:
                        return Brushes.Transparent;
                    case KeyboardSplitter.Enums.GameItemStatus.OK:
                        return Brushes.Lime;
                    case KeyboardSplitter.Enums.GameItemStatus.Warning:
                        return Brushes.Yellow;
                    case KeyboardSplitter.Enums.GameItemStatus.Broken:
                        return Brushes.Red;
                    default:
                        break;
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}