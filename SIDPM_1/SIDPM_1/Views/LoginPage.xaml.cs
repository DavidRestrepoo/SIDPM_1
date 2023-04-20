using SIDPM_1.Data;
using SIDPM_1.Models;
using SIDPM_1.ViewModels;
using SQLite;
using SQLitePCL;
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
    public partial class LoginPage : ContentPage
    {



        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                var username = txtUserName.Text;
                var password = txtPassword.Text;
                if (App.SQLiteDB.validarLogin(username, password) != null)
                {
                    await Navigation.PushAsync(new Registrarse());
                }
                else
                {
                    await DisplayAlert("Error", "Nombre de usuario o contraseña incorrectos", "OK");
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }



        }

        private async void btnRegistrese_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrarse());
        }


    }
}