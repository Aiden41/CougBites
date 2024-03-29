﻿using System;
using System.Collections.Generic;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using SQLite;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.IO;
using Android.Util;
using System.Linq;
using Android.Content;

namespace CougBites.Droid
{
    [Activity(Label = "CougBites", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Window.AddFlags(Android.Views.WindowManagerFlags.TranslucentStatus);
            Window.AddFlags(Android.Views.WindowManagerFlags.TranslucentNavigation);
            LoadApplication(new App());
            List<Models.FoodItem> foods = await App.database.GetFoodAsync();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}