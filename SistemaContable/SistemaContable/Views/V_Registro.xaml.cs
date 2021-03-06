using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SistemaContable.ViewModels;

namespace SistemaContable.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_Registro : ContentPage
    {
        public V_Registro()
        {
            InitializeComponent();
            BindingContext = new VM_Registro();
            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.FromRgb(45, 140, 253);
        }
    }
}