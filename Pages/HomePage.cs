﻿// <copyright file="SearchProduct.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Demo.Pages
{
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.Android;
    using SeleniumExtras.PageObjects;

    /// <summary>
    /// Search Product page.
    /// </summary>
    public class HomePage
    {
        public AndroidDriver<AndroidElement> driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// </summary>
        /// <param name="driver">pageFactory initialization.</param>
        public HomePage(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//android.widget.ImageView[@content-desc='wishlist']")]
        IWebElement wishlistIcon;

        /// <summary>
        /// Wishlist Method.
        /// </summary>
        public void Wishlist()
        {
            wishlistIcon.Click();
            Thread.Sleep(2000);
        }
    }
}