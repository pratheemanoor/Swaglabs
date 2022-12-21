using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class Pagedetails
    {
        public Pagedetails(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //username
        [FindsBy(How = How.XPath, Using = "//*[@id=\"user-name\"]")]
        public IWebElement unm { get; set; }

        //password
        [FindsBy(How = How.XPath, Using = "//*[@id=\"password\"]")]
        public IWebElement pss { get; set; }

        //login button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"login-button\"]")]
        public IWebElement logbtn { get; set; }

        //add cart
        [FindsBy(How = How.XPath, Using = "//*[@id=\"add-to-cart-sauce-labs-backpack\"]")]
        public IWebElement addcart { get; set; }

        //icon
        [FindsBy(How = How.XPath, Using = "//*[@id=\"shopping_cart_container\"]/a")]
        public IWebElement icon { get; set; }



        //menu
        [FindsBy(How = How.XPath, Using = "//*[@id=\"react-burger-menu-btn\"]")]
        public IWebElement menuu { get; set; }

       //about 
        [FindsBy(How = How.XPath, Using = "//*[@id=\"about_sidebar_link\"]")]
        public IWebElement abt { get; set; }

        



    }
}
