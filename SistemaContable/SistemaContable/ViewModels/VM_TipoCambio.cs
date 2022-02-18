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
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace SistemaContable.ViewModels
{
    class VM_TipoCambio : BaseViewModel
    {
        #region Atributos
        private string _nombre;
        private double? _dolares01;
        private double _dolaresrpta;
        private double? _soles01;
        private double _solesrpta;
        private User _user;
        private CasaCambio _casa;
        private string url = "https://api.apis.net.pe/v1/tipo-cambio-sunat";
        HttpClient cliente = new HttpClient();
        #endregion

        public VM_TipoCambio(User user)
        {
            _nombre = user.Nombre;
            _user = user;
            iniciarCasa();
        }
        public async void  iniciarCasa()
        {
            string contenido = await cliente.GetStringAsync(url);
            Casa = JsonConvert.DeserializeObject<CasaCambio>(contenido);
           
        }

        #region Propiedades

        public  CasaCambio Casa
        {
            get { return this._casa; }
            set { SetValue(ref this._casa, value); }

        }
        public double? txtDolaresSoles
        {
            get { return this._dolares01; }
            set { SetValue(ref this._dolares01, value); }
        }
        public double? txtSolesDolares
        {
            get { return this._soles01; }
            set { SetValue(ref this._soles01, value); }
        }
        public double txtSolesResultado
        {
            get { return this._solesrpta; }
            set { SetValue(ref this._solesrpta, value); }
        }
        public double txtDolaresResultado
        {
            get { return this._dolaresrpta; }
            set { SetValue(ref this._dolaresrpta, value); }
        }
        #endregion

        #region Commands
        public ICommand DolaresSolesCommand
        {
            get { return new RelayCommand(dolaresSolesCommand); }
        }
        public ICommand SolesDolaresCommand
        {
            get { return new RelayCommand(solesDolaresCommand); }
        }
        #endregion

        private void dolaresSolesCommand()
        {
            double dolares = Casa.compra;
            if (txtDolaresSoles != null)
            {
                double resultado = dolares * (double)txtDolaresSoles;
                txtSolesResultado = resultado;
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error", "Inserte la cantidad de Dolares a Convertir en Soles", "OK");
            }           
        }
        private void solesDolaresCommand()
        {
            double soles = Casa.venta;
            if (txtSolesDolares != null)
            {
                double resultado = soles * (double)txtSolesDolares;
                txtDolaresResultado = resultado;
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error", "Inserte la cantidad de Soles a Convertir en Dolares", "OK");
            }
        }
    }
}
