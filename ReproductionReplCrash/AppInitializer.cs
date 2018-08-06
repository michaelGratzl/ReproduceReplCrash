using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ReproductionReplCrash
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                StartAndroidApp.ExecuteEmulatorShellCommand();

                return ConfigureApp
                    .Android
                    .ApkFile (GlobalParameters.apkFileLocation)
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}
