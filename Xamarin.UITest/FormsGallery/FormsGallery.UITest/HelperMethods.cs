﻿using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace FormsGallery.UITest
{
    public class HelperMethods
    {

        public IApp app;
        public Platform platform;

        public void OpenPage(string page, int pageType)
        {
            app.ScrollUp(); // makes sure state is reset
            if (pageType == 0)
            {
                app.Tap("C# Pages");
                app.Screenshot("C# " + page + " page");
            }
            else
            {
                app.Tap("XAML Pages");
                app.Screenshot("XAML " + page + " page");
            }
            app.ScrollDownTo(page);
            app.Screenshot("Scrolled Down To" + page);
            app.Tap(x => x.Marked(page));
            app.Screenshot(page);
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

    }
}