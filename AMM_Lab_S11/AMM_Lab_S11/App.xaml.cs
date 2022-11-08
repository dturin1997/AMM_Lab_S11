using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AMM_Lab_S11
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new Views.ViewOperaciones();
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
