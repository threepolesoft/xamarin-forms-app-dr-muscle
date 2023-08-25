using DrMuscle.Screens.User.Authentication;
using DrMuscle.Screens.User.OnBoarding;
using DrMuscle.Services;
using DrMuscle.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Poppins-Regular.ttf", Alias = "PoppinsRegular")]
[assembly: ExportFont("Poppins-Medium.ttf", Alias = "PoppinsMedium")]

namespace DrMuscle
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Registration();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
