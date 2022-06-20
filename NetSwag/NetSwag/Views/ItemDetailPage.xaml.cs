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

        public class ItemDetailViewModel
        {
            public string Title { get; set; }
            public string Description { get; set; }

        }
    }
}