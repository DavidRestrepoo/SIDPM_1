using SIDPM_1.Models;
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
	public partial class Registrarse : ContentPage
	{
		public Registrarse ()
		{
			InitializeComponent ();
		}

        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Registro registro = new Registro
                {
                    UserName = txtUserName.Text,
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Program = txtProgram.Text,
                    Password = txtPassword.Text,
                };
                await App.SQLiteDB.saveRegistroAsync(registro);
                txtUserName.Text = "";
                txtName.Text = "";
                txtLastName.Text = "";
                txtProgram.Text = "";
                txtPassword.Text = "";
                await DisplayAlert("Registro", "Se guardo exitosamente el registro", "OK");
                await Navigation.PushAsync(new LoginPage());
            }
            else
            {
                await DisplayAlert("Advertencia", "Ingresar todos los datos", "OK");
            }
        }
        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtProgram.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}