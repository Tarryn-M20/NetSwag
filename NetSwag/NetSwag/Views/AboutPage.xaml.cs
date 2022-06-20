using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetSwag.Views
{
    public partial class AboutPage : ContentPage
    {
        private readonly object label;
        private int carouselPosition = 0;
        private int itemsInCarousel = 0;


        public AboutPage()
        {
            InitializeComponent();

            var items = TShirtCarouselView.ItemsSource as string[];



            Device.StartTimer(new TimeSpan(0, 0, 2), () =>
            {

                TShirtCarouselView.ScrollTo(carouselPosition++);

                if (carouselPosition >= items.Length)
                    carouselPosition = 0;


                return true; 
            });
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
