using SkiaSharp.Extended.UI.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4.MVVM.Convertor
{
    public class CodeToLottiefileConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var code = (int)value;

            var lottenImageSource = new SKFileLottieImageSource();

            switch (code)
            {
                case 0:
                    lottenImageSource.File = "sunny.json";
                    return lottenImageSource;

                case 1:
                    lottenImageSource.File = "sunny.json";
                    return lottenImageSource;

                case 2:
                    lottenImageSource.File = "cloudy.json";
                    return lottenImageSource;

                case 3:
                    lottenImageSource.File = "sunny.json";
                    return lottenImageSource;

                case 45:
                    lottenImageSource.File = "sunny.json";
                    return lottenImageSource;

                case 48:
                    lottenImageSource.File = "sunny.json";
                    return lottenImageSource;

                case 51:
                    lottenImageSource.File = "sunny.json";
                    return lottenImageSource;

                case 53:
                    lottenImageSource.File = "sunny.json";
                    return lottenImageSource;

                case 55:
                    lottenImageSource.File = "sunny.json";
                    return lottenImageSource;

                case 56:
                    lottenImageSource.File = "sunny.json";
                    return lottenImageSource;

                case 57:
                    lottenImageSource.File = "sunny.json";
                    return lottenImageSource;

                case 61:
                    lottenImageSource.File = "rainy.json";
                    return lottenImageSource;

                case 63:
                    lottenImageSource.File = "rainy.json";
                    return lottenImageSource;

                case 65:
                    lottenImageSource.File = "rainy.json";
                    return lottenImageSource;

                case 66:
                    lottenImageSource.File = "rainy.json";
                    return lottenImageSource;

                case 67:
                    lottenImageSource.File = "rainy.json";
                    return lottenImageSource;

                case 71:
                    lottenImageSource.File = "snow.json";
                    return lottenImageSource;

                case 73:
                    lottenImageSource.File = "snow.json";
                    return lottenImageSource;

                case 75:
                    lottenImageSource.File = "snow.json";
                    return lottenImageSource;

                case 77:
                    lottenImageSource.File = "snow.json";
                    return lottenImageSource;

                case 80:
                    lottenImageSource.File = "rainy.json";
                    return lottenImageSource;

                case 81:
                    lottenImageSource.File = "rainy.json";
                    return lottenImageSource;

                case 82:
                    lottenImageSource.File = "rainy.json";
                    return lottenImageSource;

                case 85:
                    lottenImageSource.File = "snow.json";
                    return lottenImageSource;

                case 86:
                    lottenImageSource.File = "snow.json";
                    return lottenImageSource;

                case 95:
                    lottenImageSource.File = "snow.json";
                    return lottenImageSource;

                case 96:
                case 99:
                    lottenImageSource.File = "snow.json";
                    return lottenImageSource;


                default:
                    return "UnKnown";

            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
