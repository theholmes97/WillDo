﻿using System;
using WillDo.Services;
using Xamarin.Forms;

namespace WillDo
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<RealmDataStore>();
            else
                DependencyService.Register<MockDataStore>();

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new MainPage();
            else
                MainPage = new NavigationPage(new MainPage());
        }
    }
}
