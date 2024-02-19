using MauiApp4.MVVM.Models;
using MauiApp4.MVVM.Views;


namespace MauiApp4
{
    public partial class App : Application
    {
       
            InitializeComponent();
            MainPage = new NavigationPage(new WeatherView());
        }
    }
}