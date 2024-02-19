using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4.MVVM.Convertor
{
    public class CodeToWeatherConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var code = (int)value;

            switch (code)
            {
                case 0:
                    return "Clear sky";
                     
                case 1:
                    return "Mainly clear";
                     
                case 2:
                    return "partly cloudy";
                     
                case 3:
                    return "overcast";
                     
                case 45:
                    return "Fog";
                     
                case 48:
                    return "depositing rime fog";
                     
                case 51:
                    return "Drizzle: Light";
                     
                case 53:
                    return "Drizzle: moderate";
                     
                case 55:
                    return "Drizzle: dense intensity";
                     
                case 56:
                    return "Freezing Drizzle: Light";
                     
                case 57:
                    return "Freezing Drizzle: dense intensity";
                     
                case 61:
                    return "Rain: Slight";
                     
                case 63:
                    return "Rain: moderate";
                     
                case 65:
                    return "Rain: heavy intensity";
                     
                case 66:
                    return "Freezing Rain: Light";
                     
                case 67:
                    return "Freezing Rain: heavy intensity";
                     
                case 71:
                    return "Snow fall: Slight";
                     
                case 73:
                    return "Snow fall: moderate";
                     
                case 75:
                    return "Snow fall: heavy intensity";
                     
                case 77:
                    return "Snow grains";
                     
                case 80:
                    return "Rain showers: Slight";
                     
                case 81:
                    return "Rain showers: moderate";
                     
                case 82:
                    return "Rain showers: violent";
                     
                case 85:
                    return "Snow showers slight";
                     
                case 86:
                    return "Snow showers heavy";
             
                case 95:
                    return "Thunderstorm: Slight or moderate";
                     
                case 96:
                case 99:
                    return "Thunderstorm with slight";
             

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
