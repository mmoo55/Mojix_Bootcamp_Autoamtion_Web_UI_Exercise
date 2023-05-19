using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.yopmail
{
    public class MainPage
    {
        public TextBox emailLoginTxtBox = new TextBox(By.Id("login"));
        public Button sendEmailLoginButton = new Button(By.XPath("//button"));
    }
}
