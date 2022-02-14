using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SistemaContable.Vistas;
using SQLite;
using SistemaContable.Data;
using System.IO;

namespace SistemaContable
{
    public partial class App : Application
    {
        static DatabaseQuery database;

        public static DatabaseQuery Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.name"));
                }
                return database;
            }
        }

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
