using FormsChat.Views;
using Xamarin.Forms;

namespace FromsChat
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //SendBirdClient.Init(Resource.APP_ID);
            MainPage = new NavigationPage(new MainPage());
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
