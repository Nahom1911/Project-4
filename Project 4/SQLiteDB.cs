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
    [Activity(Label = "SQLiteDB")]
    public class SQLiteDB : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DB);

            var textView1 = FindViewById<TextView>(Resource.Id.tvViewText);
            var etname = FindViewById<EditText>(Resource.Id.etFullName);
            var etid = FindViewById<EditText>(Resource.Id.etid);
            var etdate = FindViewById<EditText>(Resource.Id.etDatetime);
            var etweight = FindViewById<EditText>(Resource.Id.etWeight);

            SQLiteDB1 sq = new SQLiteDB1();
            Button buAdd = FindViewById<Button>(Resource.Id.buAdd);
            buAdd.Click += delegate {

                sq.Insert(etname.Text, etdate.Text, etweight.Text);
                textView1.Text = sq.SelectAll();
            };


            Button buDelete = FindViewById<Button>(Resource.Id.buDelete);
            buDelete.Click += delegate
            {
                sq.Delete(Convert.ToInt32(etid.Text));
                textView1.Text = sq.SelectAll();
            };

            Button buSelect = FindViewById<Button>(Resource.Id.buSelect);
            buSelect.Click += delegate {
                textView1.Text = sq.select(etname.Text);
            };

        }
    }
    
}