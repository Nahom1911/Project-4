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
            //var etdate = FindViewById<EditText>(Resource.Id.etDate);
            //var etweight = FindViewById<EditText>(Resource.Id.etWeight);

            SQLiteDB1 sq = new SQLiteDB1();
            Button button = FindViewById<Button>(Resource.Id.buAdd);
    /*        button.Click += delegate {

                sq.Insert(etname.Text);
                textView1.Text = sq.SelectAll();
            };
            Button buDelete = FindViewById<Button>(Resource.Id.buDelete);
            buDelete.Click += delegate {
                sq.delete(Convert.ToInt32(etid.Text));
                textView1.Text = sq.SelectAll();
            };
            Button buUpdate = FindViewById<Button>(Resource.Id.buUpdate);
            buUpdate.Click += delegate {
                sq.update(etname.Text, Convert.ToInt32(etid.Text));
                textView1.Text = sq.SelectAll();
            };
            Button buSelect = FindViewById<Button>(Resource.Id.buSelect);
            buSelect.Click += delegate {
                textView1.Text = sq.select(etname.Text);
            };*/

        }
    }
    
}