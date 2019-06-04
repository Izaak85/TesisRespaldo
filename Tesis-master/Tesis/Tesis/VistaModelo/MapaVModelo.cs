using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Comun.Modelo;
using Tesis.Servicios;

namespace Tesis.VistaModelo
{
    public class MapaVModelo:BaseVModelo
    {
        private ApiServicio apiServicio;
        private Sucursal sucursal;
        private double latitud;
        private double longitud;


        public Sucursal Sucursal
        {
            get { return this.sucursal; }
            set { this.SetValue(ref this.sucursal, value); }
        }

        private double Latitud
        {
            get { return this.latitud; }
            set { this.SetValue(ref this.latitud, value); }
        }

        private double Longitud
        {
            get { return this.longitud; }
            set { this.SetValue(ref this.longitud, value); }
        }

        public MapaVModelo(Sucursal sucursal)
        {
            this.Sucursal = sucursal;
            this.apiServicio = new ApiServicio();
            this.Latitud = sucursal.latitud;
            this.Longitud = sucursal.longitud;
        }
    }
}
