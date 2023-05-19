using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.yopmail
{
    public class MessageSection
    {
        public TextBox recipientTxtBox = new TextBox(By.Id("msgto"));
        public TextBox subjectTxtBox = new TextBox(By.Id("msgsubject"));
        public TextBox messageBodyTxtBox = new TextBox(By.Id("msgbody"));
        public Button sendEmailButton = new Button(By.Id("msgsend"));
    }
}
