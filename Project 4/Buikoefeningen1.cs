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
    [Activity(Label = "Buikoefeningen1")]
    public class Buikoefeningen1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Buikoefeningen);
            // Create your application here
            var Button1 = FindViewById<Button>(Resource.Id.Button1);
            var Button2 = FindViewById<Button>(Resource.Id.Button2);
            var Button3 = FindViewById<Button>(Resource.Id.Button3);

            Button1.Click += delegate
            {
                Console.WriteLine("CLICKED Button1");
                Intent nextActivity = new Intent(this, typeof(Buikvideo));
                StartActivity(nextActivity);
            };
            Button2.Click += delegate
            {
                Console.WriteLine("CLICKED Button2");
                Intent nextActivity = new Intent(this, typeof(Buikvideo2));
                StartActivity(nextActivity);
            };
            Button3.Click += delegate
            {
                Console.WriteLine("CLICKED Button3");
                Intent nextActivity = new Intent(this, typeof(Buikvideo3));
                StartActivity(nextActivity);
            };
        }
    }
}