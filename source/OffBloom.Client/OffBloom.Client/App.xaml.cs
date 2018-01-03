﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OffBloom.Client.Features;

using Xamarin.Forms;

namespace OffBloom.Client
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
