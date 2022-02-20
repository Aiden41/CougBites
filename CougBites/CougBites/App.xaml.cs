using CougBites.Services;
using CougBites.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.Collections.Generic;
using Android.OS;
using Android.Content.Res;
using Android.Content;
using System.Reflection;
using CsvHelper;
using System.Globalization;
using Android.Util;

namespace CougBites
{
    public partial class App : Application
    {
        public static Database database;

        public static Database Database
        {
            get
            {
                database = new Database(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "MyDB.db3"));

                return database;
            }
        }

        public App()
        {
            database = new Database(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "MyDB.db3"));
            Datatest();
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        async public void Datatest()
        {
            if (database == null)
                Log.Debug("LOL", "KC SUCKS");
            await App.database.SaveFoodAsync(new Models.FoodItem
            {
                Name = "Muffin"
            });
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
