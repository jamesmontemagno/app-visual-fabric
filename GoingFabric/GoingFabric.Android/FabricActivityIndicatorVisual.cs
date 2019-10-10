using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GoingFabric.CustomControls;
using GoingFabric.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.ActivityIndicator),
    typeof(FabricActivityIndicatorVisualRenderer),
    new[] { typeof(FabricVisual) })]

namespace GoingFabric.Droid
{
    public class FabricActivityIndicatorVisualRenderer : ActivityIndicatorRenderer
    {
        public FabricActivityIndicatorVisualRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ActivityIndicator> e)
        {
            base.OnElementChanged(e);

            
            var progress = new Android.Widget.ProgressBar(this.Context, null, 0, GoingFabric.Droid.Resource.Style.Widget_UIFabric_CircularProgress_Large_Primary);
            SetNativeControl(progress);
            
        }
    }
}