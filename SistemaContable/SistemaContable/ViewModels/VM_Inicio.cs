using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SistemaContable.Models;
using SistemaContable.Data;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using SistemaContable.Views;

namespace SistemaContable.ViewModels
{
    class VM_Inicio: BaseViewModel
    {
        #region Atributos
        private string _nombre;
        private User _user;
        #endregion

        #region Constructor
        public VM_Inicio(User user)
        {
            _user = new User();
            _user = user;
            _nombre = user.Nombre.ToUpper();
        } 
        #endregion

        public string txtNombre
        {
            get { return this._nombre; }
            set { SetValue(ref this._nombre, value); }
        }

        #region Commands
        public ICommand estadoCuentaCommand
        {
            get { return new RelayCommand(EstadoCuentaCommand); }
        }
        public ICommand AhorroCommand
        {
            get { return new RelayCommand(Ahorro); }
        }
        public ICommand TipoCambioCommand
        {
            get { return new RelayCommand(TipoCambio); }
        }
        #endregion

        #region Metodos
        private async void EstadoCuentaCommand()
        {
            await App.Current.MainPage.Navigation.PushAsync(new V_EstadoCuenta(_user));
        }
        private async void Ahorro()
        {
            await App.Current.MainPage.Navigation.PushAsync(new V_Ahorro(_user));
        }
        private async void TipoCambio()
        {
            await App.Current.MainPage.Navigation.PushAsync(new V_TipoCambio(_user));
        }
        #endregion

    }
}
