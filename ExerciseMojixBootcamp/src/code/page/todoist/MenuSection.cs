using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.todoist
{
    public class MenuSection
    {
        public TextBox searchTxtBox = new TextBox(By.XPath("//input[@placeholder='Buscar']"));
    }
}
