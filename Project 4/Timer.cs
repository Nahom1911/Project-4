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
using RadialProgress;
using System.Timers;

namespace Project_4
{
    [Activity(Label = "Timer")]
    public class Timer : Activity
    {
        RadialProgressView radialProgressView;
        Button btnStart , btnStop;
        TextView txtTimer;

        Timer timer;

        int hour = 0, min = 0, sec = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Timer);

           /* radialProgressView = FindViewById<RadialProgressView>(Resource.Id.progressView);
            btnStart = FindViewById<Button>(Resource.Id.btnStart);
            btnStop = FindViewById<Button>(Resource.Id.btnStop);
            txtTimer = FindViewById<TextView>(Resource.Id.txtTimer);

            btnStart.Click += delegate {
               // btnStart.Enabled = false;
               // btnStop.Enabled = true;
                timer = new Timer();
                timer.Interval = 1000;
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
            };

            btnStop.Click += delegate {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                timer.Dispose();
                timer = null;

            };
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                min++;
                sec = 0;
            }
            if (min == 60)
            {
                hour++;
                min = 0;
            }
            RunOnUiThread(() => { txtTimer.Text = $"{hour}:{min}:{sec}"; });
            radialProgressView.Value = sec;*/
        }
    }
}