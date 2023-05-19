using ExerciseMojixBootcamp.src.code.page.yopmail;
using ExerciseMojixBootcamp.src.code.session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.test.yopmail
{
    [TestClass]
    public class SendEmailTest : TestBase
    {

        MainPage mainPage = new MainPage();
        EmailSection emailSection = new EmailSection();
        MessageSection messageSection = new MessageSection();

        string EMAIL = "gersonprueba";

        [TestMethod]
        public void VerifySentEmail()
        {

            string emailAddress = EMAIL + "@yopmail.com";
            string emailSubject = "Prueba " + (DateTime.Now).ToString();
            string emailMessageBody = "Prueba";

            mainPage.emailLoginTxtBox.SetText(EMAIL);
            mainPage.sendEmailLoginButton.Click();
            Assert.IsTrue(emailSection.emailTitle.IsControlDisplayed(), "ERROR! the login was faield");

            emailSection.newMailButton.Click();

            session.Session.Instance().ChangeFrame("ifmail");
            messageSection.recipientTxtBox.SetText(emailAddress);
            messageSection.subjectTxtBox.SetText(emailSubject);
            messageSection.messageBodyTxtBox.SetText(emailMessageBody);
            messageSection.sendEmailButton.Click();

            session.Session.Instance().BackToPrincipalPage();
            emailSection.refreshButton.Click();
            Session.Instance().ChangeFrame("ifinbox");
            Assert.IsTrue(emailSection.emailLabel.IsControlDisplayed(), "ERROR! the message was not sent");
        }
    }
}
