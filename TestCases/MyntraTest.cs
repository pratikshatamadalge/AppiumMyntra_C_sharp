// <copyright file="MyntraTest.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyntraAutomation
{
    using MyntraAutomation.Base;
    using MyntraAutomation.Pages;
    using NUnit.Framework;

    /// <summary>
    /// Test Class.
    /// </summary>
    public class MyntraTest : BaseClass
    {
        /// <summary>
        /// To check driver initialization.
        /// </summary>
        [Test]
        [Order(1)]
        public void DriverInitializationTest()
        {
            Assert.IsNotNull(this.driver);
        }
        
        /// <summary>
        /// Wishlist Test.
        /// </summary>
        [Test]
        [Order(2)]
        public void WishlistTest()
        {
            HomePage page = new HomePage(driver);
            page.Wishlist();
            WishlistPage wishlist = new WishlistPage(driver);
            wishlist.Wishlistpage();
            bool result = wishlist.ValidateWishList();
            Assert.AreEqual(result, true);
        }
    }
}