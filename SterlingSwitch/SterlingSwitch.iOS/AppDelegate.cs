﻿using CarouselView.FormsPlugin.iOS;
using FFImageLoading.Forms.Platform;
using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using Syncfusion.XForms.iOS.TabView;
using UIKit;
using DLToolkit.Forms.Controls;

namespace SterlingSwitch.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
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
            Xamarin.FormsGoogleMaps.Init("AIzaSyDYdbG_jHO5TOZcIPkKHsF0uD6po9AWvik");
            ImageCircleRenderer.Init();
            CachedImageRenderer.Init();
            CarouselViewRenderer.Init();
            SfTabViewRenderer.Init();
            FormsControls.Touch.Main.Init();
            FlowListView.Init();
            LoadApplication(new App()); 
            return base.FinishedLaunching(app, options);
        } 
        
    }
}