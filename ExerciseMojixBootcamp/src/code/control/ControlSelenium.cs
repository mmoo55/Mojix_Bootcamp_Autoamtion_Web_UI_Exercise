using OpenQA.Selenium;
using ExerciseMojixBootcamp.src.code.session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ExerciseMojixBootcamp.src.code.control
{
    public class ControlSelenium
    {
        protected By locator;
        protected IWebElement control;
        protected Actions action;

        public ControlSelenium(By locator)
        {
            this.locator = locator;
        }

        protected void FindControl()
        {
            control = Session.Instance().GetBrowser().FindElement(locator);
        }

        protected void MouseActions()
        {
            action = new Actions(session.Session.Instance().GetBrowser());
        }

        public void Click()
        {
            FindControl();
            control.Click();
        }

        public void RightClick()
        {
            this.MouseActions();
            this.FindControl();
            action.ContextClick(control).Perform();
        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return control.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void WaitControlIsNotInThePage()
        {
            WebDriverWait explicitWait = new WebDriverWait(session.Session.Instance().GetBrowser(), TimeSpan.FromSeconds(10));
            explicitWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(this.locator));
        }
    }
}