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
    [Activity(Label = "ToDoList", WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden)]
    public class ToDoList : ListActivity
    {
        public List<string> Items { get; set; }

        ArrayAdapter<string> adapter;

        ISharedPreferences prefs = Application.Context.GetSharedPreferences("TODO_DATA", FileCreationMode.Private);

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ToDolijst);

            // initialize the list
            Items = new List<string>();

            // load in any existing list items from shared preferences
            Loadlist();

            // add list of items to the listview
            adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItemMultipleChoice, Items);
            ListAdapter = adapter;
            // getting clicks from the add button
            Button addButton = FindViewById<Button>(Resource.Id.button1);
            addButton.Click += delegate
            {
                // button click code

                // get our EditText box and take the string item out of it
                EditText itemText = FindViewById<EditText>(Resource.Id.editText1);
                string item = itemText.Text;
                // make sure we have a non-null item to add
                if(item == "" || item == null)
                {
                    // this is an blank item just return
                    return;
                }
                // add this new item to our main List of Items
                Items.Add(item);

                // add this new item to our adapter list
                adapter.Add(item);

                //let the list view know the adapter list has changed
                adapter.NotifyDataSetChanged();
                // clear out textbox for new entry
                itemText.Text = "";
                // update the stored key/value pairs in shared preferences
                UpdatedStoredData();

            };

        }
        // this is the method that is fired when an in the list is checked
        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);

            // when a user clicks on the check box we want to remove all checked items
            // of the list as "done" and remove the from prefs
            // give a confimation alert check first
            RunOnUiThread(() =>
            {
                AlertDialog.Builder builder;
                builder = new AlertDialog.Builder(this);
                builder.SetTitle("confirm");
                builder.SetMessage("Ben jij klaar met deze oefening?");
                builder.SetCancelable(true);

                builder.SetPositiveButton("OK", delegate
                {
                    // remove the item from the listview and the items list
                    var item = Items[position];
                    Items.Remove(item);
                    adapter.Remove(item);

                    // reset the list view so nothing is selected
                    l.ClearChoices();
                    l.RequestLayout();

                    // update the data stored in shared preferences
                    UpdatedStoredData();
                });

                builder.SetNegativeButton("Cancel", delegate
                {
                    return;
                });

                //this launches the "modal" popup
                builder.Show();
            });
        }
        // this method loads in items that are in shared preferences
        // and populates the list

        public void Loadlist()
        {
            // first we need to find out how many items we have in shared preferences
            // use itemCount key to find out
            int count = prefs.GetInt("itemCount", 0);

            //loop through the number of items we should have
            // as we get each key/value pair in SP add them to Items List
            if(count > 0)
            {
                Toast.MakeText(this, "Getting saved items...", Android.Widget.ToastLength.Short).Show();

                for(int i=0; i <= count; i++)
                {
                    string item = prefs.GetString(i.ToString(), null);
                    if(item != null)
                    {
                        // put the item in the list
                        Items.Add(item);
                    }
                }
            }

        }

        public void UpdatedStoredData()
        {
            //remove the current items in shared preferences
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.Clear();
            editor.Commit();

            //add all of the items in the list to shared preferences
            //so if the app is closed we can re-open the list
            editor = prefs.Edit();

            // key that keeps track of how many items we have stored in SP
            editor.PutInt("itemCount", Items.Count);

            int counter = 0;
            //loop through each item in the list and add it to the shared preferences
            //list to be written
            foreach(string item in Items)
            {
                editor.PutString(counter.ToString(), item);
                counter++;
            }

            // write to SP
            editor.Apply();

        }

    }
}