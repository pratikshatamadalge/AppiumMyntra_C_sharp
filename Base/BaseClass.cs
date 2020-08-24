// <copyright file="BaseClass.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyntraAutomation.Base
{
    using AventStack.ExtentReports;
    using AventStack.ExtentReports.MarkupUtils;
    using MyntraAutomation.ExtentReport;
    using MyntraAutomation.Utilities;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Android;
    using System;
    using System.Threading;

    /// <summary>
    /// Base class.
    /// </summary>
    public class BaseClass
    {
        public static ExtentReports extent = ReportManager.GetInstance();
        public static ExtentTest test;
        public const string path =@"F:\VS\MobileAutomation\Demo\Screenshots";
        public AndroidDriver<AndroidElement> driver;

        //craete instance of Log4net
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Driver Initialization.
        /// </summary>
        [OneTimeSetUp]
        [System.Obsolete]
        public void Initialization()
        {
            AppiumOptions options = new AppiumOptions();
            options.PlatformName = "Android";
            options.AddAdditionalCapability("deviceName", "Galaxy M31");
            options.AddAdditionalCapability("platformVersion", "Android");
            options.AddAdditionalCapability("automationName", "UiAutomator1");
            options.AddAdditionalCapability("appPackage", "com.myntra.android");
            options.AddAdditionalCapability("appActivity", "com.myntra.android.SplashActivity");
            options.AddAdditionalCapability("udid", "RZ8N21M5VHY");
            Uri url = new Uri("http://127.0.0.1:4723/wd/hub");
            driver = new AndroidDriver<AndroidElement>(url, options);
        }

        /// <summary>
        /// Set up method for each testCase.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            Utility.InternetConnection();
        }

        /// <summary>
        /// To add extent report,screenshot features for each test case.
        /// </summary>
        [TearDown]
        public void close()
        {
            try
            {
                Utility.InternetConnection();
                test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
                if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                {
                    string path = Utility.TakeScreenshot(driver, TestContext.CurrentContext.Test.Name);
                    test.Log(Status.Fail, "Test Failed");
                    test.AddScreenCaptureFromPath(path);
                    test.Fail(MarkupHelper.CreateLabel(TestContext.CurrentContext.Test.Name, ExtentColor.Red));
                }
                else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
                {
                    test.Log(Status.Pass, "Test Sucessful");
                    test.Pass(MarkupHelper.CreateLabel(TestContext.CurrentContext.Test.Name, ExtentColor.Green));
                }
            }
            catch (Exception e)
            {
                log.Error("error: " + e);

                Console.Out.WriteLine(e.StackTrace);
                Console.Out.WriteLine(e.Message);
            }

            Thread.Sleep(5000);
            extent.Flush();
        }

        /// <summary>
        /// Driver Quit.
        /// </summary>
        [OneTimeTearDown]
        public void TearDown()
        {
            Utility.SendEmail();
            this.driver.Quit();
        }
    }
}