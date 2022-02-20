using CougBites.Services;
using CougBites.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace CougBites
{
    public partial class App : Application
    {
        public static SQLiteAsyncConnection db;

        public App()
        {
            InitializeComponent();
            InitDatabase();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        public static async Task InitDatabase()
        {
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyDB.db");
            var db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<Models.FoodItem>();
          //  using (var reader = new StreamReader(Path.Combine(FileSystem.AppDataDirectory, "Mydata.csv"))
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
