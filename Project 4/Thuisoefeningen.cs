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

namespace Project_4
{
    [Activity(Label = "Thuisoefeningen")]
    public class Thuisoefeningen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Thuisoefeningen);
            // Create your application here
            var imageButton1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            var imageButton2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
            var imageButton3 = FindViewById<ImageButton>(Resource.Id.imageButton3);
            var imageButton4 = FindViewById<ImageButton>(Resource.Id.imageButton4);
            var imageButton5 = FindViewById<ImageButton>(Resource.Id.imageButton5);

            imageButton1.Click += delegate
            {
                Console.WriteLine("CLICKED imageButton1");
                Intent nextActivity = new Intent(this, typeof(Armoefening1));
                StartActivity(nextActivity);

            };

        }
    }
}