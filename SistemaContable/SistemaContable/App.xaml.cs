using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SistemaContable.Vistas;

namespace SistemaContable
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new V_StartPage());
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
