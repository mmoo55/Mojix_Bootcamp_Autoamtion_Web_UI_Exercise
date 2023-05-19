using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.todoist
{
    public class LoginPage
    {
        public TextBox emailTxtBox = new TextBox(By.XPath("//input[@placeholder='Introduce tu email...']"));
        public TextBox passwordTxtBox = new TextBox(By.XPath("//input[contains(@placeholder,'Introduce tu contra')]"));
        public Button iniciarSesionButton = new Button(By.XPath("//form/button"));

        public void Login(String email, String pwd)
        {
            emailTxtBox.SetText(email);
            passwordTxtBox.SetText(pwd);
            iniciarSesionButton.Click();
        }
    }
}
