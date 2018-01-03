using System;
using Xamarin.Forms;

namespace OffBloom.Client
{
    public static class ResourceHelper
    {
        public static string ContentBackgroundColor = nameof(ContentBackgroundColor);

        public static Color GetColor(string resourceName)
        {
            return (Color)Application.Current.Resources[resourceName];
        }
    }
}
