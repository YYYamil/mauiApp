using Foundation;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

AppCenter.Start("{Your app secret here}",
                   typeof(Analytics), typeof(Crashes));
namespace MauiApp2
{

    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}

