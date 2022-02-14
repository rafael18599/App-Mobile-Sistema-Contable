using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SistemaContable.Models;
using SistemaContable.Data;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using SistemaContable.Vistas;

namespace SistemaContable.ViewModels
{
    public class VM_Registro:BaseViewModel
    {
        #region Atributos
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _contraseña;
        #endregion

        #region Propiedades
        public string txtNombre
        {
            get { return this._nombre; }
            set { SetValue(ref this._nombre, value); }
        }
        public string txtApellido
        {
            get { return this._apellido; }
            set { SetValue(ref this._apellido, value); }
        }
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
        public ICommand RegistrarCommand
        {
            get { return new RelayCommand(RegistroCommand); }
        } 
        #endregion

        #region Metodos
        private async void RegistroCommand()
        {
            if (string.IsNullOrEmpty(this.txtNombre))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe ingresar un Nombre", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.txtApellido))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe ingresar un Apellido", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.txtContraseña))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe ingresar una Contraseña", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.txtEmail))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe ingresar un correo electrónico", "Aceptar");
                return;
            }

            var user = new User
            {
                Nombre = txtNombre.ToLower(),
                Apellido = txtApellido.ToLower(),
                Email = txtEmail.ToLower(),
                Contraseña = txtEmail.ToLower()
            };
            await App.Database.SaveUserAsync(user);
            await App.Current.MainPage.DisplayAlert("Listo", "Registro Exitoso", "Aceptar");
            await App.Current.MainPage.Navigation.PushAsync(new V_Login());
        } 
        #endregion
    }
}
