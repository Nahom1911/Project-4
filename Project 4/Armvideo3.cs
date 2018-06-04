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
using Android.Webkit;

namespace Project_4
{
    [Activity(Label = "Armvideo3")]
    public class Armvideo3 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Armvid3);
            // Create your application here

            var WebView = (WebView)FindViewById(Resource.Id.button1);
            WebView.Settings.JavaScriptEnabled = true;
            WebView.SetWebChromeClient(new WebChromeClient());
            WebView.LoadUrl("https://www.youtube.com/watch?v=hffjRd86Zno");
        }
    }
}