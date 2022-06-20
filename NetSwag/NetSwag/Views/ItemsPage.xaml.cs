using NetSwag.Models;
using NetSwag.ViewModels;
using NetSwag.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetSwag.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        public ItemsViewModel ViewModel => _viewModel;

         private List<ItemDetailViewModel> GetViewModel()
        {
            return new List<ItemDetailViewModel>
            {
                new ItemDetailViewModell{Id=1,Name="Xtra Small"},
                new ItemDetailViewModell {Id=2,Name="Small"},
                new ItemDetailViewModell{Id =3,Name="Medium"},
                new ItemDetailViewModell {Id=4,Name="Large"},
                new ItemDetailViewModell {Id =5,Name="Xtra Large"},


                //  "Xtra Small",
               //   "Small",
                //    "Medium",
                 //     "Large",
                  //      "Xtra Large",


            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}