using System;
using Xamarin.Forms;

namespace platzi.xforms.renderers
{
    public class CircularProgress : View
    {
        //Progress
        public static readonly BindableProperty ProgressProperty =
        BindableProperty.Create("Progress",
            typeof(float),
            typeof(CircularProgress),
            (float)0);

        public float Progress
        {
            get { return (float)GetValue(ProgressProperty); }
            set { SetValue(ProgressProperty, value); }
        }

        //Limit of progres
        public static readonly BindableProperty MaxProperty =
            BindableProperty.Create("Max",
            typeof(float),
            typeof(CircularProgress), (float)0);

        public float Max
        {
            get { return (float)GetValue(MaxProperty); }
            set { SetValue(MaxProperty, value); }
        }

        //Is indeterminate
        public static readonly BindableProperty IndeterminateProperty =
            BindableProperty.Create("Indeterminate", typeof(bool), typeof(CircularProgress), false);

        public bool Indeterminate
        {
            get { return (bool)GetValue(IndeterminateProperty); }
            set { SetValue(IndeterminateProperty, value); }
        }

        //Speed
        public static readonly BindableProperty IndeterminateSpeedProperty =
            BindableProperty.Create("IndeterminateSpeed", typeof(int), typeof(CircularProgress), 0);

        public int IndeterminateSpeed
        {
            get { return (int)GetValue(IndeterminateSpeedProperty); }
            set { SetValue(IndeterminateSpeedProperty, value); }
        }

        //Progress backgorund color
        public static readonly BindableProperty ProgressBackgroundColorProperty =
            BindableProperty.Create("ProgressBackgroundColor", typeof(Color), typeof(CircularProgress), Color.White);

        public bool ProgressBackgroundColor
        {
            get { return (bool)GetValue(ProgressBackgroundColorProperty); }
            set { SetValue(ProgressBackgroundColorProperty, value); }
        }

        //Progress color
        public static readonly BindableProperty ProgressColorProperty =
            BindableProperty.Create("ProgressColor", typeof(Color), typeof(CircularProgress), Color.Red);

        public bool ProgressColor
        {
            get { return (bool)GetValue(ProgressColorProperty); }
            set { SetValue(ProgressColorProperty, value); }
        }
    }
}
