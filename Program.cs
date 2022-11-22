using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Timers;
using OpenQA.Selenium.Interactions;

namespace AssignmentAuto
{
    public class AutomationDriver

    {

        static IWebDriver driver = new ChromeDriver();
        static IWebElement radio1, radio2, radio3;
        static IWebElement checkBox, checkBox2, checkBox3,bye1;
        public void exerciseOne(int n)

        {
            switch (n)
            {
                case 1:
                    radio1 = driver.FindElement(By.CssSelector("#radio-btn-example > fieldset > label:nth-child(2) > input"));
                    radio1.Click();

                    if (radio1.GetAttribute("checked") == "true")
                    {
                        Console.WriteLine("Radio 1 Button is clicked");
                    }
                    else
                    {
                        Console.WriteLine("Radio 1 button is not clicked");
                    }

                    break;

                case 2:
                    radio2 = driver.FindElement(By.CssSelector("#radio-btn-example > fieldset > label:nth-child(3) > input"));
                    radio2.Click();

                    if (radio2.GetAttribute("checked") == "true")
                    {
                        Console.WriteLine("Radio 2 Button is clicked");
                    }

                    else
                    {
                        Console.WriteLine("Radio 2 button is not clicked");
                    }

                    break;

                case 3:
                    radio3 = driver.FindElement(By.CssSelector("#radio-btn-example > fieldset > label:nth-child(4) > input"));
                    radio3.Click();

                    if (radio3.GetAttribute("checked") == "true")
                    {
                        Console.WriteLine("Radio 3 Button is clicked");
                    }

                    else
                    {
                        Console.WriteLine("Radio 3 button is not clicked");
                    }

                    break;
            }
        }

        public void exerciseTwo()
        {
            
            driver.FindElement(By.CssSelector("#autocomplete")).SendKeys("United States");
            //driver.FindElement(By.Name("United States Minor Outlying Islands"));

        }

        public void exerciseThree()
        {
            SelectElement dropdown = new SelectElement(driver.FindElement(By.CssSelector("#dropdown-class-example")));
            dropdown.SelectByValue("option1");
            Console.WriteLine("Option 1 selected");
            Thread.Sleep(1000);
            dropdown.SelectByValue("option2");
            Console.WriteLine("option 2 selected");
            Thread.Sleep(1000);
            dropdown.SelectByValue("option3");
            Console.WriteLine("Option 3 selected");
            Thread.Sleep(1000);



        }

        public void exerciseFour()

        {
            
            checkBox=driver.FindElement(By.Id("checkBoxOption1"));
            checkBox.Click();
            if (checkBox.GetAttribute("checked") == "true")
                Console.WriteLine("Option 1 is selected");
            Thread.Sleep(1000);
            checkBox.Click();
            Thread.Sleep(1000);
            checkBox2=driver.FindElement(By.XPath("//*[@id=\"checkBoxOption2\"]"));
            checkBox2.Click();
            if (checkBox2.GetAttribute("checked") == "true")
                Console.WriteLine("Option 2 is selected");
            Thread.Sleep(1000);
            checkBox2.Click();
            Thread.Sleep(1000);
            checkBox3 =driver.FindElement(By.CssSelector("#checkBoxOption3"));
            checkBox3.Click();
            if (checkBox3.GetAttribute("checked") == "true")
                Console.WriteLine("Option 3 is selected");
            Thread.Sleep(1000);
            checkBox3.Click();
            Thread.Sleep(1000);
           
            


        }

        public void exerciseFourPointOne()

        {

            checkBox.Click();
            checkBox2.Click();
            checkBox3.Click();
            Thread.Sleep(1000);

        }

        public void exerciseFourPointTwo()

        {
            checkBox.Click();
            checkBox2.Click();
            checkBox3.Click();
            Thread.Sleep(1000);
        }

        public void exerciseFive()
        {
            driver.FindElement(By.CssSelector("#openwindow")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(1000);
        }

        public void exerciseSix()
        {
            driver.FindElement(By.Id("opentab")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
           // driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.Close();
            //Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles.First());
            //driver.Close();


            Thread.Sleep(2000);


        }

        public void exerciseSeven()
        {
            driver.FindElement(By.CssSelector("#name")).SendKeys("Shubham");
            driver.FindElement(By.CssSelector("#alertbtn")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
        }
        public void exerciseEight()
        {
            Actions a = new Actions(driver);
            IWebElement MouseScroll = driver.FindElement(By.CssSelector("body > div:nth-child(5) > div.left-align > fieldset > legend"));
            Thread.Sleep(1000);
        }
        public void exerciseNine()

        {
            Actions a = new Actions(driver);
            IWebElement MouseOver = driver.FindElement(By.CssSelector("#mousehover"));
            a.MoveToElement(MouseOver).Click().Build().Perform();
            Thread.Sleep(5000);
            IWebElement MouseClick = driver.FindElement(By.CssSelector("body > div:nth-child(6) > div > fieldset > div > div > a:nth-child(1)"));
            a.MoveToElement(MouseClick).Click().Build().Perform();
            Thread.Sleep(5000);
        }

        public static void Main()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.qaclickacademy.com/practice.php");
            AutomationDriver o = new AutomationDriver();
            o.exerciseOne(1);
            Thread.Sleep(1000);
            o.exerciseOne(2);
            Thread.Sleep(1000);
            o.exerciseOne(3);
            Thread.Sleep(2000);
            o.exerciseTwo();
            Thread.Sleep(2000);
            o.exerciseTwo();
            Thread.Sleep(2000);
            o.exerciseThree();
            Thread.Sleep(1000);
            o.exerciseFour();
            o.exerciseFourPointOne();
            o.exerciseFourPointTwo();
            o.exerciseFive();
            o.exerciseSix();
            o.exerciseSeven();
            o.exerciseEight();
            o.exerciseNine();

            driver.Quit();
        }



    }

}