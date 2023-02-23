using System.Runtime.CompilerServices;
using Foundation;
using UIKit;

namespace TestFinalizer;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        var executionMode = GetExecutionMode();
        return base.FinishedLaunching(application, launchOptions);
    }
    public string GetExecutionMode()
    {
        if (!RuntimeFeature.IsDynamicCodeSupported)
            return "AOT";
        if (RuntimeFeature.IsDynamicCodeCompiled)
            return "JIT";
        return "Interpreter";
    }
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}

