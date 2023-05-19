using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.todoist
{
    public class TaskModalMenu
    {
        public Button deleteTaskButton = new Button(By.XPath("//button[contains(@aria-label,'Eliminar')]"));
    }
}
