using ExerciseMojixBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.page.todoist
{
    public class MenuProjectSection
    {
        public Label editProjectLabel = new Label(By.XPath("//div[text()='Editar proyecto']"));
        public Label deleteProjectLabel = new Label(By.XPath("//div[text()='Eliminar proyecto']"));
    }
}
