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
    [Activity(Label = "BMI")]
    public class BMI : Activity
    {
        EditText height, weight;
        TextView result;
        Button calculate;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.BMI);

            /*height = (EditText)FindViewById(Resource.Id.height);
            weight = (EditText)FindViewById(Resource.Id.weight);
            result = (TextView)FindViewById(Resource.Id.result);
            calculate = (Button)FindViewById(Resource.Id.calculate);

            calculate.SetOnClickListener();
            {
                string bmiString = Core.BmiCalculator.Calculate(height, weight);
                bmiString = string.Format("{0:0.00}", bmiString);
                bmiLabel.Text = "Your BMI is " + bmiString;
                if (bmiString.Equals("unavailable because you are naughty!"))
                {
                    (bmiString.Equals("I have no advice for you!"))
                }
                else
                {
                    double bmiNumber = double.Parse(bmiString);
                    if (bmiNumber < 18.5)
                        result.Text = "You are underweight! ):";
                    else if (bmiNumber < 25.0)
                        result.Text = "You are healthy! (:";
                    else if (bmiNumber < 30)
                        result.Text = "You are overweight! ):";
                    else
                        result.Text = "You are obese! ):";*/

                   
                }
            }
        }
    }
}