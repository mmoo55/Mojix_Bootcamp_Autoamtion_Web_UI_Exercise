using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.todoist
{
    public class MainPage
    {
        public Label loginLabel = new Label(By.XPath("//ul//a[contains(text(), 'Iniciar')]"));
    }
}
