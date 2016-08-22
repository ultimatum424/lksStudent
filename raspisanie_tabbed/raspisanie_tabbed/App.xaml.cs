using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace raspisanie_tabbed
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            CTimeTable timeTable = new CTimeTable();
            int groupNumber = 1;
            //MainPage = new TimeTableSettingsPage();
            MainPage = new TabbedPage
            {
                
                Children =
                {
                    new HomePage(timeTable, groupNumber, 0),
                    new HomePage(timeTable, groupNumber, 1),
                    new HomePage(timeTable, groupNumber, 2),
                    new HomePage(timeTable, groupNumber, 3),
                    new HomePage(timeTable, groupNumber, 4),
                    new HomePage(timeTable, groupNumber, 5),
                }
            };
            
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
