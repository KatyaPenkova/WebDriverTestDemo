
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//create new chrome browser
var driver = new ChromeDriver();

//navigate to wikipedia
driver.Url = "https://wikipedia.org";
System.Console.WriteLine("Currant title:" + driver.Url);

var searchField = driver.FindElement(By.Id("searchInput"));
searchField.Click();
searchField.SendKeys("QA"+Keys.Enter);

System.Console.WriteLine("Title after search:" + driver.Url);
//close browser
driver.Quit(); 