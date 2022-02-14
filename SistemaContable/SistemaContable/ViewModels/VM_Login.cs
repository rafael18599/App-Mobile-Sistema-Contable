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


namespace SistemaContable.ViewModels
{
    public class VM_Login: BaseViewModel
    {
        #region Atributos
        private string _email;
        private string _contraseña;
        #endregion

        #region Propiedades
        public string txtEmail
        {
            get { return this._email; }
            set { SetValue(ref this._email, value); }
        }
        public string txtContraseña
        {
            get { return this._contraseña; }
            set { SetValue(ref this._contraseña, value); }
        }
        #endregion

        #region Commands
        public ICommand loginCommand
        {
            get { return new RelayCommand(LoginCommand); }
        }
        #endregion

        private async void LoginCommand()
        {
            if (string.IsNullOrEmpty(this.txtEmail))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe ingresar un correo electrónico", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.txtContraseña))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe ingresar una Contraseña", "Aceptar");
                return;
            }
            List<User> e = App.Database.getUserLogin(txtEmail, txtContraseña).Result;
            if(e.Count != 0)
            {
                await App.Current.MainPage.DisplayAlert("Exito", "Sesión Iniciada Correctamente", "Aceptar");
                await App.Current.MainPage.Navigation.PushAsync(new V_Inicio());
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Ingrese Email y constraseña correctamente", "Aceptar");
            }
        }

    }
}
