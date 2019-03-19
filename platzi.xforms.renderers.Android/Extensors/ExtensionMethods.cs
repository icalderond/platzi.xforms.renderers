using System;
namespace platzi.xforms.renderers.Droid.Extensors
{
    public static class ExtensionMethods
    {
        public static Android.Graphics.Color ToAndroid(this Xamarin.Forms.Color color)
        {
            Android.Graphics.Color colorToReturn = new Android.Graphics.Color((int)color.R, (int)color.G, (int)color.B);
            return colorToReturn;
        }
    }
}
