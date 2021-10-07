using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //ApplicationView.PreferredLaunchViewSize = new Size(480, 800);
            //ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            
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
