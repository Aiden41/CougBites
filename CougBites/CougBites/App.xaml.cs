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
                if(database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyDB.db3"));
                }

                if (database == null)
                    Log.Debug("LOL", "KC SUCKS");

                return database;
            }
        }

        public App()
        {
            database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyDB.db3"));
            InitializeComponent();    
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            Datatest();
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
