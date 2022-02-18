using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SistemaContable.ViewModels;
using SistemaContable.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace SistemaContable.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_TipoCambio : ContentPage
    {
        public V_TipoCambio(Models.User _user)
        {
            InitializeComponent();
            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.FromRgb(45, 140, 253);
            BindingContext = new VM_TipoCambio(_user);
        }
    }
}