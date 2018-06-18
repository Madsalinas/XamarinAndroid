using System;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;
using Android.Widget;

namespace AppTask
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //                                                  //tag for Log.info() method.
        readonly string tag = "MAVS";
        //--------------------------------------------------------------------------------------------------------------
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Log.Debug(tag, "The onCreate() event");

            Button buttonNew = FindViewById<Button>(Resource.Id.ButtonNewTask);
            buttonNew.Click += (sender, args) => { InResponseToButtonNew(sender, args); };
        }

        //--------------------------------------------------------------------------------------------------------------
        protected override void OnStart()
        {
            base.OnStart();
            Log.Debug(tag, "The OnStart() event");
        }
        //--------------------------------------------------------------------------------------------------------------
        protected override void OnResume()
        {
            base.OnResume();
            Log.Debug(tag, "The OnResume() event");
        }
        //--------------------------------------------------------------------------------------------------------------
        protected override void OnPause()
        {
            base.OnPause();
            Log.Debug(tag, "The OnPause() event");
        }
        //--------------------------------------------------------------------------------------------------------------
        protected override void OnStop()
        {
            base.OnStop();
            Log.Debug(tag, "The OnStop() event");
        }
        //--------------------------------------------------------------------------------------------------------------
        protected override void OnDestroy()
        {
            base.OnDestroy();
            Log.Debug(tag, "The OnDestroy() event");
        }
        //--------------------------------------------------------------------------------------------------------------
        public void InResponseToButtonNew(Object sender, EventArgs args)
        {
            Log.Debug(tag, "click ButtonNewTask");
            Intent intent = new Intent(this, typeof(NewTaskFormActivity));
            StartActivity(intent);
    }
    }
    /*END-ACTIVITY*/
}


