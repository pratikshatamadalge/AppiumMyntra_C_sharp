using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MyntraAutomation.Pages
{
    public class WishlistPage
    {
        public AndroidDriver<AndroidElement> driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistPage"/> class.
        /// </summary>
        /// <param name="driver">pageFactory initialization.</param>
        public WishlistPage(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='mobile']")]
        IWebElement mobileNo;

        [FindsBy(How = How.Id, Using = "form-button")]
        IWebElement continueBtn;

        [FindsBy(How = How.XPath, Using = "//android.view.ViewGroup[@content-desc='product_image']/android.widget.ImageView")]
        IWebElement productImage;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@content-desc='product_title']")]
        IWebElement productTitle;

        /// <summary>
        /// Wishlist Method.
        /// </summary>
        public void Wishlistpage()
        {
            mobileNo.SendKeys("7875680359");
            Thread.Sleep(2000);
            driver.HideKeyboard();
            continueBtn.Click();
            Thread.Sleep(25000);
            productImage.Click();
            Thread.Sleep(2000);
        }

        /// <summary>
        /// To Validate wishlist Page
        /// </summary>
        public bool ValidateWishList()
        {
            return productTitle.Displayed;
        }
    }
}