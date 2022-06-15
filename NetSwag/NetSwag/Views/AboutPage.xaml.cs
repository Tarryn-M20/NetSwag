using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetSwag.Views
{
    public partial class AboutPage : ContentPage
    {
        private readonly object label;

        public AboutPage()
        {
            InitializeComponent();
        }

        private object GetLabel()
        {
            return label;
        }

       /* async void OnButtonClicked(object sender, EventArgs args, object label)
        {
            await label.RelRotateTo(360, 1000);
        }*/

        CarouselView carouselView = new CarouselView
        {
            ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal)
            {
               SnapPointsType = SnapPointsType.MandatorySingle,
               SnapPointsAlignment = SnapPointsAlignment.End
            }

        };

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            
        }

    }
    
}
