using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.todoist
{
    public class ProjectSection
    {
        public Button addProjectButton = new Button(By.XPath("//button[contains(@aria-label, 'dir proyecto')]"));
        
        public void ClickOnProject(String nameProject)
        {
            Label projectCreated = new Label(By.XPath("(//a//span[text()='" + nameProject + "'])[last()]"));
            projectCreated.Click();
        }

        public void RightClickOnProject(String nameProject)
        {
            Label projectCreated = new Label(By.XPath("(//a//span[text()='" + nameProject + "'])[last()]"));
            projectCreated.RightClick();
        }

        public Boolean IsProjectDisplayedInList(String nameProject)
        {
            Label nameProjectLabel = new Label(By.XPath("(//a//span[text()='" + nameProject + "'])[last()]"));
            return nameProjectLabel.IsControlDisplayed();
        }

        public Label GetProject(String nameProject)
        {
            Label projectCreated = new Label(By.XPath("(//a//span[text()='" + nameProject + "'])[last()]"));
            return projectCreated;
        }
    }
}
