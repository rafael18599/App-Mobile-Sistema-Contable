﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SistemaContable.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_EstadoCuenta : ContentPage
    {
        public V_EstadoCuenta(Models.User _user)
        {
            InitializeComponent();
        }
    }
}