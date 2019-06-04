using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Tesis.Comun.Modelo;
using Tesis.Geolocalizacion;
using Tesis.Servicios;
using Xamarin.Forms;

namespace Tesis.VistaModelo
{
    public class DetalleSucursalItemVModel:Sucursal

    {
        private ApiServicio apiServicio;
        public DetalleSucursalItemVModel()
        {
            this.apiServicio = new ApiServicio();
        }
        /*public ICommand MapaCommand
        {
            get
            {
                return new RelayCommand(IrMapa);
            }
        }

        private async void IrMapa()
        {



            VistaPrincipal.GetInstancia().DetalleSucursales = new DetalleSucursalVModelo(this);
            await Application.Current.MainPage.Navigation.PushAsync(new MapAppPage2());



        }*/
    }
}
