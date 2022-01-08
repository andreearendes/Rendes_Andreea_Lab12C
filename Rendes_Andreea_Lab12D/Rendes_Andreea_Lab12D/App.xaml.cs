using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rendes_Andreea_Lab12D.Data;


namespace Rendes_Andreea_Lab12D
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
            
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
