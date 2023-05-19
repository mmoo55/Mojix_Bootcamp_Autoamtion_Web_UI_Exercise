using ExerciseMojixBootcamp.src.code.page.todoist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMojixBootcamp.src.code.test.todoist
{
    [TestClass]
    public class CRUDProjectTestTodoist : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginPage loginPage = new LoginPage();
        MenuProjectSection menuProjectSection = new MenuProjectSection();
        ProjectSection projectSection = new ProjectSection();

        CreateUpdateDeleteProjectSection createUpdateDeleteProjectSection = new CreateUpdateDeleteProjectSection();

        MenuSection menuSection = new MenuSection();

        string USER = "g.gerson51@gmail.com";
        string PASSWORD = "Prueba12345678";

        [TestMethod]
        public void VerifyCRUDProject()
        {
            string projectCreated = "Prueba" + (DateTime.Now).ToString();
            string projectUpdated = "Nuevo nombre";

            mainPage.loginLabel.Click();
            loginPage.Login(USER, PASSWORD);
            Assert.IsTrue(menuSection.searchTxtBox.IsControlDisplayed(), "ERROR! the login was failed");

            // CREATE
            projectSection.addProjectButton.Click();
            createUpdateDeleteProjectSection.nameTxtBox.SetText(projectCreated);
            createUpdateDeleteProjectSection.addSaveDeleteButton.Click();
            Assert.IsTrue(projectSection.IsProjectDisplayedInList(projectCreated), "ERROR! the project was not created");

            // UPDATE
            projectSection.RightClickOnProject(projectCreated);
            menuProjectSection.editProjectLabel.Click();
            createUpdateDeleteProjectSection.nameTxtBox.SetText(projectUpdated);
            createUpdateDeleteProjectSection.addSaveDeleteButton.Click();
            Assert.IsTrue(projectSection.IsProjectDisplayedInList(projectCreated+projectUpdated), "ERROR! the project was not updated");

            // DELETE
            projectSection.RightClickOnProject(projectCreated+projectUpdated);
            menuProjectSection.deleteProjectLabel.Click();
            createUpdateDeleteProjectSection.addSaveDeleteButton.Click();
            Assert.IsFalse(projectSection.IsProjectDisplayedInList(projectCreated+projectUpdated), "ERROR! the project was not deleted");


        }
    }
}
