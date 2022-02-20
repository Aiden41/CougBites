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
            var path = Environment.getExternalStorageDirectory().getPath();
            using (var reader = new StreamReader("Dining_Data_Final.csv"))
            {                              //1    2       3       4    5      6     7     8     9   10     11
                var trash = reader.ReadLine(); //id  name   locID   desc  sat    sun   mon   tue   b/l   s     d
                var foodItems = new List<(int, string, int, string, int, int, int, int, int, int, int)>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                                                 //id        name      locID                    desc       sat         sun        mon         tue       b/l         s          d
                    foodItems.Add((Int32.Parse(values[0]), values[1], Int32.Parse(values[2]), values[3], Int32.Parse(values[4]), Int32.Parse(values[5]), Int32.Parse(values[6]), Int32.Parse(values[7]), Int32.Parse(values[8]), Int32.Parse(values[9]), Int32.Parse(values[10])));
                }
            };
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
