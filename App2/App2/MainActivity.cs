using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            Button OKButton = FindViewById<Button>(Resource.Id.button1);
            EditText fooEditText = FindViewById<EditText>(Resource.Id.editText1);
            TextView fooTextView = FindViewById<TextView>(Resource.Id.textView1);

            OKButton.Click += (s, e) =>
            {
                fooTextView.Text = fooEditText.Text;
            };
        }
    }
}

