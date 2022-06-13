using NetSwag.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NetSwag.Views
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