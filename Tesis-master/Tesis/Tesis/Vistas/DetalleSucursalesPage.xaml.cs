using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesis.Geolocalizacion;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tesis.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalleSucursalesPage : ContentPage
	{
		public DetalleSucursalesPage ()
		{
			InitializeComponent ();
		}

        /* private async void Onbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapAppPage());
            var btn = sender as Button;
            btn.Command.Execute(btn.CommandParameter); 



            Application.Current.MainPage = new NavigationPage(new MapAppPage2());
        } */
    }
}