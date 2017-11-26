using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Zoerator
{
    class Splash : ContentPage
    {
        Image splashImage;

        public Splash()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "SplashZoerator.png",
                WidthRequest = 600,
                HeightRequest = 600
            };
            AbsoluteLayout.SetLayoutFlags(splashImage,
            AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(5000);

            Application.Current.MainPage = new NavigationPage(new MainPage());    //After loading  MainPage it gets Navigated to our new Page
        }
    }
}
