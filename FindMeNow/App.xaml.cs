using FindMeNow.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMeNow
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = Resolver.Resolve<MainView>();
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
