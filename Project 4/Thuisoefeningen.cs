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

            imageButton1.Click += delegate
            {
                Console.WriteLine("CLICKED imageButton1");
                Intent nextActivity = new Intent(this, typeof(Armoefeningen1));
                StartActivity(nextActivity);

            };
            imageButton3.Click += delegate
            {
                Console.WriteLine("CLICKED imageButton3");
                Intent nextActivity = new Intent(this, typeof(Borstoefeningen1));
                StartActivity(nextActivity);

            };
            imageButton2.Click += delegate
            {
                Console.WriteLine("CLICKED imageButton3");
                Intent nextActivity = new Intent(this, typeof(Beenoefeningen1));
                StartActivity(nextActivity);

            };
            imageButton4.Click += delegate
            {
                Console.WriteLine("CLICKED imageButton3");
                Intent nextActivity = new Intent(this, typeof(Buikoefeningen1));
                StartActivity(nextActivity);

            };

        }
    }
}