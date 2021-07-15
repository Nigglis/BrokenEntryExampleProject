﻿using Xamarin.Forms;
using AndroidSpecific = Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace ExampleProject
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent ();

            MainPage = new MainPage ();

            AndroidSpecific.Application.SetWindowSoftInputModeAdjust ( this, AndroidSpecific.WindowSoftInputModeAdjust.Resize );
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
