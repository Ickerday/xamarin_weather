﻿using System;
using System.IO;
using WeatherApp.Infrastructure;
using WeatherApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Environment.SpecialFolder;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace WeatherApp
{
    public partial class App : Application
    {
        private static WeatherContext _database;
        public static WeatherContext Database => _database
            ?? (_database = new WeatherContext(Path.Combine(Environment.GetFolderPath(LocalApplicationData), "WeatherAppDb.db3")));

        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
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
