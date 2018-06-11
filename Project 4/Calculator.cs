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
    [Activity(Label = "Calculator")]
    public class Calculator : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.BmiApp);
            Button button = FindViewById<Button>(Resource.Id.buttonCalculate);
            button.Click += delegate {

                var weight = float.Parse(FindViewById<EditText>(Resource.Id.InputWeight).Text);
                var height = float.Parse(FindViewById<EditText>(Resource.Id.InputHeight).Text);


                var result = Bmiapp1.CalculateBodyMassIndex(weight, height);

                FindViewById<TextView>(Resource.Id.OutputResult).Text = result.ToString();

            };
            // Create your application here
        }
    }
}