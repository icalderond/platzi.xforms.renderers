﻿using System;
using Xamarin.Forms.Platform.Android;
using com.refractored.monodroidtoolkit;
using Android.Content;
using System.ComponentModel;
using Xamarin.Forms;
using platzi.xforms.renderers;
using platzi.xforms.renderers.Droid.Renderers;

[assembly: ExportRenderer(typeof(CircularProgress), typeof(CircularProgressRenderer))]
namespace platzi.xforms.renderers.Droid.Renderers
{
    public class CircularProgressRenderer : ViewRenderer<CircularProgress, HoloCircularProgressBar>
    {
        public CircularProgressRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<CircularProgress> e)
        {
            base.OnElementChanged(e);

            //Check if exist element of circularProgress
            if (e.OldElement != null || this.Element == null)
            {
                //Not exist element
                return;
            }

            var progress = new HoloCircularProgressBar(Context);
            progress.Max = Element.Max;
            progress.Indeterminate = Element.Indeterminate;
            progress.ProgressColor = Element.ProgressColor.ToAndroid();
            progress.ProgressBackgroundColor = Element.ProgressBackgroundColor.ToAndroid();
            progress.IndeterminateInterval = Element.IndeterminateSpeed;

            SetNativeControl(progress);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control == null || Element == null)
            {
                return;
            }

            if (e.PropertyName == CircularProgress.MaxProperty.PropertyName)
            {
                Control.Max = Element.Max;
            }
            else if (e.PropertyName == CircularProgress.ProgressProperty.PropertyName)
            {
                Control.Progress = Element.Progress;
            }
            else if (e.PropertyName == CircularProgress.IndeterminateProperty.PropertyName)
            {
                Control.Indeterminate = Element.Indeterminate;
            }
            else if (e.PropertyName == CircularProgress.IndeterminateSpeedProperty.PropertyName)
            {
                Control.IndeterminateInterval = Element.IndeterminateSpeed;
            }
            else if (e.PropertyName == CircularProgress.ProgressBackgroundColorProperty.PropertyName)
            {
                Control.ProgressBackgroundColor = Element.ProgressBackgroundColor.ToAndroid();
            }
            else if (e.PropertyName == CircularProgress.ProgressColorProperty.PropertyName)
            {
                Control.ProgressColor = Element.ProgressColor.ToAndroid();
            }
        }
    }
}