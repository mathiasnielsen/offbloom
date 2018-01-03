using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace OffBloom.Client.Features.Base
{
    public abstract class ViewBase : ContentPage
    {
        public ViewBase()
        {
            BackgroundColor = ResourceHelper.GetColor(ResourceHelper.ContentBackgroundColor);

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}
