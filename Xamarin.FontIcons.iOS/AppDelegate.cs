using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Xamarin.FontIcons.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        const string _fontName = "customfont";
        nfloat _fontSize = 16;

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes
            {
                TextColor = UIColor.Black,
                Font = UIFont.FromName("customfont", 24)
            });

            var textAttributes = new UITextAttributes()
            {
                Font = UIFont.FromName(_fontName, _fontSize)
            };

            UIBarButtonItem.Appearance.SetTitleTextAttributes(textAttributes, UIControlState.Normal);
            UIBarButtonItem.Appearance.SetTitleTextAttributes(textAttributes, UIControlState.Highlighted);

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
