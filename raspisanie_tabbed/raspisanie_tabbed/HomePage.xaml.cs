using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Xamarin.Forms;

namespace raspisanie_tabbed
{
    public partial class HomePage : ContentPage
    {
        public HomePage(CTimeTable timeTable, int group = 0, int day = 0)
        {
            InitializeComponent();

            Title = timeTable.table[day].day;
            MainListView.ItemsSource = timeTable.table[day].lessons;

        }

    }
}

