using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Widget;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content;

namespace Project_4
{
    [Activity(Label = "Project_4", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Hoofdmenu);

            var imageButton1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            var imageButton2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
            var imageButton3 = FindViewById<ImageButton>(Resource.Id.imageButton3);

            imageButton1.Click += delegate
            {
                Console.WriteLine("CLICKED imageButton1");
                Intent nextActivity = new Intent(this, typeof(Thuisoefeningen));
                StartActivity(nextActivity);

            };

            imageButton2.Click += delegate
            {
                Console.WriteLine("CLICKED imageButton2");
                Intent nextActivity = new Intent(this, typeof(BMI));
                StartActivity(nextActivity);

            };

            imageButton3.Click += delegate
            {
                Console.WriteLine("CLICKED imageButton3");
                Intent nextActivity = new Intent(this, typeof(Timer));
                StartActivity(nextActivity);

            };
        }
    }
}

