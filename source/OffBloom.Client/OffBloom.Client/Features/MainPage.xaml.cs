using System;
using OffBloom.Client.Features.Base;
using Xamarin.Forms;

namespace OffBloom.Client.Features
{
    public abstract class MainPageBase : ViewBase
    {
    }

    public partial class MainPage : MainPageBase
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            btn_soundcloud.Clicked += OnSoundCloudClicked;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            btn_soundcloud.Clicked -= OnSoundCloudClicked;
        }

        private void OnSoundCloudClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPage());
        }
    }
}
