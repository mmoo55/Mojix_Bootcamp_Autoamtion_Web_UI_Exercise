using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.todoist
{
    public class TaskSection
    {
        public Label addTaskLabel = new Label(By.XPath("//button[@class='plus_add_button']"));
        public TextBox nameTaskTxtBox = new TextBox(By.XPath("//p[contains(@data-placeholder, 'tarea')]"));
        public Button addTaskButton = new Button(By.XPath("//button[@data-testid='task-editor-submit-button']"));

        public void ClickOnTask(String nameTask)
        {
            Label nameTaskLabel = new Label(By.XPath("(//div[text()='" + nameTask + "'])[last()]"));
            nameTaskLabel.Click();
        }

        public void RightClickOnProject(String nameTask)
        {
            Label nameTaskLabel = new Label(By.XPath("(//div[text()='" + nameTask + "'])[last()]"));
            nameTaskLabel.RightClick();
        }

        public Boolean IsProjectDisplayedInList(String nameTask)
        {
            Label nameTaskLabel = new Label(By.XPath("(//div[text()='" + nameTask + "'])[last()]"));
            return nameTaskLabel.IsControlDisplayed();
        }

        public Label GetTask(String nameTask)
        {
            Label nameTaskLabel = new Label(By.XPath("(//div[text()='" + nameTask + "'])[last()]"));
            return nameTaskLabel;
        }
    }
}
