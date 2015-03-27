using PunchCalculatorApp.View;
using PunchCalculatorApp.ViewModel;
using Xamarin.Forms;

namespace PunchCalculatorApp
{
    public class App : Application
    {
        public static ViewModelLocator locator;

        public static ViewModelLocator Locator
        {
            get
            {
                return locator ?? (locator = new ViewModelLocator());
            }
        }

        public App()
        {
            // The root page of your application
            MainPage = new CalculatorView();
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
