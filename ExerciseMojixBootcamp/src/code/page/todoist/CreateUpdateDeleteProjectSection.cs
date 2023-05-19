using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.todoist
{
    public class CreateUpdateDeleteProjectSection
    {
        public TextBox nameTxtBox = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button addSaveDeleteButton = new Button(By.XPath("//footer//button[@type='submit']"));
    }
}
