using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading;

namespace Automation_Proj
{
    #region TestClasses

    [TestClass]
    [TestCategory("dragAnddrop")]
    public class UnitTest1 : BasePage
    {
        DragAndDRop dnd = new DragAndDRop();
        BasePage basepage = new BasePage();
        [TestMethod]

        public void TestCase_1()
        {
            basepage.seleniuminit();
            dnd.DragDrop("https://www.demoqa.com/droppable");

        }
    }

    [TestClass]
    [TestCategory("Resizable")]
    public class UnitTest2 : BasePage
    {

        BasePage basepage = new BasePage();
        Resizable resizable = new Resizable();
        [TestMethod]

        public void TestCase_Positive()
        {
            Thread.Sleep(5000);

            basepage.seleniuminit();


            resizable.Resize("https://www.demoqa.com/resizable", 500, 300);



        }
        [TestMethod]
        public void TestCase_Negative()
        {
            Thread.Sleep(5000);

            basepage.seleniuminit();

            resizable.Resize("https://www.demoqa.com/resizable", 200, 300);

           
        }
    }
    [TestClass]
    [TestCategory("Selectable")]
    public class UnitTest3 : BasePage
    {
        BasePage basepage = new BasePage();
        Selectable selectable = new Selectable();
        [TestMethod]

        public void TestCase_List()
        {
            basepage.seleniuminit();
            selectable.SelectList();


        }
        [TestMethod]
        public void TestCase_Grid()
        {
            basepage.seleniuminit();
            selectable.SelectGrid();

        }
    }

    [TestClass]
    [TestCategory("Sortable")]
    public class UnitTest4 : BasePage
    {
        BasePage basepage = new BasePage();
        Sortable sortable = new Sortable();
        [TestMethod]
        public void TestCase_SortList()
        {
            basepage.seleniuminit();
            sortable.SortList("https://www.demoqa.com/sortable",0,26,0,-26);

        }

        [TestMethod]
        public void TestCase_SortGrid()
        {
            basepage.seleniuminit();
            sortable.SortGrid("https://www.demoqa.com/sortable",108, 0, 0, -108);

        }
    }

    [TestClass]
    [TestCategory("BookStoreApp")]
    public class UnitTest5 : BasePage
    {
        BasePage basepage = new BasePage();
        BookStoreApp bookstoreapp = new BookStoreApp();

        #region Login
        [TestMethod]
        public void TestCase_LoginValid()
        {
            basepage.seleniuminit();
            bookstoreapp.LoginValid("https://www.demoqa.com/login","umaima3390","Hello123@");

        }
        [TestMethod]
        public void TestCase_LoginInValidUsername()
        {
            basepage.seleniuminit();
            bookstoreapp.LoginInvalid("https://www.demoqa.com/login", "umaima101", "Hello123@");
        }
        [TestMethod]
        public void TestCase_LoginInValidPassword()
        {
            basepage.seleniuminit();
            bookstoreapp.LoginInvalid("https://www.demoqa.com/login", "umaima3390", "Hello12");
        }
        #endregion

        #region BookStore
        [TestMethod]
        public void TestCase_BookStore()
        {
            basepage.seleniuminit();
            bookstoreapp.BookStore("https://www.demoqa.com/login", "umaima3390", "Hello123@");
        }
        #endregion

        #region Profile
        [TestMethod]
        public void TestCase_Profile()
        {
            basepage.seleniuminit();
            bookstoreapp.Profile("https://www.demoqa.com/login");
        }
        #endregion
    }

    [TestClass]
    [TestCategory("nested test")]
    public class nestedFrame_test : BasePage
    {
        BasePage BasePage = new BasePage();
        [TestMethod]
        public void nested_test()
        {
            BasePage.seleniuminit();
            NestedFrames nestedFrames = new NestedFrames();
            nestedFrames.Nested();
        }
    }

    [TestClass]
    [TestCategory("wait_for_alert")]
    public class OnClickWait_test : BasePage
    {
        BasePage BasePage = new BasePage();
        OnClickWait onClick = new OnClickWait();
        [TestMethod]
        public void WaitAlert()
        {
            BasePage.seleniuminit();

            onClick.WaitPop();
        }

    }

    [TestClass]
    [TestCategory("Alert click buttton")]
    public class AlertMsgClick_Test
    {
        BasePage basePage = new BasePage();


        [TestMethod]

        public void AlertClick()
        {
            basePage.seleniuminit();
            AlertClick1 alerttt = new AlertClick1();
            alerttt.AlertMsg();


        }
    }

    [TestClass]
    [TestCategory("small test")]
    public class SmallTest : BasePage
    {
        BasePage BasePage = new BasePage();
        SmallModal smallModal = new SmallModal();
        [TestMethod]
        public void Small_Test()
        {
            BasePage.seleniuminit();
            smallModal.SmallModalTest();
        }


    }

    [TestClass]
    [TestCategory("new window")]
    public class NewWindow_Test
    {
        BasePage basePage = new BasePage();
        Newwindow newwindow1 = new Newwindow();
        [TestMethod]

        public void newwindow_check()
        {
            basePage.seleniuminit();
            newwindow1.newwindow();
        }
    }

    [TestClass]
    [TestCategory("Confirmation alert")]
    public class ConfirmTest : BasePage
    {
        BasePage BasePage = new BasePage();
        Confirmation conf = new Confirmation();
        [TestMethod]
        public void confirmtest()
        {
            BasePage.seleniuminit();
            conf.Confirm();
        }

    }

    [TestClass]
    [TestCategory("PrompTest")]
    public class TestPrompt : BasePage
    {
        BasePage basePage = new BasePage();
        PromptAlert prompttt = new PromptAlert();
        [TestMethod]
        public void MsgPrompt()
        {
            basePage.seleniuminit();
            prompttt.promptmsg();
        }

    }

    [TestClass]
    [TestCategory("Forms")]
    public class TestExecution
    {
        BasePage basepage = new BasePage();
        Registration register = new Registration();

        [TestMethod]
        public void TestCase_001()
        {
            basepage.seleniuminit();
            register.Register_ValidInput();

        }

        [TestMethod]
        public void TestCase_002()
        {
            basepage.seleniuminit();
            register.Register_InValid_Email();

        }

        [TestMethod]
        public void TestCase_003()
        {
            basepage.seleniuminit();
            register.Register_MendatoryInputOnly();
        }

        [TestMethod]
        public void TestCase_004()
        {
            basepage.seleniuminit();
            register.Register_InValid_Contactno();
        }

        [TestMethod]
        public void TestCase_005()
        {
            basepage.seleniuminit();
            register.Register_InpuNumbericValue_Name();

        }


    }

    #endregion

    #region NormalClass
    public class DragAndDRop : BasePage
    {
        public void DragDrop(String url)
        {
            driver.Manage().Window.Maximize();
            driver.Url = url;
            Actions actions = new Actions(driver);

            IWebElement from = driver.FindElement(By.Id("draggable"));
            IWebElement to = driver.FindElement(By.Id("droppable"));
            actions.DragAndDrop(from, to).Perform();

            String textTo = driver.FindElement(By.Id("droppable")).Text;
            driver.Close();

            if (textTo.Equals("Dropped!"))
            {
                System.Windows.Forms.MessageBox.Show("passed!: Source dropped");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("failed! not able to");
            }

        }

    }
    public class Resizable : BasePage
    {
        public void Resize(String url, int xOffset, int yOffset)
        {
            driver.Manage().Window.Maximize();
            driver.Url = url;

            Actions actions = new Actions(driver);
            IWebElement elementtoResize = driver.FindElement(By.Id("resizableBoxWithRestriction"));

            actions.ClickAndHold(elementtoResize).MoveByOffset(xOffset, yOffset).Release().Build().Perform();

            driver.Close();
            if (xOffset == 500 && yOffset == 300)
            {
                System.Windows.Forms.MessageBox.Show("Test Passed! Maximum Resize");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Test Passed! can be resized further");
            }
        }

    }
}
public class Selectable : BasePage
{
    public void SelectList()
    {
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.demoqa.com/selectable";
        Actions actions = new Actions(driver);
        IWebElement listButton = driver.FindElement(By.Id("demo-tab-list"));
        actions.Click(listButton).Release().Build().Perform();


        IWebElement value1 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[1]"));
        IWebElement value2 = driver.FindElement(By.XPath("html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[2]"));
        IWebElement value3 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[3]"));
        IWebElement value4 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[4]"));
        String value1txt = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[1]")).Text;

        actions.Click(value1).Release().Build().Perform();
        actions.Click(value2).Release().Build().Perform();
        actions.Click(value3).Release().Build().Perform();
        actions.Click(value4).Release().Build().Perform();

        driver.Close();

        if (value1txt == "Cras justo odio")
        {
            System.Windows.Forms.MessageBox.Show("Test Passed! options are selectable");

        }
        else
        {
            System.Windows.Forms.MessageBox.Show("Test Failed");
        }

    }

    public void SelectGrid()
    {
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.demoqa.com/selectable";
        Actions actions = new Actions(driver);
        IWebElement GridButton = driver.FindElement(By.Id("demo-tab-grid"));
        actions.Click(GridButton).Release().Build().Perform();

        IWebElement value1 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[2]/div/div[1]/li[1]"));
        IWebElement value2 = driver.FindElement(By.XPath("/ html/ body / div[2] / div / div / div[2] / div[2] / div[1] / div / div[2] / div / div[2] / li[2]"));
        IWebElement value3 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[2]/div/div[3]/li[3]"));
        Thread.Sleep(500);
        String value1txt = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[2]/div/div[1]/li[1]")).Text;

        actions.Click(value1).Release().Build().Perform();
        actions.Click(value2).Release().Build().Perform();
        actions.Click(value3).Release().Build().Perform();
        driver.Close();

        if (value1txt == "One")
        {
            System.Windows.Forms.MessageBox.Show("Test Passed!Grid is selectable");

        }
        else
        {
            System.Windows.Forms.MessageBox.Show("Test Failed");
        }


    }
}
public class Sortable : BasePage
{
    public void SortList(String url, int xOffset1, int yOffset1, int xOffset2, int yOffset2)
    {
        driver.Manage().Window.Maximize();
        driver.Url = url;
        Actions actions = new Actions(driver);
        IWebElement listButton = driver.FindElement(By.Id("demo-tab-list"));
        actions.Click(listButton).Release().Build().Perform();
        IWebElement elementtoSort = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[1]"));

        IWebElement elementtoSort1 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[3]"));
        actions.ClickAndHold(elementtoSort).MoveByOffset(xOffset1, yOffset1).Release().Build().Perform();
        actions.ClickAndHold(elementtoSort1).MoveByOffset(xOffset2, yOffset2).Release().Build().Perform();
        Thread.Sleep(50);
        driver.Close();
        if (yOffset1 == 26 && yOffset2 == -26)
        {
            System.Windows.Forms.MessageBox.Show("List is sortable");
        }
        else
        {
            System.Windows.Forms.MessageBox.Show("Test failed");
        }


    }
    public void SortGrid(String url, int xOffset1, int yOffset1, int xOffset2, int yOffset2)
    {
        driver.Manage().Window.Maximize();
        driver.Url = url;
        Actions actions = new Actions(driver);
        IWebElement listButton = driver.FindElement(By.Id("demo-tab-grid"));
        actions.Click(listButton).Release().Build().Perform();
        IWebElement elementtoSort = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[2]/div/div/div[1]"));
        IWebElement elementtoSort1 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div/div[2]/div/div/div[5]"));
        actions.ClickAndHold(elementtoSort).MoveByOffset(xOffset1, yOffset1).Release().Build().Perform();
        actions.ClickAndHold(elementtoSort1).MoveByOffset(xOffset2, yOffset2).Release().Build().Perform();
        Thread.Sleep(50);
        driver.Close();
        if ((xOffset1 == 108 && yOffset1 == 0) && (xOffset2 == 0 && yOffset2 == -108))
        {
            System.Windows.Forms.MessageBox.Show("Grid is sortable");
        }
        else
        {
            System.Windows.Forms.MessageBox.Show("Test failed");
        }

    }

}
public class BookStoreApp : BasePage
{

    public void LoginValid(String url1, String username, String password)
    {
        driver.Manage().Window.Maximize();
        driver.Url = url1;

        By usernameTxt = By.Id("userName");
        By passwordTxt = By.Id("password");
        driver.FindElement(usernameTxt).SendKeys(username);
        driver.FindElement(passwordTxt).SendKeys(password);
        driver.FindElement(By.Id("login")).Click();

        Thread.Sleep(2000);
        String urll = driver.Url;
        driver.Close();

        if (urll == "https://www.demoqa.com/profile")
        {
            System.Windows.Forms.MessageBox.Show("Test passed! logged in successfully");
        }
        else
        {
            System.Windows.Forms.MessageBox.Show("Test Failed");
        }

    }
    public void LoginInvalid(String url, String username, String password)
    {
        driver.Manage().Window.Maximize();
        driver.Url = url;
        By usernameTxt = By.Id("userName");
        By passwordTxt = By.Id("password");
        driver.FindElement(usernameTxt).SendKeys(username);
        driver.FindElement(passwordTxt).SendKeys(password);
        driver.FindElement(By.Id("login")).Click();

        Thread.Sleep(2000);
        String errormsg = driver.FindElement(By.Id("name")).Text;
        driver.Close();

        if (errormsg == "Invalid username or password!")
        {
            System.Windows.Forms.MessageBox.Show("Test passed! Error generated");
        }
        else
        {
            System.Windows.Forms.MessageBox.Show("Test Failed");
        }

    }
    public void BookStore(String url, String username, String password)
    {
        driver.Manage().Window.Maximize();
        driver.Url = url;
        By usernameTxt = By.Id("userName");
        By passwordTxt = By.Id("password");

        driver.FindElement(usernameTxt).SendKeys(username);
        driver.FindElement(passwordTxt).SendKeys(password);
        driver.FindElement(By.Id("login")).Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        IWebElement store = driver.FindElement(By.Id("gotoStore"));
        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
        jse.ExecuteScript("arguments[0].scrollIntoView();", store);
        Actions action = new Actions(driver);
        action.Click(store).Build().Perform();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        By searchTxt = By.Id("searchBox");

        driver.FindElement(searchTxt).SendKeys("javascript");
        IWebElement book = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div[2]/div[1]/div[2]/div[2]/div/div[2]/div/span/a"));

        book.Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        IWebElement btn = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div[2]/div[9]/div[2]/button"));
        jse.ExecuteScript("arguments[0].scrollIntoView();", btn);
        btn.Click();

        Thread.Sleep(5000);
        IAlert alert = driver.SwitchTo().Alert();
        String alertTxt = driver.SwitchTo().Alert().Text;

        alert.Accept();
        driver.SwitchTo().DefaultContent();
        driver.Close();

        if (alertTxt == "Book added to your collection.")
        {
            System.Windows.Forms.MessageBox.Show("Test Passed! Book Added");
        }
        else
        {
            System.Windows.Forms.MessageBox.Show("Test failed");
        }

    }

    private void LoginValid()
    {
        throw new NotImplementedException();
    }

    public void Profile(String url)
    {
        driver.Manage().Window.Maximize();
        driver.Url = url;

        By usernameTxt = By.Id("userName");
        By passwordTxt = By.Id("password");

        driver.FindElement(usernameTxt).SendKeys("umaima3390");
        driver.FindElement(passwordTxt).SendKeys("Hello123@");
        driver.FindElement(By.Id("login")).Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        By searchTxt = By.Id("searchBox");
        driver.FindElement(By.Id("searchBox")).SendKeys("javascript");

        IWebElement delete = driver.FindElement(By.Id("delete-record-undefined"));
        delete.Click();

        driver.SwitchTo().ActiveElement();
        IWebElement ok = driver.FindElement(By.Id("closeSmallModal-ok"));
        ok.Click();
        Thread.Sleep(2000);
        IAlert delalert = driver.SwitchTo().Alert();
        String alertTxt = driver.SwitchTo().Alert().Text;
        delalert.Accept();
        driver.SwitchTo().DefaultContent();
        driver.Close();
        if (alertTxt == "Book deleted.")
        {
            System.Windows.Forms.MessageBox.Show("Test Passed! Book Deleted");
        }
        else
        {
            System.Windows.Forms.MessageBox.Show("Test failed");
        }

    }
}

public class NestedFrames : BasePage
{
    public void Nested()
    {

        driver.Url = "https://demoqa.com/nestedframes";
        int countIframesInPage = driver.FindElements(By.TagName("iframe")).Count;
        System.Windows.Forms.MessageBox.Show("Number of Frames on a Page: " + countIframesInPage);
        IWebElement frame1 = driver.FindElement(By.Id("frame1"));

        driver.SwitchTo().Frame(frame1);

        IWebElement frame1Element = driver.FindElement(By.TagName("body"));

        String frame1Text = frame1Element.Text;
        System.Windows.Forms.MessageBox.Show("Frame1 is :" + frame1Text);

        int countIframesInFrame1 = driver.FindElements(By.TagName("iframe")).Count;
        System.Windows.Forms.MessageBox.Show("Number of iFrames inside the Frame1: " + countIframesInFrame1);
        driver.SwitchTo().Frame(0);

        int countIframesInFrame2 = driver.FindElements(By.TagName("iframe")).Count;
        System.Windows.Forms.MessageBox.Show("Number of iFrames inside the Frame2: " + countIframesInFrame2);
        driver.Quit();

    }
}

public class OnClickWait : BasePage
{
    public void WaitPop()
    {
        driver.Url = "https://demoqa.com/alerts";
        driver.FindElement(By.Id("timerAlertButton")).Click();
        Thread.Sleep(5000);
        IAlert alert = driver.SwitchTo().Alert();
        string simpleAlert = driver.SwitchTo().Alert().Text;
        alert.Accept();

        driver.Quit();
        System.Windows.Forms.MessageBox.Show(simpleAlert);

    }
}

public class AlertClick1 : BasePage
{

    public void AlertMsg()
    {
        driver.Url = "https://demoqa.com/alerts";
        driver.FindElement(By.Id("alertButton")).Click();
        string simpletext = driver.SwitchTo().Alert().Text;
        Console.WriteLine(simpletext);
        driver.SwitchTo().Alert().Accept();
        driver.Quit();

    }


}

public class SmallModal : BasePage
{
    public void SmallModalTest()
    {
        driver.Url = "https://demoqa.com/modal-dialogs";
        driver.FindElement(By.XPath("//button[contains(text(),'Small modal')]")).Click();
        //driver.FindElement(By.ClassName("mr-4 mt-2 btn btn-primary")).Click();
        String small = driver.FindElement(By.CssSelector("#example-modal-sizes-title-sm")).Text;
        Console.WriteLine(small);
        string modeltext = driver.FindElement(By.Id("example-modal-sizes-title-sm")).Text;
        Console.WriteLine(modeltext);
        Thread.Sleep(2000);
        driver.FindElement(By.XPath("//button[text()='Close']")).Click();
        driver.Quit();

    }
}

public class Newwindow : BasePage
{
    public void newwindow()
    {
        driver.Url = "https://demoqa.com/browser-windows";
        driver.FindElement(By.Id("windowButton")).Click();
        driver.Quit();
        System.Windows.Forms.MessageBox.Show("new window closed");

    }

}

public class Confirmation : BasePage
{
    public void Confirm()
    {

        driver.Url = "https://demoqa.com/alerts";
        driver.FindElement(By.Id("confirmButton")).Click();
        Thread.Sleep(2000);
        // string vari = driver.SwitchTo().Alert().Text;
        driver.SwitchTo().Alert().Accept();
        String result = driver.FindElement(By.Id("confirmResult")).Text;
        //Thread.Sleep(2000);
        driver.Quit();
        if (result == "You selected Ok")
        {
            System.Windows.Forms.MessageBox.Show("Test Passed!");
        }
        else
        {
            System.Windows.Forms.MessageBox.Show("Test Failed");
        }

    }
}

public class PromptAlert : BasePage
{
    public void promptmsg()
    {
        driver.Url = "https://demoqa.com/alerts";
        driver.FindElement(By.Id("promtButton")).Click();
        driver.SwitchTo().Alert().SendKeys("PrehAijazShaikh");

        driver.SwitchTo().Alert().Accept();
        System.Windows.Forms.MessageBox.Show("prompt closed after enterd value and clicked ok");
        driver.Quit();

    }
}

public class Registration : BasePage
{

    public void Register_ValidInput()
    {
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.demoqa.com/automation-practice-form";
        By firstnameTxt = By.Id("firstName");
        By lastnameTxt = By.Id("lastName");
        By emailTxt = By.Id("userEmail");
        By userNumber = By.Id("userNumber");
        By subjectTxt = By.Id("subjectsInput");
        By currentTxt = By.Id("currentAddress");

        //enter first name
        driver.FindElement(firstnameTxt).SendKeys("ayesha");

        //enter last name
        driver.FindElement(lastnameTxt).SendKeys("ahmed");

        //enter email address
        driver.FindElement(emailTxt).SendKeys("ayesha@gmail.com");

        //select the gender option
        IWebElement gender = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[3]/div[2]/div[2]"));
        gender.Click();

        //enter mobile number
        driver.FindElement(userNumber).SendKeys("1234567890");

        //date picker for date of birth
        var date = driver.FindElement(By.Id("dateOfBirthInput"));
        date.Click();
        var month = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/select"));
        var selectMonth = new SelectElement(month);
        selectMonth.SelectByText("October");
        var year = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select"));
        var selectYear = new SelectElement(year);
        selectYear.SelectByText("1998");
        var days = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[2]/div[3]/div[6]"));
        days.Click();

        // enter subjects by auto complete 
        driver.FindElement(subjectTxt).SendKeys("m");
        driver.FindElement(subjectTxt).SendKeys(Keys.Tab);
        driver.FindElement(subjectTxt).SendKeys("chemistry");
        driver.FindElement(subjectTxt).SendKeys(Keys.Enter);
        Thread.Sleep(3000);

        // use javascipt to scroll down page for more fields
        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
        IWebElement hobby = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[7]/div[2]/div[2]"));
        IWebElement subbtn = driver.FindElement(By.Id("submit"));

        jse.ExecuteScript("arguments[0].scrollIntoView();", hobby);

        //selecy hobbies 
        hobby.Click();

        //enter current address
        driver.FindElement(currentTxt).SendKeys("Street no 3 North Karachi");

        //click on submit button to get register
        subbtn.Click();
        Thread.Sleep(5000);
        driver.Close();

    }


    public void Register_MendatoryInputOnly()
    {
        Actions actions = new Actions(driver);
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.demoqa.com/automation-practice-form";
        By firstnameTxt = By.Id("firstName");
        By lastnameTxt = By.Id("lastName");
        By userNumber = By.Id("userNumber");

        //enter first name
        driver.FindElement(firstnameTxt).SendKeys("ayesha");

        //enter last name
        driver.FindElement(lastnameTxt).SendKeys("ahmed");

        //select the gender option
        IWebElement gender = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[3]/div[2]/div[2]"));
        gender.Click();

        //enter mobile number
        driver.FindElement(userNumber).SendKeys("1234567890");





        // use javascipt to scroll down page for more fields
        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
        IWebElement subbtn = driver.FindElement(By.Id("submit"));

        jse.ExecuteScript("arguments[0].scrollIntoView();", subbtn);

        //click on submit button to get register
        subbtn.Click();
        Thread.Sleep(5000);
        driver.Close();

    }


    public void Register_InValid_Email()
    {
        Actions actions = new Actions(driver);
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.demoqa.com/automation-practice-form";
        By firstnameTxt = By.Id("firstName");
        By lastnameTxt = By.Id("lastName");
        By emailTxt = By.Id("userEmail");
        By userNumber = By.Id("userNumber");
        By subjectTxt = By.Id("subjectsInput");
        By currentTxt = By.Id("currentAddress");

        //enter first name
        driver.FindElement(firstnameTxt).SendKeys("ayesha");

        //enter last name
        driver.FindElement(lastnameTxt).SendKeys("ahmed");

        //enter email address
        driver.FindElement(emailTxt).SendKeys("ayesha123");

        //select the gender option
        IWebElement gender = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[3]/div[2]/div[2]"));
        gender.Click();

        //enter mobile number
        driver.FindElement(userNumber).SendKeys("1234567890");

        //date picker for date of birth
        var date = driver.FindElement(By.Id("dateOfBirthInput"));
        date.Click();
        var month = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/select"));
        var selectMonth = new SelectElement(month);
        selectMonth.SelectByText("October");
        var year = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select"));
        var selectYear = new SelectElement(year);
        selectYear.SelectByText("1998");
        var days = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[2]/div[3]/div[6]"));
        days.Click();

        // enter subjects by auto complete 
        driver.FindElement(subjectTxt).SendKeys("m");
        driver.FindElement(subjectTxt).SendKeys(Keys.Tab);
        driver.FindElement(subjectTxt).SendKeys("chemistry");
        driver.FindElement(subjectTxt).SendKeys(Keys.Enter);
        Thread.Sleep(3000);

        // use javascipt to scroll down page for more fields
        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
        IWebElement hobby = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[7]/div[2]/div[2]"));
        IWebElement subbtn = driver.FindElement(By.Id("submit"));

        jse.ExecuteScript("arguments[0].scrollIntoView();", hobby);

        //selecy hobbies 
        hobby.Click();

        //enter current address
        driver.FindElement(currentTxt).SendKeys("Street no 3 North Karachi");

        //click on submit button to get register
        subbtn.Click();
        Thread.Sleep(5000);
        driver.Close();

    }

    public void Register_InValid_Contactno()
    {
        Actions actions = new Actions(driver);
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.demoqa.com/automation-practice-form";
        By firstnameTxt = By.Id("firstName");
        By lastnameTxt = By.Id("lastName");
        By emailTxt = By.Id("userEmail");
        By userNumber = By.Id("userNumber");
        By subjectTxt = By.Id("subjectsInput");
        By currentTxt = By.Id("currentAddress");

        //enter first name
        driver.FindElement(firstnameTxt).SendKeys("ayesha");

        //enter last name
        driver.FindElement(lastnameTxt).SendKeys("ahmed");

        //enter email address
        driver.FindElement(emailTxt).SendKeys("ayesha@gmail.com");

        //select the gender option
        IWebElement gender = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[3]/div[2]/div[2]"));
        gender.Click();

        //enter mobile number
        driver.FindElement(userNumber).SendKeys("12345");

        //date picker for date of birth
        var date = driver.FindElement(By.Id("dateOfBirthInput"));
        date.Click();
        var month = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/select"));
        var selectMonth = new SelectElement(month);
        selectMonth.SelectByText("October");
        var year = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select"));
        var selectYear = new SelectElement(year);
        selectYear.SelectByText("1998");
        var days = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[2]/div[3]/div[6]"));
        days.Click();

        // enter subjects by auto complete 
        driver.FindElement(subjectTxt).SendKeys("m");
        driver.FindElement(subjectTxt).SendKeys(Keys.Tab);
        driver.FindElement(subjectTxt).SendKeys("chemistry");
        driver.FindElement(subjectTxt).SendKeys(Keys.Enter);
        Thread.Sleep(3000);

        // use javascipt to scroll down page for more fields
        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
        IWebElement hobby = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[7]/div[2]/div[2]"));
        IWebElement subbtn = driver.FindElement(By.Id("submit"));

        jse.ExecuteScript("arguments[0].scrollIntoView();", hobby);

        //selecy hobbies 
        hobby.Click();

        //enter current address
        driver.FindElement(currentTxt).SendKeys("Street no 3 North Karachi");

        //click on submit button to get register
        subbtn.Click();
        Thread.Sleep(5000);
        driver.Close();

    }


    public void Register_InpuNumbericValue_Name()
    {
        Actions actions = new Actions(driver);
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.demoqa.com/automation-practice-form";
        By firstnameTxt = By.Id("firstName");
        By lastnameTxt = By.Id("lastName");
        By emailTxt = By.Id("userEmail");
        By userNumber = By.Id("userNumber");
        By subjectTxt = By.Id("subjectsInput");
        By currentTxt = By.Id("currentAddress");

        //enter first name
        driver.FindElement(firstnameTxt).SendKeys("12345");

        //enter last name
        driver.FindElement(lastnameTxt).SendKeys("5678");

        //enter email address
        driver.FindElement(emailTxt).SendKeys("ayesha@gmail.com");

        //select the gender option
        IWebElement gender = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[3]/div[2]/div[2]"));
        gender.Click();

        //enter mobile number
        driver.FindElement(userNumber).SendKeys("1234567890");

        //date picker for date of birth
        var date = driver.FindElement(By.Id("dateOfBirthInput"));
        date.Click();
        var month = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/select"));
        var selectMonth = new SelectElement(month);
        selectMonth.SelectByText("October");
        var year = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select"));
        var selectYear = new SelectElement(year);
        selectYear.SelectByText("1998");
        var days = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[5]/div[2]/div[2]/div[2]/div/div/div[2]/div[2]/div[3]/div[6]"));
        days.Click();

        // enter subjects by auto complete 
        driver.FindElement(subjectTxt).SendKeys("m");
        driver.FindElement(subjectTxt).SendKeys(Keys.Tab);
        driver.FindElement(subjectTxt).SendKeys("chemistry");
        driver.FindElement(subjectTxt).SendKeys(Keys.Enter);
        Thread.Sleep(3000);

        // use javascipt to scroll down page for more fields
        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
        IWebElement hobby = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/form/div[7]/div[2]/div[2]"));
        IWebElement subbtn = driver.FindElement(By.Id("submit"));

        jse.ExecuteScript("arguments[0].scrollIntoView();", hobby);

        //selecy hobbies 
        hobby.Click();

        //enter current address
        driver.FindElement(currentTxt).SendKeys("Street no 3 North Karachi");

        //click on submit button to get register
        subbtn.Click();
        Thread.Sleep(5000);
        driver.Close();

    }

}
#endregion


public class BasePage
{
    public static IWebDriver driver;
    public void seleniuminit()
    {
        var thisDriver = new ChromeDriver();
        driver = thisDriver;

    }

}


