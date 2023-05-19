using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.yopmail
{
    public class EmailSection
    {
        public Label emailTitle = new Label(By.XPath("//div[@class='bname']"));
        public Button newMailButton = new Button(By.Id("newmail"));
        public Button refreshButton = new Button(By.Id("refresh"));
        public Label emailLabel = new Label(By.XPath("//div[@currentmail]"));
    }
}
