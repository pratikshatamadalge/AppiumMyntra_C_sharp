﻿using Demo.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyntraAutomation.Utilities
{
    class Utility:BaseClass
    {
        /// <summary>
        /// To take screenshot after every test
        /// </summary>
        /// <param name="driver">to control browser</param>
        /// <param name="testStatus">failed or passed test</param>
        /// <returns></returns>
        public static string TakeScreenshot(IWebDriver driver, string testStatus)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string finalPath = path.Substring(0, path.LastIndexOf("bin")) + "Screenshots\\" + testStatus + ".png";
            string localPath = new Uri(finalPath).LocalPath;
            screenshot.SaveAsFile(localPath, ScreenshotImageFormat.Png);
            return localPath;
        }

    }
}