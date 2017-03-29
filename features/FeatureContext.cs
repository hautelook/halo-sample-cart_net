using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace halo_erp_sample_cart
{
    [Binding]
    public class FeatureContext
    {

        private Cart cart;

        [Given(@"I have an empty cart")]
        public void GivenIHaveAnEmptyCart()
        {
            cart = new Cart();
        }
        
        [Given(@"I have a cart with a ""(.*)"" dollar item named ""(.*)""")]
        public void GivenIHaveACartWithADollarItemNamed(int price, string itemName)
        {
            throw new NotImplementedException();
        }
        
        [Given(@"I add a ""(.*)"" dollar item named ""(.*)""")]
        public void GivenIAddADollarItemNamed(int price, string itemName)
        {
            throw new NotImplementedException();
        }
        
        [When(@"I add a ""(.*)"" dollar item named ""(.*)""")]
        public void WhenIAddADollarItemNamed(int price, string itemName)
        {
            throw new NotImplementedException();
        }
        
        [When(@"I apply a ""(.*)"" percent coupon code")]
        public void WhenIApplyAPercentCouponCode(int discount)
        {
            throw new NotImplementedException();
        }
        
        [When(@"I add a ""(.*)"" dollar ""(.*)"" lb item named ""(.*)""")]
        public void WhenIAddADollarLbItemNamed(int price, int weight, string itemName)
        {
            throw new NotImplementedException();
        }

        [Then(@"My subtotal should be ""(.*)"" dollars")]
        public void ThenMySubtotalShouldBeDollars(int subtotal)
        {
            Assert.AreEqual(subtotal, this.cart.Subtotal());
        }
        
        [Then(@"My quantity of products named ""(.*)"" should be ""(.*)""")]
        public void ThenMyQuantityOfProductsNamedShouldBe(string itemName, int quantity)
        {
            throw new NotImplementedException();
        }
        
        [Then(@"I apply a ""(.*)"" percent coupon code")]
        public void ThenIApplyAPercentCouponCode(int discount)
        {
            throw new NotImplementedException();
        }
        
        [Then(@"I add a ""(.*)"" dollar item named ""(.*)""")]
        public void ThenIAddADollarItemNamed(int price, string itemName)
        {
            throw new NotImplementedException();
        }
        
        [Then(@"My total should be ""(.*)"" dollars")]
        public void ThenMyTotalShouldBeDollars(int total)
        {
            throw new NotImplementedException();
        }
    }
}
