﻿using System;
using System.IO;
using WeatherApp.Shared.Infrastructure;
using WeatherApp.Shared.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace WeatherApp.Shared
{
    public partial class App
    {
        private static readonly string DbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WeatherAppDb.db3");

        private static WeatherContext _database;
        private readonly MainPage _masterDetailPage;

        public static WeatherContext Database => _database
            ?? (_database = new WeatherContext(DbPath));

        public App()
        {
            InitializeComponent();
            MainPage = _masterDetailPage = new MainPage();
        }

        protected override void OnStart()
        {
            _masterDetailPage.OnStart();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
