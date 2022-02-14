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
    public partial class V_Login : ContentPage
    {
        public V_Login()
        {
            InitializeComponent();
            BindingContext = new VM_Login();
        }
    }
}