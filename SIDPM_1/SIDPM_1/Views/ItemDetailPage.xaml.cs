using SIDPM_1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SIDPM_1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}