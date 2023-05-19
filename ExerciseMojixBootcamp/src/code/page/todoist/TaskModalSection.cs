using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.todoist
{
    public class TaskModalSection
    {
        public TextBox editTaskTxtBox = new TextBox(By.XPath("(//div[@data-dialog]//p)[first()]"));
        public Button saveTaskButton = new Button(By.XPath("//div[@data-dialog]//button[@type='submit']/span[text()='Guardar']"));
        public Button closeTaskModalButton = new Button(By.XPath("//button[@aria-label = 'Cerrar ventana']"));
        public Button taskModalMenuButton = new Button(By.XPath("//div[@data-dialog]//div[@data-testid='button-container']//button[@aria-haspopup='menu']"));

        public void ClickOnTask(String nameTask)
        {
            Label taskCreated = new Label(By.XPath("//div[@role='button']/div[text()='" + nameTask + "']"));
            taskCreated.Click();
        }

        public void RightClickOnProject(String nameTask)
        {
            Label taskCreated = new Label(By.XPath("//div[@role='button']/div[text()='" + nameTask + "']"));
            taskCreated.RightClick();
        }

        public Boolean IsProjectDisplayedInList(String nameTask)
        {
            Label nameTaskLabel = new Label(By.XPath("//div[@role='button']/div[text()='" + nameTask + "']"));
            return nameTaskLabel.IsControlDisplayed();
        }

        public Label GetTask(String nameTask)
        {
            Label taskCreated = new Label(By.XPath("//div[@role='button']/div[text()='" + nameTask + "']"));
            return taskCreated;
        }

        public void SetTextOnEditTaskTxtBox(String nameTask)
        {
            TextBox editTaskTxtBox = new TextBox(By.XPath("//div[@data-dialog]//p[text() = '" + nameTask + "']"));
            editTaskTxtBox.SetText(nameTask);
        }
    }
}
