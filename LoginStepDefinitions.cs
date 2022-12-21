using OpenQA.Selenium;
using SpecFlowProject1.Drivers;
using SpecFlowProject1.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions 
{
    [Binding]
    public class LoginStepDefinitions : Baseclass
    {
        //Baseclass basedriver;
        [Given(@"lanuch the application")]
        public void GivenLanuchTheApplication()
        {
            //throw new PendingStepException();
            //basedriver = new Baseclass();
            lanuch();

        }

        [Given(@"I enter following details")]
        public void GivenIEnterFollowingDetails(Table table)
        {
            
            Pagedetails l = new Pagedetails(driver);
            l.unm.SendKeys("standard_user");
            l.pss.SendKeys("secret_sauce");
            Thread.Sleep(3000);

        }

        [Given(@"I click on login button")]
        public void GivenIClickOnLoginButton()
        {
            
            Pagedetails login= new Pagedetails(driver);
            login.logbtn.Click();
            var alert = driver.SwitchTo().Alert();
            alert.Accept();


        }

        [Then(@"It should navigate to home page")]
        public void ThenItShouldNavigateToHomePage()
        {

            //throw new PendingStepException();
        }

        //add to cart
        [Given(@"Iam in home page")]
        public void GivenIamInHomePage()
        {
            //lanuch();
            //throw new PendingStepException();

        }

        [When(@"I click on add to cart button")]
        public void WhenIClickOnAddToCartButton()
        {
            //throw new PendingStepException();
            Pagedetails ad=new Pagedetails(driver);
            ad.addcart.Click();

        }

        [When(@"I click on  cart icon")]
        public void WhenIClickOnCartIcon()
        {
            //throw new PendingStepException();
            Pagedetails ic = new Pagedetails(driver);
            ic.icon.Click();
        }

        [Then(@"It should navigate to cart page")]
        public void ThenItShouldNavigateToCartPage()
        {
            //throw new PendingStepException();
        }




        //About page
        [Given(@"navigate to home page")]
        public void GivenNavigateToHomePage()
        {
            
            //throw new PendingStepException();
        }

        [Given(@"click on menubar")]
        public void GivenClickOnMenubar()
        {
            //throw new PendingStepException();
            Pagedetails me= new Pagedetails(driver);
            me.menuu.Click();
        }

        [Given(@"click on about")]
        public void GivenClickOnAbout()
        {
            //throw new PendingStepException();
            Pagedetails mu= new Pagedetails(driver);    
            mu.abt.Click();
        }

        [Then(@"It should navigate to about page")]
        public void ThenItShouldNavigateToAboutPage()
        {
            //throw new PendingStepException();
            //driver.Navigate().Back();
        }

        


    }
}
