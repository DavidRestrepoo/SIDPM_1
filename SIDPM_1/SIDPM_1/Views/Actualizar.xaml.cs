using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIDPM_1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Actualizar : ContentPage
	{
		public Actualizar ()
		{
			InitializeComponent ();
		}

        private async void btnActualizar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var username = txtUserName.Text;
                var password = txtPassword.Text;
                var user = App.SQLiteDB.validarLogin(username, password);
                if (user != null)
                {
                    
                }
                else
                {
                    await DisplayAlert("Error", "Nombre de usuario o contraseña incorrectos", "OK");
                }
            }
            catch (Exception ex) 
            {
                await DisplayAlert("Error", "Nombre de usuario o contraseña incorrectos", "OK");
            }
          
        }
    }
}