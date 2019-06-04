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
    public class DetalleSucursalVModelo:BaseVModelo
    {
        private ApiServicio apiServicios;
        private Sucursal sucursal;
        private string calleSucursal;
        private int numeroSucursal;
        private string telefonoSucursal;
        private string calleIntersección;

        private double latitud;
        private double longitud;

        //PROPIEDADES
        public double Latitud
        {
            get { return this.latitud; }
            set { this.SetValue(ref this.latitud, value); }
        }

        public double Longitud
        {
            get { return this.longitud; }
            set { this.SetValue(ref this.longitud, value); }
        }
        public Sucursal Sucursal
        {
            get { return this.sucursal; }
            set { this.SetValue(ref this.sucursal,value); }
        }
        public string CalleSucursal
        {
            get { return this.calleSucursal; }
            set { this.SetValue(ref this.calleSucursal, value); }
        }

        public string TelefonoSucursal
        {
            get { return this.telefonoSucursal; }
            set { this.SetValue(ref this.telefonoSucursal, value); }
        }

        public int NumeroSucursal
        {
            get { return this.numeroSucursal; }
            set { this.SetValue(ref this.numeroSucursal, value); }
        }

        public string CalleIntersección
        {
            get { return this.calleIntersección; }
            set { this.SetValue(ref this.calleIntersección, value); }
        }

        public double latitud2;
        public double longitud2;
        public string calle1;


        public DetalleSucursalVModelo(Sucursal sucursal)
        {
            this.Sucursal = sucursal;
            this.apiServicios = new ApiServicio();
            this.CalleSucursal = sucursal.calle;
            this.NumeroSucursal = sucursal.numero;
            this.CalleIntersección = sucursal.calleIntersección;
            this.TelefonoSucursal = sucursal.telefono;
            this.Latitud = sucursal.latitud;
            this.Longitud = sucursal.longitud;
            latitud2 = sucursal.latitud;
            longitud2 = sucursal.longitud;
            calle1 = sucursal.calle + " " + sucursal.numero + " con " + sucursal.calleIntersección; 
        }

        public ICommand MapaCommand
        {
            get
            {  
                   return new RelayCommand(IrMapa);
            }
        }

        private async void IrMapa()
        {



         //   VistaPrincipal.GetInstancia().DetalleSucursales = new DetalleSucursalVModelo(this);
            await Application.Current.MainPage.Navigation.PushAsync(new MapAppPage2(latitud2, longitud2, calle1));



        }
    }
}
