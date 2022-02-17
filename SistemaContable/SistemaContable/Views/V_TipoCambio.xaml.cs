using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SistemaContable.ViewModels;

namespace SistemaContable.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_TipoCambio : ContentPage
    {
        public V_TipoCambio(Models.User _user)
        {
            InitializeComponent();
            BindingContext = new VM_TipoCambio(_user);
            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.FromRgb(45, 140, 253);
        }
    }
}