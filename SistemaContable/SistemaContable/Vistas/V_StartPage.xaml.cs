using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace SistemaContable.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_StartPage : ContentPage
    {
        public V_StartPage()
        {
            InitializeComponent();
            btnLogin.Clicked += navLogin_Clicked;
            btnRegistro.Clicked += navRegistro_Clicked;
        }

        private void navLogin_Clicked(object sender,EventArgs e)
        {
            Navigation.PushAsync(new V_Login());
        }

        private void navRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new V_Registro());
        }
    }
}